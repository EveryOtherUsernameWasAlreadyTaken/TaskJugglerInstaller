#define public InstallerBitness "x86"
#define public RubyDir "C:\Ruby34\bin\"
#define public RubyInstaller "rubyinstaller-3.4.7-1-x86.exe"

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