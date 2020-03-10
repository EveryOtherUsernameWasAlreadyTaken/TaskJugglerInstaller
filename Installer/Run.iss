[Run]
Description: "Install Notepad++ syntax highlighting"; Filename: {tmp}\WelliSolutions.Npp.SyntaxHighlighting.exe; Flags:  postinstall; Check: IsDotNetInstalled

[Code]
procedure CurStepChanged(CurStep: TSetupStep);
var
  ResultCode: Integer;
begin
  if CurStep = ssPostInstall then
  begin
    { Install Ruby }
    ShellExec('', ExpandConstant('{tmp}{\}{#RubyInstaller}'), '/silent /tasks=modpath', '', SW_HIDE, ewWaitUntilTerminated, ResultCode);
  end;
  if CurStep = ssDone then
  begin
    { Install Gems }
    ShellExec('', ExpandConstant('{#RubyDir}{\}ruby.exe'), ExpandConstant('{#RubyDir}{\}gem install --local {tmp}\tins-1.3.5.gem'), '', SW_HIDE, ewWaitUntilTerminated, ResultCode);
    ShellExec('', ExpandConstant('{#RubyDir}{\}ruby.exe'), ExpandConstant('{#RubyDir}{\}gem install --local {tmp}\term-ansicolor-1.3.0.gem'), '', SW_HIDE, ewWaitUntilTerminated, ResultCode);
    ShellExec('', ExpandConstant('{#RubyDir}{\}ruby.exe'), ExpandConstant('{#RubyDir}{\}gem install --local {tmp}\mime-types-2.4.3.gem'), '', SW_HIDE, ewWaitUntilTerminated, ResultCode);
    ShellExec('', ExpandConstant('{#RubyDir}{\}ruby.exe'), ExpandConstant('{#RubyDir}{\}gem install --local {tmp}\mail-2.6.3.gem'), '', SW_HIDE, ewWaitUntilTerminated, ResultCode);
    ShellExec('', ExpandConstant('{#RubyDir}{\}ruby.exe'), ExpandConstant('{#RubyDir}{\}gem install --local {tmp}\taskjuggler-3.6.0.gem'), '', SW_HIDE, ewWaitUntilTerminated, ResultCode);
  end;
end;