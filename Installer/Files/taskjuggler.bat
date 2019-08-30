@echo off
echo WelliSolutions TaskJuggler Processing script
echo Expecting Ruby in %1
echo Processing file %2
echo Command line: "%~1ruby.exe" "%~1tj3" %2
echo.
"%~1ruby.exe" "%~1tj3" %2
if errorlevel 1 pause