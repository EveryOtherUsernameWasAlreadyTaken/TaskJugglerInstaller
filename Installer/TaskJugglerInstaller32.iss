#define public InstallerBitness "x86"
#define public RubyDir "C:\ruby26\bin\"

[Setup]
#include "Setup.iss"
ArchitecturesAllowed=x86

[Languages]

[Files]
Source: "Files\rubyinstaller-2.6.5-1-x86.exe"; DestDir: {tmp};
#include "CommonFiles.iss"

[Icons]

[Run]
Description: "Install Ruby 2.6.5 x32 incl. RubyGems"; Filename: {tmp}\rubyinstaller-2.6.5-1-x86.exe; Flags: postinstall;  Parameters: "/silent /tasks=modpath"
#include "Run.iss"

[Registry]
#include "Registry.iss"

[Code]
#include "Net452.iss"