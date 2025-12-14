[Run]
Description: "Install Notepad++ syntax highlighting"; Filename: {tmp}\WelliSolutions.Npp.SyntaxHighlighting.exe; Flags:  postinstall; Check: IsDotNetInstalled

[Code]
procedure CurStepChanged(CurStep: TSetupStep);
var
  ResultCode: Integer;
  Index: Integer;
  Gems: array[0..14] of String;
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
     Gems[0]:='timeout-0.5.0.gem';
     Gems[1]:='net-protocol-0.2.2.gem';
     Gems[2]:='bigdecimal-3.3.1.gem';
     Gems[3]:='mize-0.6.1.gem';
     Gems[4]:='sync-0.5.0.gem';
     { dependency level 2 }
     Gems[5]:='mini_mime-1.1.5.gem';
     Gems[6]:='net-imap-0.5.12.gem'
     Gems[7]:='net-pop-0.1.2.gem';
     Gems[8]:='net-smtp-0.5.1.gem';
     Gems[9]:='tins-1.48.0.gem';
     Gems[10]:='logger-1.7.0.gem';
     { dependency level 1 }
     Gems[11]:='mail-2.9.0.gem';
     Gems[12]:='term-ansicolor-1.11.3.gem';
     Gems[13]:='webrick-1.9.2.gem';
     { dependency level 0 }
     Gems[14]:='taskjuggler-3.8.4.gem';
    for Index := 0 to GetArrayLength(Gems) - 1 do
    begin
      Gem := Gems[Index];
      ShellExec('', ExpandConstant('{#RubyDir}{\}ruby.exe'), ExpandConstant('{#RubyDir}{\}gem install --local {tmp}\' + Gem), '', SW_HIDE, ewWaitUntilTerminated, ResultCode);
    end;
  end;
end;