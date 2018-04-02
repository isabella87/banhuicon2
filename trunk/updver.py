#!/usr/bin/env python
# -*- coding: utf-8 -*-

from __future__ import print_function, division, absolute_import, unicode_literals

from os import getcwd
from os.path import realpath, join as joinpath, isfile
from re import compile as compile_re, DOTALL, IGNORECASE, VERBOSE
from pysvn import Client as SvnClient, opt_revision_kind as svn_revision_kind

try:
    int = long
except:
    pass

try:
    str = unicode
except:
    pass


def parse_int(s):
    ''' s 待解析的值，如果以0x开头则按照16进制解析，否则按照10进制解析。
    -> 解析的结果。
    解析数值。
    '''
    if isinstance(s, int):
        return s
    elif isinstance(s, str):
        s = s.strip()
        if s.startswith('0x') or s.startswith('0X'):
            return int(s, 16)
        else:
            return int(s)
    else:
        return 0


def get_revision_number(basedir=None):
    ''' p SVN的路径。
    -> 修订次数。
    从SVN中获取修订次数。
    '''
    client = SvnClient()
    ent = client.info(basedir) if basedir else client.info(getcwd())
    rev = ent.revision
    if rev:
        if rev.kind == svn_revision_kind.number:
            return rev.number

    return 0


def inc_build_number(basedir=None):
    '''
    -> 最新的构建次数。
    递增构建次数，每次调用此函数都会导致构建次数加1，如果记录构建次数的文件不存在则创建该文件，并且将构建次数设置为1。
    '''
    bnfile = _BUILD_NUMBER_FILE_NAME
    if basedir:
        bnfile = realpath(joinpath(basedir, bnfile))

    bn = 0
    if isfile(bnfile):
        with open(bnfile, 'r') as f:
            l = f.readline()
            try:
                bn = int(l)
            except ValueError:
                pass

    bn = bn + 1

    with open(bnfile, 'w') as f:
        print(bn, file=f)

    return bn


def update_revision_number(cnt, rev, build):
    ''' cnt 包含文件内容的列表，每一项是文件的一行。
    rev 修订次数，来自SVN。
    build 构建次数，来自本地文件。
    -> 修改的行数。
    查找每一行，如果找到版本号则修改版本号，将修订次数和构建次数替换为指定的值。    
    '''
    if not cnt:
        return None

    rev = int(rev)
    build = int(build)

    ret = 0
    for i in range(0, len(cnt)):
        line = cnt[i]
        mo = _VERSION_PATTERN.search(line)
        if mo:
            major = parse_int(mo.group(1))
            minor = parse_int(mo.group(2))
            version = '%d.%d.%d.%d' % (major, minor, rev, build)
            cnt[i] = line[:mo.start()] + version + line[mo.end():]
            ret = ret + 1

    return ret

_SOURCE_FILE_NAME = 'Properties/AssemblyInfo.cs'
_BUILD_NUMBER_FILE_NAME = 'buildno'
_VERSION_PATTERN = compile_re(r'(\d+)\.(\d+)\.(\d+)\.(\d+)', IGNORECASE or DOTALL or VERBOSE)


def run(basedir=None):
    '''
    '''
    srcfile = _SOURCE_FILE_NAME
    if basedir:
        srcfile = realpath(joinpath(basedir, srcfile))

    cnt = []
    with open(srcfile, 'rb') as f:
        for line in f:
            cnt.append(line.decode('utf8'))

    rev = get_revision_number(basedir)
    if rev:
        print('Revision number is %d' % rev)

    build = inc_build_number(basedir)
    if build:
        print('Build number has been updated to %d' % build)

    update_revision_number(cnt, rev, build)

    with open(srcfile, 'wb') as f:
        for line in cnt:
            print(line.encode('utf8'), end='', file=f)


if __name__ == '__main__':
    '''
    '''
    run()
