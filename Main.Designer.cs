namespace Abdal_Security_Group_App
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            visualStudio2022DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2022DarkTheme();
            radMenu1 = new Telerik.WinControls.UI.RadMenu();
            menuItem_about_us = new Telerik.WinControls.UI.RadMenuItem();
            menuItem_donate = new Telerik.WinControls.UI.RadMenuItem();
            irDonationBtn = new Telerik.WinControls.UI.RadMenuItem();
            EnDonationBtn = new Telerik.WinControls.UI.RadMenuItem();
            radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            menuItem_github = new Telerik.WinControls.UI.RadMenuItem();
            menuItem_gitlab = new Telerik.WinControls.UI.RadMenuItem();
            desk_alert = new Telerik.WinControls.UI.RadDesktopAlert(components);
            bg_worker = new System.ComponentModel.BackgroundWorker();
            btn_start = new Telerik.WinControls.UI.RadButton();
            btn_exit = new PictureBox();
            btn_minimize = new PictureBox();
            openFilePDF = new OpenFileDialog();
            openFileScript = new OpenFileDialog();
            radButton1 = new Telerik.WinControls.UI.RadButton();
            radButton2 = new Telerik.WinControls.UI.RadButton();
            radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            waitingBarPDF = new Telerik.WinControls.UI.RadWaitingBar();
            waitingBarIndicatorElement1 = new Telerik.WinControls.UI.WaitingBarIndicatorElement();
            waitingBarIndicatorElement2 = new Telerik.WinControls.UI.WaitingBarIndicatorElement();
            lbPDFFileSize = new Telerik.WinControls.UI.RadLabel();
            radLabel2 = new Telerik.WinControls.UI.RadLabel();
            lbPDFFileName = new Telerik.WinControls.UI.RadLabel();
            radLabel1 = new Telerik.WinControls.UI.RadLabel();
            windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            lbJSFileSize = new Telerik.WinControls.UI.RadLabel();
            waitingBarJS = new Telerik.WinControls.UI.RadWaitingBar();
            waitingBarIndicatorElement3 = new Telerik.WinControls.UI.WaitingBarIndicatorElement();
            waitingBarIndicatorElement4 = new Telerik.WinControls.UI.WaitingBarIndicatorElement();
            radLabel4 = new Telerik.WinControls.UI.RadLabel();
            radLabel6 = new Telerik.WinControls.UI.RadLabel();
            lbJSFileName = new Telerik.WinControls.UI.RadLabel();
            btnAttachFile = new Telerik.WinControls.UI.RadButton();
            openAttachFile = new OpenFileDialog();
            btnReset = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)radMenu1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_start).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radButton1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radButton2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radGroupBox1).BeginInit();
            radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)waitingBarPDF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lbPDFFileSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lbPDFFileName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radGroupBox2).BeginInit();
            radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lbJSFileSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)waitingBarJS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lbJSFileName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAttachFile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnReset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radMenu1
            // 
            radMenu1.Dock = DockStyle.Bottom;
            radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] { menuItem_about_us, menuItem_donate, radMenuItem3 });
            radMenu1.Location = new Point(0, 519);
            radMenu1.Name = "radMenu1";
            radMenu1.Size = new Size(616, 28);
            radMenu1.TabIndex = 0;
            radMenu1.ThemeName = "VisualStudio2022Dark";
            // 
            // menuItem_about_us
            // 
            menuItem_about_us.Image = Properties.Resources.user_16x16;
            menuItem_about_us.Name = "menuItem_about_us";
            menuItem_about_us.Text = "About Us";
            menuItem_about_us.Click += menuItem_about_us_Click;
            // 
            // menuItem_donate
            // 
            menuItem_donate.Image = Properties.Resources.dollar16x16;
            menuItem_donate.Items.AddRange(new Telerik.WinControls.RadItem[] { irDonationBtn, EnDonationBtn });
            menuItem_donate.Name = "menuItem_donate";
            menuItem_donate.Text = "Donate";
            // 
            // irDonationBtn
            // 
            irDonationBtn.Image = Properties.Resources.iran_16x16;
            irDonationBtn.Name = "irDonationBtn";
            irDonationBtn.Text = "Persian speaker";
            irDonationBtn.Click += irDonationBtn_Click;
            // 
            // EnDonationBtn
            // 
            EnDonationBtn.Image = Properties.Resources.United_Kingdom16x16;
            EnDonationBtn.Name = "EnDonationBtn";
            EnDonationBtn.Text = "English speaker";
            EnDonationBtn.Click += EnDonationBtn_Click;
            // 
            // radMenuItem3
            // 
            radMenuItem3.Image = Properties.Resources.git_pull_request16x16;
            radMenuItem3.Items.AddRange(new Telerik.WinControls.RadItem[] { menuItem_github, menuItem_gitlab });
            radMenuItem3.Name = "radMenuItem3";
            radMenuItem3.Text = "Source Code";
            // 
            // menuItem_github
            // 
            menuItem_github.Image = Properties.Resources.github;
            menuItem_github.Name = "menuItem_github";
            menuItem_github.Text = "Github";
            menuItem_github.Click += menuItem_github_Click;
            // 
            // menuItem_gitlab
            // 
            menuItem_gitlab.Image = Properties.Resources.gitlab_icon_rgb;
            menuItem_gitlab.Name = "menuItem_gitlab";
            menuItem_gitlab.Text = "Gitlab";
            menuItem_gitlab.Click += menuItem_gitlab_Click;
            // 
            // bg_worker
            // 
            bg_worker.DoWork += bg_worker_DoWork_1;
            bg_worker.RunWorkerCompleted += bg_worker_RunWorkerCompleted;
            // 
            // btn_start
            // 
            btn_start.Location = new Point(494, 478);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(110, 24);
            btn_start.TabIndex = 1;
            btn_start.Text = "Start Injection";
            btn_start.ThemeName = "VisualStudio2022Dark";
            btn_start.Click += btn_start_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.Transparent;
            btn_exit.BackgroundImage = Properties.Resources.x_circle_21x21;
            btn_exit.BackgroundImageLayout = ImageLayout.Stretch;
            btn_exit.Cursor = Cursors.Hand;
            btn_exit.Location = new Point(7, 10);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(21, 21);
            btn_exit.TabIndex = 2;
            btn_exit.TabStop = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_minimize
            // 
            btn_minimize.BackColor = Color.Transparent;
            btn_minimize.BackgroundImage = Properties.Resources.minus_circle_21x21;
            btn_minimize.BackgroundImageLayout = ImageLayout.Stretch;
            btn_minimize.Cursor = Cursors.Hand;
            btn_minimize.Location = new Point(34, 10);
            btn_minimize.Name = "btn_minimize";
            btn_minimize.Size = new Size(21, 21);
            btn_minimize.TabIndex = 3;
            btn_minimize.TabStop = false;
            btn_minimize.Click += btn_minimize_Click;
            // 
            // openFilePDF
            // 
            openFilePDF.FileName = "openFilePDF";
            openFilePDF.FileOk += openFilePDF_FileOk;
            // 
            // openFileScript
            // 
            openFileScript.FileName = "openFileDialog1";
            // 
            // radButton1
            // 
            radButton1.Location = new Point(12, 478);
            radButton1.Name = "radButton1";
            radButton1.Size = new Size(72, 24);
            radButton1.TabIndex = 4;
            radButton1.Text = "Open PDF";
            radButton1.ThemeName = "VisualStudio2022Dark";
            radButton1.Click += radButton1_Click;
            // 
            // radButton2
            // 
            radButton2.Location = new Point(90, 478);
            radButton2.Name = "radButton2";
            radButton2.Size = new Size(83, 24);
            radButton2.TabIndex = 5;
            radButton2.Text = "Open Script";
            radButton2.ThemeName = "VisualStudio2022Dark";
            radButton2.Click += radButton2_Click;
            // 
            // radGroupBox1
            // 
            radGroupBox1.AccessibleRole = AccessibleRole.Grouping;
            radGroupBox1.Controls.Add(waitingBarPDF);
            radGroupBox1.Controls.Add(lbPDFFileSize);
            radGroupBox1.Controls.Add(radLabel2);
            radGroupBox1.Controls.Add(lbPDFFileName);
            radGroupBox1.Controls.Add(radLabel1);
            radGroupBox1.HeaderText = "PDF File";
            radGroupBox1.Location = new Point(12, 364);
            radGroupBox1.Name = "radGroupBox1";
            radGroupBox1.Size = new Size(287, 100);
            radGroupBox1.TabIndex = 6;
            radGroupBox1.Text = "PDF File";
            radGroupBox1.ThemeName = "Windows8";
            // 
            // waitingBarPDF
            // 
            waitingBarPDF.Dock = DockStyle.Bottom;
            waitingBarPDF.Enabled = false;
            waitingBarPDF.Location = new Point(2, 78);
            waitingBarPDF.Name = "waitingBarPDF";
            waitingBarPDF.Size = new Size(283, 20);
            waitingBarPDF.TabIndex = 4;
            waitingBarPDF.Text = "radWaitingBar1";
            waitingBarPDF.ThemeName = "VisualStudio2022Dark";
            // 
            // 
            // 
            waitingBarPDF.WaitingBarElement.WaitingIndicatorSize = new Size(100, 14);
            waitingBarPDF.WaitingIndicators.Add(waitingBarIndicatorElement1);
            waitingBarPDF.WaitingIndicators.Add(waitingBarIndicatorElement2);
            waitingBarPDF.WaitingIndicatorSize = new Size(100, 14);
            waitingBarPDF.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.Dash;
            ((Telerik.WinControls.UI.RadWaitingBarElement)waitingBarPDF.GetChildAt(0)).WaitingIndicatorSize = new Size(100, 14);
            // 
            // waitingBarIndicatorElement1
            // 
            waitingBarIndicatorElement1.Name = "waitingBarIndicatorElement1";
            waitingBarIndicatorElement1.StretchHorizontally = false;
            // 
            // waitingBarIndicatorElement2
            // 
            waitingBarIndicatorElement2.Name = "waitingBarIndicatorElement2";
            waitingBarIndicatorElement2.StretchHorizontally = false;
            // 
            // lbPDFFileSize
            // 
            lbPDFFileSize.Location = new Point(66, 48);
            lbPDFFileSize.Name = "lbPDFFileSize";
            lbPDFFileSize.Size = new Size(14, 21);
            lbPDFFileSize.TabIndex = 3;
            lbPDFFileSize.Text = "0";
            lbPDFFileSize.ThemeName = "VisualStudio2022Dark";
            // 
            // radLabel2
            // 
            radLabel2.Location = new Point(6, 48);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(54, 21);
            radLabel2.TabIndex = 2;
            radLabel2.Text = "FileSize:";
            radLabel2.ThemeName = "VisualStudio2022Dark";
            // 
            // lbPDFFileName
            // 
            lbPDFFileName.Location = new Point(78, 21);
            lbPDFFileName.Name = "lbPDFFileName";
            lbPDFFileName.Size = new Size(40, 21);
            lbPDFFileName.TabIndex = 1;
            lbPDFFileName.Text = "------";
            lbPDFFileName.ThemeName = "VisualStudio2022Dark";
            // 
            // radLabel1
            // 
            radLabel1.Location = new Point(5, 21);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(67, 21);
            radLabel1.TabIndex = 0;
            radLabel1.Text = "FileName:";
            radLabel1.ThemeName = "VisualStudio2022Dark";
            // 
            // radGroupBox2
            // 
            radGroupBox2.AccessibleRole = AccessibleRole.Grouping;
            radGroupBox2.Controls.Add(lbJSFileSize);
            radGroupBox2.Controls.Add(waitingBarJS);
            radGroupBox2.Controls.Add(radLabel4);
            radGroupBox2.Controls.Add(radLabel6);
            radGroupBox2.Controls.Add(lbJSFileName);
            radGroupBox2.HeaderText = "JS File";
            radGroupBox2.Location = new Point(317, 364);
            radGroupBox2.Name = "radGroupBox2";
            radGroupBox2.Size = new Size(287, 100);
            radGroupBox2.TabIndex = 7;
            radGroupBox2.Text = "JS File";
            radGroupBox2.ThemeName = "Windows8";
            // 
            // lbJSFileSize
            // 
            lbJSFileSize.Location = new Point(66, 48);
            lbJSFileSize.Name = "lbJSFileSize";
            lbJSFileSize.Size = new Size(14, 21);
            lbJSFileSize.TabIndex = 7;
            lbJSFileSize.Text = "0";
            lbJSFileSize.ThemeName = "VisualStudio2022Dark";
            // 
            // waitingBarJS
            // 
            waitingBarJS.Dock = DockStyle.Bottom;
            waitingBarJS.Location = new Point(2, 78);
            waitingBarJS.Name = "waitingBarJS";
            waitingBarJS.Size = new Size(283, 20);
            waitingBarJS.TabIndex = 0;
            waitingBarJS.Text = "radWaitingBar2";
            waitingBarJS.ThemeName = "VisualStudio2022Dark";
            // 
            // 
            // 
            waitingBarJS.WaitingBarElement.WaitingIndicatorSize = new Size(100, 14);
            waitingBarJS.WaitingIndicators.Add(waitingBarIndicatorElement3);
            waitingBarJS.WaitingIndicators.Add(waitingBarIndicatorElement4);
            waitingBarJS.WaitingIndicatorSize = new Size(100, 14);
            waitingBarJS.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.Dash;
            ((Telerik.WinControls.UI.RadWaitingBarElement)waitingBarJS.GetChildAt(0)).WaitingIndicatorSize = new Size(100, 14);
            // 
            // waitingBarIndicatorElement3
            // 
            waitingBarIndicatorElement3.Name = "waitingBarIndicatorElement3";
            waitingBarIndicatorElement3.StretchHorizontally = false;
            // 
            // waitingBarIndicatorElement4
            // 
            waitingBarIndicatorElement4.Name = "waitingBarIndicatorElement4";
            waitingBarIndicatorElement4.StretchHorizontally = false;
            // 
            // radLabel4
            // 
            radLabel4.Location = new Point(6, 48);
            radLabel4.Name = "radLabel4";
            radLabel4.Size = new Size(54, 21);
            radLabel4.TabIndex = 6;
            radLabel4.Text = "FileSize:";
            radLabel4.ThemeName = "VisualStudio2022Dark";
            // 
            // radLabel6
            // 
            radLabel6.Location = new Point(5, 21);
            radLabel6.Name = "radLabel6";
            radLabel6.Size = new Size(67, 21);
            radLabel6.TabIndex = 4;
            radLabel6.Text = "FileName:";
            radLabel6.ThemeName = "VisualStudio2022Dark";
            // 
            // lbJSFileName
            // 
            lbJSFileName.Location = new Point(78, 21);
            lbJSFileName.Name = "lbJSFileName";
            lbJSFileName.Size = new Size(40, 21);
            lbJSFileName.TabIndex = 5;
            lbJSFileName.Text = "------";
            lbJSFileName.ThemeName = "VisualStudio2022Dark";
            // 
            // btnAttachFile
            // 
            btnAttachFile.Location = new Point(179, 478);
            btnAttachFile.Name = "btnAttachFile";
            btnAttachFile.Size = new Size(73, 24);
            btnAttachFile.TabIndex = 8;
            btnAttachFile.Text = "Attach File";
            btnAttachFile.ThemeName = "VisualStudio2022Dark";
            btnAttachFile.Click += btnAttachFile_Click;
            // 
            // openAttachFile
            // 
            openAttachFile.FileName = "openFileDialog1";
            // 
            // btnReset
            // 
            btnReset.Image = Properties.Resources.reset_50;
            btnReset.ImageAlignment = ContentAlignment.MiddleCenter;
            btnReset.Location = new Point(258, 478);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(23, 24);
            btnReset.TabIndex = 9;
            btnReset.ThemeName = "VisualStudio2022Dark";
            btnReset.Click += btnReset_Click;
            // 
            // Main
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_copy1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(616, 547);
            Controls.Add(btnReset);
            Controls.Add(btnAttachFile);
            Controls.Add(radGroupBox2);
            Controls.Add(radGroupBox1);
            Controls.Add(radButton2);
            Controls.Add(radButton1);
            Controls.Add(btn_minimize);
            Controls.Add(btn_exit);
            Controls.Add(btn_start);
            Controls.Add(radMenu1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ThemeName = "VisualStudio2022Dark";
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)radMenu1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_start).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)radButton1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radButton2).EndInit();
            ((System.ComponentModel.ISupportInitialize)radGroupBox1).EndInit();
            radGroupBox1.ResumeLayout(false);
            radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)waitingBarPDF).EndInit();
            ((System.ComponentModel.ISupportInitialize)lbPDFFileSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)lbPDFFileName).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radGroupBox2).EndInit();
            radGroupBox2.ResumeLayout(false);
            radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lbJSFileSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)waitingBarJS).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel4).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel6).EndInit();
            ((System.ComponentModel.ISupportInitialize)lbJSFileName).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAttachFile).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnReset).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2022DarkTheme visualStudio2022DarkTheme1;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem menuItem_about_us;
        private Telerik.WinControls.UI.RadMenuItem menuItem_donate;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem menuItem_github;
        private Telerik.WinControls.UI.RadMenuItem menuItem_gitlab;
        private Telerik.WinControls.UI.RadDesktopAlert desk_alert;
        private System.ComponentModel.BackgroundWorker bg_worker;
        private Telerik.WinControls.UI.RadButton btn_start;
        private PictureBox btn_exit;
        private PictureBox btn_minimize;
        private Telerik.WinControls.UI.RadMenuItem irDonationBtn;
        private Telerik.WinControls.UI.RadMenuItem EnDonationBtn;
        private OpenFileDialog openFilePDF;
        private OpenFileDialog openFileScript;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadLabel lbPDFFileSize;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel lbPDFFileName;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadWaitingBar waitingBarPDF;
        private Telerik.WinControls.UI.WaitingBarIndicatorElement waitingBarIndicatorElement1;
        private Telerik.WinControls.UI.WaitingBarIndicatorElement waitingBarIndicatorElement2;
        private Telerik.WinControls.UI.RadLabel lbJSFileSize;
        private Telerik.WinControls.UI.RadWaitingBar waitingBarJS;
        private Telerik.WinControls.UI.WaitingBarIndicatorElement waitingBarIndicatorElement3;
        private Telerik.WinControls.UI.WaitingBarIndicatorElement waitingBarIndicatorElement4;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel lbJSFileName;
        private Telerik.WinControls.UI.RadButton btnAttachFile;
        private OpenFileDialog openAttachFile;
        private Telerik.WinControls.UI.RadButton btnReset;
    }
}
