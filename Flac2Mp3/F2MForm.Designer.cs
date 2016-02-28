namespace Flac2Mp3
{
    partial class F2MForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonDest = new System.Windows.Forms.Button();
            this.textBoxDest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSrc = new System.Windows.Forms.Button();
            this.textBoxSrc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxStatus = new System.Windows.Forms.ListBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.folderBrowserDialogSrc = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogDest = new System.Windows.Forms.FolderBrowserDialog();
            this.processFfmpeg = new System.Diagnostics.Process();
            this.musicProcessor = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonConvert);
            this.groupBox1.Controls.Add(this.buttonDest);
            this.groupBox1.Controls.Add(this.textBoxDest);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonSrc);
            this.groupBox1.Controls.Add(this.textBoxSrc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // buttonConvert
            // 
            this.buttonConvert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonConvert.Location = new System.Drawing.Point(152, 106);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(75, 23);
            this.buttonConvert.TabIndex = 6;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonDest
            // 
            this.buttonDest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDest.Location = new System.Drawing.Point(296, 80);
            this.buttonDest.Name = "buttonDest";
            this.buttonDest.Size = new System.Drawing.Size(75, 23);
            this.buttonDest.TabIndex = 5;
            this.buttonDest.Text = "Browse ...";
            this.buttonDest.UseVisualStyleBackColor = true;
            this.buttonDest.Click += new System.EventHandler(this.buttonDest_Click);
            // 
            // textBoxDest
            // 
            this.textBoxDest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDest.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxDest.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Flac2Mp3.Properties.Settings.Default, "asTextBoxDest", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxDest.Location = new System.Drawing.Point(10, 80);
            this.textBoxDest.Name = "textBoxDest";
            this.textBoxDest.ReadOnly = true;
            this.textBoxDest.Size = new System.Drawing.Size(279, 20);
            this.textBoxDest.TabIndex = 4;
            this.textBoxDest.Text = global::Flac2Mp3.Properties.Settings.Default.asTextBoxDest;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 64);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination Directory";
            // 
            // buttonSrc
            // 
            this.buttonSrc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSrc.Location = new System.Drawing.Point(298, 37);
            this.buttonSrc.Name = "buttonSrc";
            this.buttonSrc.Size = new System.Drawing.Size(75, 23);
            this.buttonSrc.TabIndex = 2;
            this.buttonSrc.Text = "Browse ...";
            this.buttonSrc.UseVisualStyleBackColor = true;
            this.buttonSrc.Click += new System.EventHandler(this.buttonSrc_Click);
            // 
            // textBoxSrc
            // 
            this.textBoxSrc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSrc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxSrc.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Flac2Mp3.Properties.Settings.Default, "asTextBoxSrc", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxSrc.Location = new System.Drawing.Point(10, 37);
            this.textBoxSrc.Name = "textBoxSrc";
            this.textBoxSrc.ReadOnly = true;
            this.textBoxSrc.Size = new System.Drawing.Size(279, 20);
            this.textBoxSrc.TabIndex = 1;
            this.textBoxSrc.Text = global::Flac2Mp3.Properties.Settings.Default.asTextBoxSrc;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Directory";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.listBoxStatus);
            this.groupBox2.Controls.Add(this.buttonClear);
            this.groupBox2.Location = new System.Drawing.Point(13, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 268);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // listBoxStatus
            // 
            this.listBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxStatus.FormattingEnabled = true;
            this.listBoxStatus.Location = new System.Drawing.Point(13, 19);
            this.listBoxStatus.Name = "listBoxStatus";
            this.listBoxStatus.Size = new System.Drawing.Size(351, 199);
            this.listBoxStatus.TabIndex = 2;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonClear.Location = new System.Drawing.Point(152, 239);
            this.buttonClear.MinimumSize = new System.Drawing.Size(75, 25);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 25);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // processFfmpeg
            // 
            this.processFfmpeg.StartInfo.Domain = "";
            this.processFfmpeg.StartInfo.LoadUserProfile = false;
            this.processFfmpeg.StartInfo.Password = null;
            this.processFfmpeg.StartInfo.StandardErrorEncoding = null;
            this.processFfmpeg.StartInfo.StandardOutputEncoding = null;
            this.processFfmpeg.StartInfo.UserName = "";
            this.processFfmpeg.SynchronizingObject = this;
            // 
            // musicProcessor
            // 
            this.musicProcessor.WorkerReportsProgress = true;
            this.musicProcessor.WorkerSupportsCancellation = true;
            this.musicProcessor.DoWork += new System.ComponentModel.DoWorkEventHandler(this.musicProcessor_DoWork);
            this.musicProcessor.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.musicProcessor_ProgressChanged);
            this.musicProcessor.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.musicProcessor_RunWorkerCompleted);
            // 
            // F2MForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 437);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(404, 437);
            this.Name = "F2MForm";
            this.Text = "FLAC 2 MP3 Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F2MForm_FormClosing);
            this.Load += new System.EventHandler(this.F2MForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonDest;
        private System.Windows.Forms.TextBox textBoxDest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSrc;
        private System.Windows.Forms.TextBox textBoxSrc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSrc;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogDest;
        private System.Diagnostics.Process processFfmpeg;
        private System.Windows.Forms.ListBox listBoxStatus;
        private System.ComponentModel.BackgroundWorker musicProcessor;
    }
}

