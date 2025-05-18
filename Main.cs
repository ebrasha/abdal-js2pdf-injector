using Abdal_Security_Group_App.Core;
using Aspose.Pdf;
using Aspose.Pdf.Annotations;
using Aspose.Pdf.Operators;
using System.Diagnostics;
using System.Reflection;
using System.Text;


namespace Abdal_Security_Group_App
{
    public partial class Main : Telerik.WinControls.UI.RadForm
    {
        private bool selected_pdf_file = true;
        private bool selected_js_file = true;
        private bool pdf_selected_file = false;
        private bool script_selected_file = false;
        private bool stop_op_status = false;
        private string abdal_app_name = Assembly.GetExecutingAssembly().GetName().ToString().Split(',')[0];
        private AbdalSoundPlayer ab_player = new AbdalSoundPlayer();

        private string abdal_app_name_for_url = Assembly.GetExecutingAssembly().GetName().ToString().Split(',')[0]
            .ToLower().Replace(' ', '-');


        public Main()
        {
            InitializeComponent();
            //change form title
            Version version = Assembly.GetExecutingAssembly().GetName().Version!;
            Text = abdal_app_name + " " + version.Major + "." + version.Minor;

            // Call Global Chilkat Unlock
            ChilkatMng.UnlockChilkat();
        }

        #region Dragable Form Start

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        #endregion

