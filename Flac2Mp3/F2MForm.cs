using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using Flac2Mp3.Properties;

namespace Flac2Mp3
{
    public partial class F2MForm : Form
    {
        public F2MForm()
        {
            InitializeComponent();
            buttonConvert.Enabled = false;
        }

        private void buttonSrc_Click(object sender, EventArgs e)
        {
            if (textBoxSrc.Text.Length > 0)
            {
                folderBrowserDialogSrc.SelectedPath = textBoxSrc.Text;
            }
            folderBrowserDialogSrc.ShowDialog();
            if (folderBrowserDialogSrc.SelectedPath.Length > 0)
            {
                textBoxSrc.Text = folderBrowserDialogSrc.SelectedPath;
                buttonConvert.Enabled = textBoxSrc.Text.Length > 0 && textBoxDest.Text.Length > 0;
            }
        }

        private void buttonDest_Click(object sender, EventArgs e)
        {
            if (textBoxDest.Text.Length > 0)
            {
                folderBrowserDialogDest.SelectedPath = textBoxDest.Text;
            }
            folderBrowserDialogDest.ShowDialog();
            if (folderBrowserDialogDest.SelectedPath.Length > 0)
            {
                textBoxDest.Text = folderBrowserDialogDest.SelectedPath;
                buttonConvert.Enabled = textBoxSrc.Text.Length > 0 && textBoxDest.Text.Length > 0;
            }
        }

        private void processMusic(BackgroundWorker worker)
        {
            String srcPath = textBoxSrc.Text;
            int pos = srcPath.LastIndexOf(Path.DirectorySeparatorChar);
            String srcDir = srcPath.Substring(pos + 1);
            logStatus(worker, "Source directory '" + srcDir + "'");
            String destPath = textBoxDest.Text;
            bool status = true;
            // if the destination directory is the same as srcDir
            // convert/copy the files there
            if (destPath.EndsWith(srcDir))
            {
                logStatus(worker, "Files will be copied to '" + destPath + "'");
            }
            else
            {
                destPath += Path.DirectorySeparatorChar + srcDir;
                if (Directory.Exists(destPath))
                {
                    logStatus(worker, "Files will be copied to '" + destPath + "'");
                }
                else
                {
                    DirectoryInfo di = null;
                    try
                    {
                        di = Directory.CreateDirectory(destPath);
                        if (di.Exists)
                        {
                            logStatus(worker, "Successfully created '" + destPath + "'");
                        }
                    }
                    catch
                    {
                        status = false;
                        logStatus(worker, "Could not create '" + destPath + "'");
                    }
                    logStatus(worker, "Files will be copied to " + destPath + "'");
                }

            }
            if (status)
            {
                DirectoryInfo srcDI = new DirectoryInfo(srcPath);
                FileInfo[] fiList = srcDI.GetFiles("*.mp3");
                foreach (FileInfo fi in fiList)
                {
                    if (musicProcessor.CancellationPending)
                    {
                        break;
                    }
                    FileInfo tempFi = new FileInfo(destPath + Path.DirectorySeparatorChar + fi.Name);
                    if (!tempFi.Exists)
                    {
                        logStatus(worker, "Copying '" + fi.Name + "' to '" + destPath + "'");
                        fi.CopyTo(tempFi.FullName);
                    }
                }
                fiList = srcDI.GetFiles("*.flac");
                foreach (FileInfo fi in fiList)
                {
                    if (musicProcessor.CancellationPending)
                    {
                        break;
                    }
                    String destFile = fi.Name;
                    destFile = destFile.Substring(0, destFile.Length - 4) + "mp3";
                    FileInfo tempFi = new FileInfo(destPath + Path.DirectorySeparatorChar + destFile);
                    if (!tempFi.Exists)
                    {
                        logStatus(worker, "Converting '" + fi.Name + "' to '" + destPath + Path.DirectorySeparatorChar + destFile + "'");
                        processFfmpeg.StartInfo.UseShellExecute = false;
                        processFfmpeg.StartInfo.FileName = "C:\\Program Files (x86)\\ffmpeg\\ffmpeg.exe";
                        processFfmpeg.StartInfo.Arguments = "-i \"" + fi.FullName + "\" -ab 320k \"" + tempFi.FullName + "\"";
                        processFfmpeg.StartInfo.CreateNoWindow = true;
                        processFfmpeg.Start();
                        processFfmpeg.WaitForExit();
                    }
                }
                logStatus(worker, "Done");
            }
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if (buttonConvert.Text == "Convert")
            {
                listBoxStatus.Items.Clear();
                buttonConvert.Text = "Cancel";
                buttonSrc.Enabled = false;
                buttonClear.Enabled = false;
                buttonDest.Enabled = false;
                musicProcessor.RunWorkerAsync();
            }
            else
            {
                buttonConvert.Enabled = false;
                musicProcessor.CancelAsync();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxStatus.Items.Clear();
        }

        private void logStatus(BackgroundWorker worker, String status)
        {
            if (worker == null)
            {
                listBoxStatus.Items.Add(status);
                listBoxStatus.SelectedIndex = listBoxStatus.Items.Count - 1;
            }
            else
            {
                worker.ReportProgress(0, status);
            }
        }

        private void logStatus(String status)
        {
            listBoxStatus.Items.Add(status);
            listBoxStatus.SelectedIndex = listBoxStatus.Items.Count - 1;
        }

        private void F2MForm_Load(object sender, EventArgs e)
        {
            buttonConvert.Enabled = textBoxSrc.Text.Length > 0 && textBoxDest.Text.Length > 0;
        }

        private void F2MForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConfigurationManager.AppSettings["asTextBoxSrc"] = textBoxSrc.Text;
            Settings.Default.Save();
        }

        private void musicProcessor_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            processMusic(worker);
        }

        private void musicProcessor_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            logStatus(e.UserState as String);
        }

        private void musicProcessor_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            buttonConvert.Text = "Convert";
            buttonConvert.Enabled = true;
            buttonSrc.Enabled = true;
            buttonClear.Enabled = true;
            buttonDest.Enabled = true;
        }
    }
}
