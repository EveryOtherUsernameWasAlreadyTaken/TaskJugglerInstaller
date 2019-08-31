#define public InstallerBitness "x64"
#define public RubyDir "C:\ruby22-x64\bin\"

[Setup]
#include "Setup.iss"
ArchitecturesAllowed=x64

[Languages]

[Files]
Source: "Files\rubyinstaller-2.2.1-x64.exe"; DestDir: {tmp};
#include "CommonFiles.iss"

[Icons]

[Run]
Description: "Install Ruby 2.2 x64 incl. RubyGems"; Filename: {tmp}\rubyinstaller-2.2.1-x64.exe; Flags: postinstall; Parameters: "/silent /tasks=modpath"
#include "Run.iss"

[Registry]
#include "Registry.iss"

[Code]
#include "Net452.iss"