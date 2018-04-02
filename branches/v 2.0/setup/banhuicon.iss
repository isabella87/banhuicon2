#define MyAppName "班汇通后台管理系统"
#define MyAppInternalName "Banhuicon"
#define MyAppVersion "4.1"
#define MyAppPublisher "上海鲁班金融信息服务有限公司"
#define MyAppInternalPublisher "Banbank"
#define MyAppURL "http://www.banbank.com/"
#define MyAppExeName "banhuicon.exe"

[Setup]
AppId = {{486C1E00-D847-41A9-875D-6AD29386D482}}
AppName = {#MyAppName}
AppVersion = {#MyAppVersion}
AppVerName = {#MyAppName}
AppPublisher = {#MyAppPublisher}
AppPublisherURL = {#MyAppURL}
AppSupportURL = {#MyAppURL}
AppUpdatesURL = {#MyAppURL}
DefaultDirName = {pf}\{#MyAppInternalPublisher}\{#MyAppName}\v{#MyAppVersion}
DefaultGroupName = {#MyAppName}
AllowNoIcons = Yes
SourceDir = ..\bin
OutputDir = ..\setup
OutputBaseFilename = Setup
Compression = Lzma
SolidCompression = Yes
ChangesEnvironment = Yes
Uninstallable = Yes
UsePreviousappDir = Yes
ShowLanguageDialog = Yes
SetupIconFile = ..\setup\app48.ico

[Languages]
Name: "en"; MessagesFile: "compiler:Default.isl"
Name: "cs"; MessagesFile: "..\setup\ChineseSimplified.isl"

[Tasks]
Name: "DesktopIcon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: Unchecked
Name: "QuickLaunchIcon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: Unchecked; OnlyBelowVersion: 0,6.1

[Files]
Source: "*banhuicon.exe"; DestDir: "{app}"; Flags: IgnoreVersion
Source: "*.dll"; DestDir: "{app}"; Flags: IgnoreVersion
;Source: "..\depends\*.exe"; DestDir: "{app}"; Flags: IgnoreVersion

[Registry]
Root: HKCU; Subkey: "Software\{#MyAppInternalPublisher}"; Flags: UninsDeleteKeyIfEmpty
Root: HKCU; Subkey: "Software\{#MyAppInternalPublisher}\{#MyAppInternalName}"; Flags: UninsDeleteKeyIfEmpty
Root: HKCU; Subkey: "Software\{#MyAppInternalPublisher}\{#MyAppInternalName}\v{#MyAppVersion}"; Flags: UninsDeleteKey

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: DesktopIcon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: QuickLaunchIcon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: NoWait PostInstall SkipIfSilent

