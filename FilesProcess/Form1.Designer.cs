namespace FilesProcess
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            fromTxtBox = new TextBox();
            toTxtBox = new TextBox();
            fromButton = new Button();
            toFileButton = new Button();
            progressBar1 = new ProgressBar();
            suspendButton = new Button();
            resumeButton = new Button();
            abortButton = new Button();
            copyButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 0;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 103);
            label2.Name = "label2";
            label2.Size = new Size(30, 25);
            label2.TabIndex = 1;
            label2.Text = "To";
            // 
            // fromTxtBox
            // 
            fromTxtBox.Location = new Point(107, 40);
            fromTxtBox.Name = "fromTxtBox";
            fromTxtBox.Size = new Size(434, 31);
            fromTxtBox.TabIndex = 2;
            // 
            // toTxtBox
            // 
            toTxtBox.Location = new Point(107, 100);
            toTxtBox.Name = "toTxtBox";
            toTxtBox.Size = new Size(434, 31);
            toTxtBox.TabIndex = 3;
            // 
            // fromButton
            // 
            fromButton.Location = new Point(614, 38);
            fromButton.Name = "fromButton";
            fromButton.Size = new Size(112, 34);
            fromButton.TabIndex = 4;
            fromButton.Text = "File...";
            fromButton.UseVisualStyleBackColor = true;
            fromButton.Click += fromButton_Click;
            // 
            // toFileButton
            // 
            toFileButton.Location = new Point(614, 103);
            toFileButton.Name = "toFileButton";
            toFileButton.Size = new Size(112, 34);
            toFileButton.TabIndex = 5;
            toFileButton.Text = "File...";
            toFileButton.UseVisualStyleBackColor = true;
            toFileButton.Click += toFileButton_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(21, 177);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(197, 34);
            progressBar1.TabIndex = 6;
            // 
            // suspendButton
            // 
            suspendButton.Location = new Point(257, 177);
            suspendButton.Name = "suspendButton";
            suspendButton.Size = new Size(112, 34);
            suspendButton.TabIndex = 7;
            suspendButton.Text = "Suspend";
            suspendButton.UseVisualStyleBackColor = true;
            // 
            // resumeButton
            // 
            resumeButton.Location = new Point(375, 177);
            resumeButton.Name = "resumeButton";
            resumeButton.Size = new Size(112, 34);
            resumeButton.TabIndex = 8;
            resumeButton.Text = "Resume";
            resumeButton.UseVisualStyleBackColor = true;
            // 
            // abortButton
            // 
            abortButton.Location = new Point(493, 177);
            abortButton.Name = "abortButton";
            abortButton.Size = new Size(112, 34);
            abortButton.TabIndex = 9;
            abortButton.Text = "Abort";
            abortButton.UseVisualStyleBackColor = true;
            // 
            // copyButton
            // 
            copyButton.Location = new Point(614, 177);
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(112, 34);
            copyButton.TabIndex = 10;
            copyButton.Text = "Copy";
            copyButton.UseVisualStyleBackColor = true;
            copyButton.Click += copyButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 239);
            Controls.Add(copyButton);
            Controls.Add(abortButton);
            Controls.Add(resumeButton);
            Controls.Add(suspendButton);
            Controls.Add(progressBar1);
            Controls.Add(toFileButton);
            Controls.Add(fromButton);
            Controls.Add(toTxtBox);
            Controls.Add(fromTxtBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox fromTxtBox;
        private TextBox toTxtBox;
        private Button fromButton;
        private Button toFileButton;
        private ProgressBar progressBar1;
        private Button suspendButton;
        private Button resumeButton;
        private Button abortButton;
        private Button copyButton;
    }
}