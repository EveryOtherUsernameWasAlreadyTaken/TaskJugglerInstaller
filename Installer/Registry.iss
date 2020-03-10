[Registry]
; File extension, Icon
Root: HKCR; Subkey: ".tjp"; ValueType: string; ValueName: ""; ValueData: "TaskJugglerProject"; Flags: uninsdeletevalue createvalueifdoesntexist
Root: HKCR; Subkey: "TaskJugglerProject"; ValueType: string; ValueName: ""; ValueData: "TaskJuggler Project"; Flags: uninsdeletekey createvalueifdoesntexist
Root: HKCR; Subkey: "TaskJugglerProject\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}{\}tj3.ico"; Flags: uninsdeletekey createvalueifdoesntexist;

; Default application: open with Notepad
Root: HKCR; Subkey: "TaskJugglerProject\shell\open\command"; ValueType: expandsz; ValueName: ""; ValueData: """%SystemRoot%\system32\NOTEPAD.EXE"" ""%1"""; Flags: uninsdeletekey createvalueifdoesntexist;

; Context menu "Process with TaskJuggler"
Root: HKCR; Subkey: "TaskJugglerProject\shell\process"; ValueType: string; ValueName: ""; ValueData: "Process with TaskJuggler"; Flags: uninsdeletekey createvalueifdoesntexist;
Root: HKCR; Subkey: "TaskJugglerProject\shell\process\command"; ValueType: string; ValueName: ""; ValueData: """{app}{\}taskjuggler.bat"" ""{#RubyDir}{\}"" ""%1"""; Flags: uninsdeletekey;

; Windows Explorer Preview Pane
Root: HKCR; Subkey: ".tjp"; ValueType: string; ValueName: "PerceivedType"; ValueData: "text"; Flags: uninsdeletevalue createvalueifdoesntexist

; Template for Explorer's New context menu
Root: HKCR; Subkey: ".tjp\ShellNew"; ValueType: string; ValueName: "FileName"; ValueData: "{commontemplates}{\}Template.tjp"; Flags: uninsdeletevalue createvalueifdoesntexist
