#define AppVersion "3.5.0"
#define InstallerVersion "0.7"
#define Title "TaskJuggler"
#define ShortTitle "TaskJuggler"
[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{C26D7CDC-E4A2-471C-ABC7-D4DAE5725D44}
AppName={#ShortTitle}
AppVerName={#ShortTitle} {#AppVersion}
AppPublisher=WelliSolutions
AppPublisherURL=http://www.wellisolutions.de
AppSupportURL=http://www.wellisolutions.de
AppUpdatesURL=http://www.wellisolutions.de
DefaultDirName={pf}\WelliSolutions\{#ShortTitle}
DefaultGroupName={#ShortTitle}
AllowNoIcons=true
OutputDir=Compiled
OutputBaseFilename={#ShortTitle} {#AppVersion} Installer {#InstallerVersion} {#InstallerBitness}
Compression=lzma
SolidCompression=true
; Make useful description of Setup.exe itself
VersionInfoCompany=WelliSolutions
VersionInfoCopyright=2015 by WelliSolutions
VersionInfoDescription={#Title} {#AppVersion}
VersionInfoProductName={#Title}
VersionInfoProductVersion={#AppVersion}
VersionInfoTextVersion={#AppVersion}
VersionInfoVersion={#AppVersion}
AppCopyright=Copyright © 2015 WelliSolutions
SetupIconFile=tj3.ico
WizardImageFile=Logo.bmp
WizardSmallImageFile=WelliSolutions_Logo.bmp
AppVersion={#AppVersion}
AppContact=Thomas Weller
ChangesAssociations=Yes
DisableDirPage=yes