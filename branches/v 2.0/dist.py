#!/usr/bin/env python
# -*- coding: utf-8 -*-

from __future__ import print_function, division, absolute_import, unicode_literals

from sys import argv, stdin, stdout, stderr
from os import makedirs, chdir, unlink
from os.path import basename, dirname, realpath, join as joinpath, isfile, isdir
from subprocess import Popen, call, PIPE
from shutil import rmtree, copy, copy2, copytree, make_archive as mkarch

import updver

VCVARS = 'vsvars32.bat'
MSVC2013 = 'C:\\Program Files (x86)\\Microsoft Visual Studio 12.0\\Common7\\Tools'
_BIN_DIR = '../bin'
_PKG_FILE = '../pkg'


def _msvc_env():
    '''
    '''
    return realpath(joinpath(MSVC2013, VCVARS))


def _copy(src, dst):
    '''
    '''
    src = realpath(joinpath(BASEDIR, src))
    dst = realpath(joinpath(BASEDIR, dst))

    if isfile(dst):
        unlink(dst)
    elif isdir(dst):
        pass
    else:
        makedirs(dst)

    print(src, '->', dst)
    if isfile(src):
        copy(src, dst)
    elif isdir(src):
        copytree(src, joinpath(dst, basename(src)))
    else:
        print('unknown src: ', src)


def init(basedir=None):
    '''
    '''
    bindir = _BIN_DIR
    if basedir:
        bindir = realpath(joinpath(basedir, bindir))

    rmtree(bindir, ignore_errors=True)


def build(basedir=None):
    '''
    '''
    bindir = _BIN_DIR
    if basedir:
        bindir = realpath(joinpath(basedir, bindir))

    cmdlines = '\n'.join((
        '"' + _msvc_env() + '"',
        'MSBuild.exe /p:Configuration=Release;OutputPath="%s"' % bindir,
        'exit',
        '',))

    p = Popen(['cmd', '/k'], stdin=PIPE, cwd=basedir, shell=True)
    p.communicate(cmdlines)


def make_archive(basedir=None):
    '''
    basedir 包含项目的目录。
    生成压缩包。
    '''
    bindir = _BIN_DIR
    pkgfile = _PKG_FILE
    if basedir:
        bindir = realpath(joinpath(basedir, bindir))
        pkgfile = realpath(joinpath(basedir, pkgfile))

    mkarch(pkgfile, 'zip', root_dir=bindir, base_dir=bindir, verbose=2)


def run(basedir=None):
    '''
    basedir 包含项目的目录。
    进入指定的目录并执行构建。
    '''
    print('-----------------------------')
    print('basedir = ', basedir)
    init(basedir)
    updver.run(basedir)
    build(basedir)
    make_archive(basedir)
    print('-----------------------------')

if __name__ == '__main__':
    basedir = dirname(__file__)
    run('banhuicon')
