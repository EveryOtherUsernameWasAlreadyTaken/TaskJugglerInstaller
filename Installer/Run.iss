[Run]
Description: "Install Notepad++ syntax highlighting"; Filename: {tmp}\WelliSolutions.Npp.SyntaxHighlighting.exe; Flags:  postinstall; Check: IsDotNetInstalled

[Code]
procedure CurStepChanged(CurStep: TSetupStep);
var
  ResultCode: Integer;
  Index: Integer;
  Gems: array[0..9] of String;
  Gem: string;
begin
  if CurStep = ssPostInstall then
  begin
    { Install Ruby }
    ShellExec('', ExpandConstant('{tmp}{\}{#RubyInstaller}'), '/silent /tasks=modpath', '', SW_HIDE, ewWaitUntilTerminated, ResultCode);
  end;
  if CurStep = ssDone then
  begin
    { Install Gems }
    { dependency level 3 }
     Gems[0]:='timeout-0.3.2.gem';
     Gems[1]:='net-protocol-0.2.1.gem';
     { dependency level 2 }
     Gems[2]:='mini_mime-1.1.2.gem';
     Gems[3]:='net-imap-0.3.4.gem'
     Gems[4]:='net-pop-0.1.2.gem';
     Gems[5]:='net-smtp-0.3.3.gem';
     Gems[6]:='tins-1.3.5.gem';
     { dependency level 1 }
     Gems[7]:='mail-2.8.1.gem';
     Gems[8]:='term-ansicolor-1.7.1.gem';
     { dependency level 0 }
     Gems[9]:='taskjuggler-3.7.2.gem';
    for Index := 0 to GetArrayLength(Gems) - 1 do
    begin
      Gem := Gems[Index];
      ShellExec('', ExpandConstant('{#RubyDir}{\}ruby.exe'), ExpandConstant('{#RubyDir}{\}gem install --local {tmp}\' + Gem), '', SW_HIDE, ewWaitUntilTerminated, ResultCode);
    end;
  end;
end;