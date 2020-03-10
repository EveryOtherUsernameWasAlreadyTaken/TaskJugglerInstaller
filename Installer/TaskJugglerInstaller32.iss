#define public InstallerBitness "x86"
#define public RubyDir "C:\ruby26\bin\"
#define public RubyInstaller "rubyinstaller-2.6.5-1-x86.exe"

[Setup]
#include "Setup.iss"
ArchitecturesAllowed=x86

[Languages]

[Files]
Source: "Files\rubyinstaller-2.6.5-1-x86.exe"; DestDir: {tmp};
#include "CommonFiles.iss"

[Icons]

[Run]
#include "Run.iss"

[Registry]
#include "Registry.iss"

[Code]
#include "Net452.iss"