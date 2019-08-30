#define public InstallerBitness "x86"
#define public RubyDir "C:\ruby22\bin\"

[Setup]
#include "Setup.iss"
ArchitecturesAllowed=x86

[Languages]

[Tasks]
;Name: performericon; Description: Create desktop icon for Performer; GroupDescription: {cm:AdditionalIcons}; Flags: checked
;Name: reportericon; Description: Create desktop icon for Reporter; GroupDescription: {cm:AdditionalIcons}; Flags: checked

[Files]
Source: "Files\rubyinstaller-2.2.1.exe"; DestDir: {tmp};
#include "CommonFiles.iss"

[Icons]

[Run]
Description: "Install Ruby 2.2 x32 incl. RubyGems"; Filename: {tmp}\rubyinstaller-2.2.1.exe; Flags: postinstall;  Parameters: "/silent /tasks=modpath"
#include "Run.iss"

[Registry]
#include "Registry.iss"

[Code]
#include "Net452.iss"