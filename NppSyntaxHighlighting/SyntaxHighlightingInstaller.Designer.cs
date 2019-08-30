namespace WelliSolutions.Npp.SyntaxHighlighting
{
    partial class SyntaxHighlightingInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SyntaxHighlightingInstaller));
            this.lblInstallDir = new System.Windows.Forms.Label();
            this.txtInstallDir = new WelliSolutions.Controls.FileFolderSelector();
            this.btnInstall = new System.Windows.Forms.Button();
            this.lblRoaming = new System.Windows.Forms.Label();
            this.txtRoamingDir = new WelliSolutions.Controls.FileFolderSelector();
            this.lblVersion = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.lblInstallationAction = new System.Windows.Forms.Label();
            this.txtInstallationAction = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblInstallDir
            // 
            this.lblInstallDir.AutoSize = true;
            this.lblInstallDir.Location = new System.Drawing.Point(12, 9);
            this.lblInstallDir.Name = "lblInstallDir";
            this.lblInstallDir.Size = new System.Drawing.Size(305, 13);
            this.lblInstallDir.TabIndex = 0;
            this.lblInstallDir.Text = "Notepad++ installation directory (should be C:\\Program Files\\...)";
            // 
            // txtInstallDir
            // 
            this.txtInstallDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInstallDir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtInstallDir.BackColor = System.Drawing.SystemColors.Control;
            this.txtInstallDir.BrowseInitialDirectory = "%ProgramFiles(x86)%";
            this.txtInstallDir.BrowseTitle = "Select Notepad++ installation directory";
            this.txtInstallDir.Location = new System.Drawing.Point(15, 25);
            this.txtInstallDir.Name = "txtInstallDir";
            this.txtInstallDir.SelectorMode = WelliSolutions.Controls.SelectorMode.FolderSelection;
            this.txtInstallDir.Size = new System.Drawing.Size(470, 20);
            this.txtInstallDir.TabIndex = 1;
            this.txtInstallDir.Value = "Unknown";
            // 
            // btnInstall
            // 
            this.btnInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInstall.Location = new System.Drawing.Point(285, 175);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(200, 23);
            this.btnInstall.TabIndex = 8;
            this.btnInstall.Text = "&Install TaskJuggler syntax highlighting";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRoaming
            // 
            this.lblRoaming.AutoSize = true;
            this.lblRoaming.Location = new System.Drawing.Point(12, 88);
            this.lblRoaming.Name = "lblRoaming";
            this.lblRoaming.Size = new System.Drawing.Size(381, 13);
            this.lblRoaming.TabIndex = 4;
            this.lblRoaming.Text = "User specific Notepad++ settings directory (should be ...\\AppData\\Roaming\\...)";
            // 
            // txtRoamingDir
            // 
            this.txtRoamingDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRoamingDir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtRoamingDir.BrowseInitialDirectory = "%AppData%";
            this.txtRoamingDir.BrowseTitle = "Select Notepad++ settings directory";
            this.txtRoamingDir.Location = new System.Drawing.Point(15, 104);
            this.txtRoamingDir.Name = "txtRoamingDir";
            this.txtRoamingDir.SelectorMode = WelliSolutions.Controls.SelectorMode.FolderSelection;
            this.txtRoamingDir.Size = new System.Drawing.Size(470, 20);
            this.txtRoamingDir.TabIndex = 5;
            this.txtRoamingDir.Value = "Unknown";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(12, 48);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(97, 13);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Notepad++ version";
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(15, 65);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(115, 20);
            this.txtVersion.TabIndex = 3;
            this.txtVersion.Text = "Unknown";
            // 
            // lblInstallationAction
            // 
            this.lblInstallationAction.AutoSize = true;
            this.lblInstallationAction.Location = new System.Drawing.Point(12, 127);
            this.lblInstallationAction.Name = "lblInstallationAction";
            this.lblInstallationAction.Size = new System.Drawing.Size(134, 13);
            this.lblInstallationAction.TabIndex = 6;
            this.lblInstallationAction.Text = "Required installation action";
            // 
            // txtInstallationAction
            // 
            this.txtInstallationAction.Location = new System.Drawing.Point(15, 143);
            this.txtInstallationAction.Name = "txtInstallationAction";
            this.txtInstallationAction.Size = new System.Drawing.Size(431, 20);
            this.txtInstallationAction.TabIndex = 7;
            this.txtInstallationAction.Text = "Unknown";
            // 
            // SyntaxHighlightingInstaller
            // 
            this.AcceptButton = this.btnInstall;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 210);
            this.Controls.Add(this.txtInstallationAction);
            this.Controls.Add(this.lblInstallationAction);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.txtRoamingDir);
            this.Controls.Add(this.lblRoaming);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.txtInstallDir);
            this.Controls.Add(this.lblInstallDir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(513, 248);
            this.Name = "SyntaxHighlightingInstaller";
            this.Text = "TaskJuggler Notepad++ Syntax Highlighting Installer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.OnShown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstallDir;
        private WelliSolutions.Controls.FileFolderSelector txtInstallDir;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Label lblRoaming;
        private Controls.FileFolderSelector txtRoamingDir;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Label lblInstallationAction;
        private System.Windows.Forms.TextBox txtInstallationAction;
    }
}

