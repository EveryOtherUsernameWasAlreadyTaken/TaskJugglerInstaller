## How to upgrade for a new Taskjuggler version

1. Run `gem update taskjuggler`. This will upgrade TaskJuggler on your PC.
   1. Find the latest version of `taskjuggler-x.x.x.gem` on your disk. It should be in a `gems\x.x.x\cache` directory. Add it into the ` Installer/Files` directory and delete the old version.
   2. Look at the output of the `gem update` command. It will also list the dependencies. Copy them into the `Installer/Files` directory and delete the old ones.
2. Figure out the dependencies with `gem dependency taskjuggler`. In `Run.iss`, add the top item last and let the dependencies install first. Do this process recursively until you added all dependencies. Exclude development dependencies.
3. In the installer script `TaskJuggerInstallerxx.iss` change the name of the Ruby installer. Change the directory (`RubyDir`) accordingly, if needed.
4. In the installer script `Setup.iss`, set the correct TaskJuggler version. Update the years.
5. Open the build script (Visual Build). 
   1. In the macros, edit the TaskJuggler version (`TJVER`).
   2. Increase the Build version (`BUILD`) by one

## How to upgrade for a new Ruby version

1. Get the latest Ruby installers (both x86 and x64) from the website [RubyInstaller website](https://rubyinstaller.org/downloads/) (without Devkit). Add the new installers to Git, delete the old ones.
2. Install them on your machine, in order to find the installation directories.
3. Edit `TaskJugglerInstaller32.iss` for the 32 bit version to reflect the new installer executable and installation directory
4. Edit `TaskJugglerInstaller64.iss` for the 64 bit version to reflect the new installer executable and installation directory
5. Run `gem update`
6. Run `gem install mail mini_mime net-imap net-pop net-protocol net-smtp term-ansicolor timeout tins webrick`.
7. Run `gem install taskjuggler`. If that installs an additional dependency, add it to the list in step 6 and add it to the Setup files.
8. Follow the steps from 