using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Win32;

namespace WelliSolutions.Npp.SyntaxHighlighting
{
    public partial class SyntaxHighlightingInstaller : Form
    {
        public SyntaxHighlightingInstaller()
        {
            InitializeComponent();
        }

        private string roamingDir;
        private string notepadLanguageFileName;
        private ActionToPerform installAction;

        private void Form1_Load(object sender, EventArgs e)
        {
            txtRoamingDir.InvalidForegroundColor = Color.Red;
            txtRoamingDir.ValidForegroundColor = Color.Green;
            txtInstallDir.InvalidForegroundColor = Color.Red;
            txtInstallDir.ValidForegroundColor = Color.Green;

            using (var notepad = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Notepad++"))
            {
                if (notepad != null)
                {
                    var notepadPath = (string)notepad.GetValue("");
                    txtInstallDir.Value = notepadPath;

                    try
                    {
                        var versionInfo = FileVersionInfo.GetVersionInfo(Path.Combine(notepadPath, "Notepad++.exe"));
                        txtVersion.Text = String.Format("{0}.{1}.{2}.{3}", versionInfo.FileMajorPart, versionInfo.FileMinorPart,
                                                         versionInfo.FileBuildPart, versionInfo.FilePrivatePart); ;
                        if (versionInfo.FileMajorPart >= 6 && versionInfo.FileMinorPart >= 6)
                        {
                            txtVersion.ForeColor = Color.Green;
                        }
                        else
                        {
                            txtVersion.ForeColor = Color.Goldenrod;
                        }
                    }
                    catch (Exception)
                    {
                        txtVersion.Text = "Unknown";
                        txtVersion.ForeColor = Color.Red;
                    }
                }
                else
                {
                    txtInstallDir.Value = "Unknown";
                }
            }

            try
            {
                roamingDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                roamingDir = Path.Combine(roamingDir, "Notepad++");
                txtRoamingDir.Value = roamingDir;
            }
            catch (Exception)
            {
                txtRoamingDir.Value = "Unknown";
                return;
            }

            notepadLanguageFileName = Path.Combine(roamingDir, "userDefineLang.xml");
            if (!File.Exists(notepadLanguageFileName))
            {
                installAction = ActionToPerform.CreateNewFile;
            }
            else
            {
                try
                {
                    var config = XDocument.Load(notepadLanguageFileName);
                    installAction = LanguageNotDefinedYet(config)
                        ? ActionToPerform.CreateNewEntryInExistingFile
                        : ActionToPerform.UpdateExistingEntryInExistingFile;
                    if (LanguageNodes(config).Count() > 1)
                    {
                        installAction = ActionToPerform.TooManyDefinitions;
                    }
                }
                catch (Exception)
                {
                    installAction = ActionToPerform.InvalidConfigFile;
                }
            }


            switch (installAction)
            {
                case ActionToPerform.CreateNewEntryInExistingFile:
                    txtInstallationAction.Text = "Create new definition in existing file";
                    txtInstallationAction.ForeColor = Color.Green;
                    break;
                case ActionToPerform.CreateNewFile:
                    txtInstallationAction.Text = "Create new file containing definition";
                    txtInstallationAction.ForeColor = Color.Green;
                    break;
                case ActionToPerform.UpdateExistingEntryInExistingFile:
                    txtInstallationAction.Text = "Update existing definition in existing file";
                    txtInstallationAction.ForeColor = Color.Green;
                    break;
                case ActionToPerform.TooManyDefinitions:
                    txtInstallationAction.Text = "Too many TaskJuggler definitions in existing file";
                    txtInstallationAction.ForeColor = Color.Red;
                    btnInstall.Text = "Sorry, I don't know how to recover";
                    btnInstall.Enabled = false;
                    break;
                case ActionToPerform.Unknown:
                    txtInstallationAction.Text = "Unknown";
                    txtInstallationAction.ForeColor = Color.Red;
                    btnInstall.Text = "Sorry, I don't know what to do";
                    btnInstall.Enabled = false;
                    break;
                case ActionToPerform.InvalidConfigFile:
                    txtInstallationAction.Text = "Invalid exitsing configuration file";
                    txtInstallationAction.ForeColor = Color.Red;
                    btnInstall.Text = "Sorry, I don't know how to recover";
                    btnInstall.Enabled = false;
                    break;
            }
        }

        enum ActionToPerform
        {
            Unknown = 0,
            CreateNewFile = 1,
            CreateNewEntryInExistingFile =2,
            UpdateExistingEntryInExistingFile =3,
            TooManyDefinitions =4,
            InvalidConfigFile =5
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var configToInstall = XDocument.Load("notepad++.lang");
            switch (installAction)
            {
                case ActionToPerform.Unknown:
                    return;
                case ActionToPerform.CreateNewFile:
                    WriteFile(configToInstall, notepadLanguageFileName);
                    MessageBox.Show(this, "Notepad++ custom language file has been created.");
                    Close();
                    return;
                case ActionToPerform.CreateNewEntryInExistingFile:
                    var existingConfig = XDocument.Load(notepadLanguageFileName);
                    WriteFile(existingConfig, notepadLanguageFileName + ".taskjugglerbackup");
                    existingConfig.Root.Add(configToInstall.Root.Elements());
                    WriteFile(existingConfig, notepadLanguageFileName);
                    MessageBox.Show(this, "TaskJuggler language was added to Notepad++ custom language file.");
                    Close();
                    return;
                case ActionToPerform.UpdateExistingEntryInExistingFile:
                    var existingConfig2 = XDocument.Load(notepadLanguageFileName);
                    var languageNodes = LanguageNodes(existingConfig2);
                    WriteFile(existingConfig2, notepadLanguageFileName + ".taskjugglerbackup");
                    languageNodes.First().Remove();
                    existingConfig2.Root.Add(configToInstall.Root.Elements());
                    WriteFile(existingConfig2, notepadLanguageFileName);
                    MessageBox.Show(this, "TaskJuggler language in existing Notepad++ custom language file was updated.");
                    Close();
                    return;
            }
        }

        private void WriteFile(XDocument configuration, string filename)
        {
            var writer = new AsciiStringWriter();
            configuration.Save(writer);
            File.WriteAllText(filename, writer.ToString());
        }

        private static bool LanguageNotDefinedYet(XDocument notepadLanguageDefinitionFile)
        {
            return LanguageNodes(notepadLanguageDefinitionFile).Count() == 0;
        }

        private static IEnumerable<XElement> LanguageNodes(XDocument notepadLanguageDefinitionFile)
        {
            return notepadLanguageDefinitionFile.Root.Descendants()
                .Where(x => x.Name == "UserLang" && x.Attribute("name") != null && x.Attribute("name").Value == "TaskJuggler");
        }

        private void OnShown(object sender, EventArgs e)
        {
            btnInstall.Focus();
        }
    }

    class AsciiStringWriter : StringWriter
    {
        public override Encoding Encoding { get { return Encoding.ASCII; } }
    }
}
