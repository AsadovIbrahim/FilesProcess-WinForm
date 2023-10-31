namespace FilesProcess
{
    public partial class Form1 : Form
    {
        private Thread copyThread;
        private bool isSuspended = false;
        private bool isAborted = false;
        private System.Windows.Forms.Timer progressBarTimer;
        private int progressBarValue = 0;

        public Form1()
        {
            InitializeComponent();
            progressBarTimer = new System.Windows.Forms.Timer();
            progressBarTimer.Interval = 150; 
            progressBarTimer.Tick += new EventHandler(progressBarTimer_Tick);
        }
        private void progressBarTimer_Tick(object sender, EventArgs e)
        {
            if (progressBarValue < 100)
            {
                progressBarValue++;
                progressBar1.Value = progressBarValue;
            }
            else
            {
                progressBarTimer.Stop();
            }
        }

        private void toFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                toTxtBox.Text = selectedFilePath;
            }
        }

        private void fromButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                fromTxtBox.Text = selectedFilePath;
            }
        }
        private void suspendButton_Click(object sender, EventArgs e)
        {
            isSuspended = true;
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            isSuspended = false;
        }

        private void abortButton_Click(object sender, EventArgs e)
        {
            isAborted = true;
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            string filePath = fromTxtBox.Text;
            string destionationPath = toTxtBox.Text;

            if (!string.IsNullOrEmpty(filePath) && !string.IsNullOrEmpty(destionationPath))
            {
                copyThread = new Thread(() => CopyFile(filePath, destionationPath));
                copyThread.Start();
            }
        }

        private void CopyFile(string sourceFilePath, string destinationFilePath)
        {
            try
            {
                using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open))
                {
                    using (FileStream destinationStream = new FileStream(destinationFilePath, FileMode.Create))
                    {
                        byte[] buffer = new byte[1024];
                        int bytesRead;
                        long totalBytesRead = 0;
                        long totalBytes = sourceStream.Length;

                        while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            if (isSuspended)
                            {
                                Thread.Sleep(100); // İşlemi beklet
                                continue;
                            }

                            if (isAborted)
                            {
                                isAborted = false;
                                return;
                            }

                            destinationStream.Write(buffer, 0, bytesRead);
                            totalBytesRead += bytesRead;

                            // Progress barı güncelle
                            int progress = (int)(((double)totalBytesRead / totalBytes) * 100);
                            UpdateProgressBar(progress);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata yönetimi
            }
        }
        private void UpdateProgressBar(int value)
        {
            if (progressBar1.InvokeRequired)
            {
                progressBar1.Invoke(new Action<int>(UpdateProgressBar), value);
            }
            else
            {
                progressBar1.Value = value;
            }
        }
    }
}