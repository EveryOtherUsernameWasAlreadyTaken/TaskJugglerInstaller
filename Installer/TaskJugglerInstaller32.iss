#define public InstallerBitness "x86"
#define public RubyDir "C:\ruby27\bin\"
#define public RubyInstaller "rubyinstaller-2.7.8-1-x86.exe"

[Setup]
#include "Setup.iss"
ArchitecturesAllowed=x86

[Languages]

[Files]
Source: "Files\{#RubyInstaller}"; DestDir: {tmp};
#include "CommonFiles.iss"

[Icons]

[Run]
#include "Run.iss"

[Registry]
#include "Registry.iss"

[Code]
#include "Net452.iss"