        public void SetAsposeLicense()
        {
            try
            {
                // Get current executing directory
                string appPath = AppDomain.CurrentDomain.BaseDirectory;

                // Combine with license file name
                string licensePath = Path.Combine(appPath, "Abdal JS2PDF Injector.lic");

                // Set license
                new Aspose.Pdf.License().SetLicense(licensePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aspose License Error:\n{ex.Message}", "Aspose License Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            desk_alert.ThemeName = "VisualStudio2022Dark";
            waitingBarPDF.Enabled = false;
            waitingBarPDF.StopWaiting();
            waitingBarJS.Enabled = false;
            waitingBarJS.StopWaiting();
            SetAsposeLicense();
            await UpdateChecker.CheckForUpdateAsync();

        }

        private void menuItem_github_Click(object sender, EventArgs e)
        {
            ab_player.sPlayer("checkbox");
            Process.Start(new ProcessStartInfo("https://github.com/ebrasha/" + abdal_app_name_for_url) { UseShellExecute = true });
        }

        private void menuItem_gitlab_Click(object sender, EventArgs e)
        {
            ab_player.sPlayer("checkbox");
            Process.Start(new ProcessStartInfo("https://gitlab.com/Prof.Shafiei/" + abdal_app_name_for_url) { UseShellExecute = true });
        }

        private void menuItem_donate_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_about_us_Click(object sender, EventArgs e)
        {
            ab_player.sPlayer("checkbox");
            about_us about_form = new Abdal_Security_Group_App.about_us();
            about_form.ShowDialog();
            about_form.TopMost = true;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            ab_player.sPlayer("checkbox");
            Process.GetCurrentProcess().Kill();
            Environment.Exit(0);
        }

        private void bg_worker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                this.desk_alert.CaptionText = abdal_app_name;
                this.desk_alert.ContentText = "Canceled Process By User!";
                this.desk_alert.Show();
                ab_player.sPlayer("cancel");
            }
            else if (e.Error != null)
            {
                this.desk_alert.CaptionText = abdal_app_name;
                this.desk_alert.ContentText = e.Error.Message;
                this.desk_alert.Show();


                ab_player.sPlayer("error");
            }
            else
            {
                this.desk_alert.CaptionText = abdal_app_name;
                this.desk_alert.ContentText = "Done!";
                this.desk_alert.Show();

                if (stop_op_status)
                {
                    ab_player.sPlayerSync("cancel");
                }
                else
                {
                    ab_player.sPlayerSync("op-com");
                }

                ab_player.sPlayer("done");
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (bg_worker.IsBusy != true)
            {
                bg_worker.RunWorkerAsync();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void irDonationBtn_Click(object sender, EventArgs e)
        {
            ab_player.sPlayer("coin");
            Process.Start(new ProcessStartInfo("https://alphajet.ir/abdal-donation") { UseShellExecute = true });
        }

        private void EnDonationBtn_Click(object sender, EventArgs e)
        {
            ab_player.sPlayer("coin");
            Process.Start(new ProcessStartInfo("https://ebrasha.com/abdal-donation") { UseShellExecute = true });
        }

        private void bg_worker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        // Inject JavaScript into PDF
        public void InjectJavaScriptIntoPdf2(string pdfPath, string jsPath, string outputPath)
        {
            try
            {
                // Check if input files exist
                if (!File.Exists(pdfPath))
                {
                    this.desk_alert.CaptionText = abdal_app_name;
                    this.desk_alert.ContentText = $"[script2PDF!] Error: File '{pdfPath}' does not exist.";
                    this.desk_alert.Show();
                    ab_player.sPlayer("error");
                    return;
                }

                if (!File.Exists(jsPath))
                {
                    this.desk_alert.CaptionText = abdal_app_name;
                    this.desk_alert.ContentText = $"[script2PDF!] Error: File '{jsPath}' does not exist.";
                    this.desk_alert.Show();
                    ab_player.sPlayer("error");
                    return;
                }

                // Read JavaScript content
                string jsCode = File.ReadAllText(jsPath);

                // Load the existing PDF document
                Document pdfDocument = new Document(pdfPath);

                // Create and assign JavaScript action
                JavascriptAction jsAction = new JavascriptAction(jsCode);
                pdfDocument.OpenAction = jsAction;

                // Save modified PDF to output
                pdfDocument.Save(outputPath);


                this.desk_alert.CaptionText = abdal_app_name;
                this.desk_alert.ContentText = $"[script2PDF] JavaScript successfully injected into:\n{outputPath}";
                this.desk_alert.Show();


            }
            catch (Exception ex)
            {
                this.desk_alert.CaptionText = abdal_app_name;
                this.desk_alert.ContentText = $"[script2PDF!] Error occurred:\n{ex.Message}";
                this.desk_alert.Show();
                ab_player.sPlayer("error");
            }
        }


        public void InjectJavaScriptIntoPdf(string pdfPath, string jsPath, string outputPath, string attachFilePath = null)
        {
            try
            {
                // Check if input PDF exists
                if (!File.Exists(pdfPath))
                {
                    this.desk_alert.CaptionText = abdal_app_name;
                    this.desk_alert.ContentText = $"[script2PDF!] Error: File '{pdfPath}' does not exist.";
                    this.desk_alert.Show();
                    ab_player.sPlayer("error");
                    return;
                }

                // Check if JS file exists
                if (!File.Exists(jsPath))
                {
                    this.desk_alert.CaptionText = abdal_app_name;
                    this.desk_alert.ContentText = $"[script2PDF!] Error: File '{jsPath}' does not exist.";
                    this.desk_alert.Show();
                    ab_player.sPlayer("error");
                    return;
                }

                // Read JavaScript content
                string jsCode = File.ReadAllText(jsPath);

                // Load PDF
                Document pdfDocument = new Document(pdfPath);

                // Attach external file if provided
                if (!string.IsNullOrWhiteSpace(attachFilePath) && File.Exists(attachFilePath))
                {
                    FileSpecification fileSpec = new FileSpecification(attachFilePath, Path.GetFileName(attachFilePath));
                    pdfDocument.EmbeddedFiles.Add(fileSpec);
                }

                // Create JS action and assign it as OpenAction
                JavascriptAction jsAction = new JavascriptAction(jsCode);
                pdfDocument.OpenAction = jsAction;

                // Save output
                pdfDocument.Save(outputPath);

                this.desk_alert.CaptionText = abdal_app_name;
                this.desk_alert.ContentText = $"[script2PDF] JavaScript injected and file attached successfully:\n{outputPath}";
                this.desk_alert.Show();
            }
            catch (Exception ex)
            {
                this.desk_alert.CaptionText = abdal_app_name;
                this.desk_alert.ContentText = $"[script2PDF!] Error occurred:\n{ex.Message}";
                this.desk_alert.Show();
                ab_player.sPlayer("error");
            }

        }
        private void btnOpenPDF_Click(object sender, EventArgs e)
        {

        }

        private void openFilePDF_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
        private static bool IsPdfFile(string filePath)
        {
            try
            {
                byte[] buffer = new byte[1024];
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    fs.Read(buffer, 0, buffer.Length);
                    string content = System.Text.Encoding.ASCII.GetString(buffer);
                    return content.Contains("%PDF-");
                }
            }
            catch
            {
                return false;
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            openFilePDF.AddExtension = false;
            openFilePDF.FileName = "";
            openFilePDF.Title = "Abdal JS2PDF Injector";
            openFilePDF.DefaultExt = "pdf";
            openFilePDF.Filter = "pdf File |*.pdf";
            openFilePDF.CheckFileExists = true;
            openFilePDF.CheckPathExists = true;
            var dialog = openFilePDF.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                if (!IsPdfFile(openFilePDF.FileName))
                {
                    MessageBox.Show("Selected file is not a valid PDF.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                selected_pdf_file = true;
                selected_js_file = true;
                FileInfo info = new FileInfo(openFilePDF.FileName);
                lbPDFFileName.Text = info.Name;
                lbPDFFileSize.Text = human_readable_size(openFilePDF.FileName);
                waitingBarPDF.Enabled = true;
                waitingBarPDF.StartWaiting();

            }
        }

        public string human_readable_size(string filename)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            double len = new FileInfo(filename).Length;
            int order = 0;
            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len = len / 1024;
            }


            string result = String.Format("{0:0.##} {1}", len, sizes[order]);
            return result;
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            openFileScript.AddExtension = false;
            openFileScript.FileName = "";
            openFileScript.Title = "Abdal JS2PDF Injector";
            openFileScript.DefaultExt = "js";
            openFileScript.Filter = "js File |*.js";
            openFileScript.CheckFileExists = true;
            openFileScript.CheckPathExists = true;
            var dialog = openFileScript.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                selected_pdf_file = true;
                selected_js_file = true;
                FileInfo info = new FileInfo(openFileScript.FileName);
                lbJSFileName.Text = info.Name;
                lbJSFileSize.Text = human_readable_size(openFileScript.FileName);
                waitingBarJS.Enabled = true;
                waitingBarJS.StartWaiting();
            }
        }

        private void bg_worker_DoWork_1(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            string inputPath = openFilePDF.FileName;
            // Extract directory, filename without extension, and extension
            string directory = Path.GetDirectoryName(inputPath);
            string filenameWithoutExt = Path.GetFileNameWithoutExtension(inputPath);
            string extension = Path.GetExtension(inputPath);
            string outputPath = Path.Combine(directory, $"{filenameWithoutExt} - injected{extension}");

            InjectJavaScriptIntoPdf(openFilePDF.FileName, openFileScript.FileName, outputPath, openAttachFile.FileName);
        }

        private void btnAttachFile_Click(object sender, EventArgs e)
        {
            openAttachFile.AddExtension = false;
            openAttachFile.FileName = "";
            openAttachFile.Title = "Abdal JS2PDF Injector";
            openAttachFile.DefaultExt = "*.*";
            openAttachFile.Filter = "Any File |*.*";
            openAttachFile.CheckFileExists = true;
            openAttachFile.CheckPathExists = true;
            var dialog = openAttachFile.ShowDialog();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            openAttachFile.Reset();
            ab_player.sPlayer("checkbox");
            this.desk_alert.CaptionText = abdal_app_name;
            this.desk_alert.ContentText = "The attached file has been reset.";
            this.desk_alert.Show();
        }
    }
}