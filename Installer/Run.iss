[Run]
Description: "Install tins"; Filename: {#RubyDir}{\}ruby.exe; Flags:  postinstall; Parameters: {#RubyDir}{\}gem install --local {tmp}\tins-1.3.5.gem
Description: "Install term-ansicolor"; Filename: {#RubyDir}{\}ruby.exe; Flags:  postinstall ; Parameters: {#RubyDir}{\}gem install --local {tmp}\term-ansicolor-1.3.0.gem
Description: "Install mime-types"; Filename: {#RubyDir}{\}ruby.exe; Flags:  postinstall ;   Parameters: {#RubyDir}{\}gem install --local {tmp}\mime-types-2.4.3.gem
Description: "Install mail"; Filename: {#RubyDir}{\}ruby.exe; Flags:  postinstall ;  Parameters: {#RubyDir}{\}gem install --local {tmp}\mail-2.6.3.gem
Description: "Install taskjuggler"; Filename: {#RubyDir}{\}ruby.exe; Flags:  postinstall;  Parameters: {#RubyDir}{\}gem install --local {tmp}\taskjuggler-3.5.0.gem

Description: "Install Notepad++ syntax highlighting"; Filename: {tmp}\WelliSolutions.Npp.SyntaxHighlighting.exe; Flags:  postinstall; Check: IsDotNetInstalled