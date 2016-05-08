namespace LazyVoiceV2
{
    partial class Form1
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
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.enableVoiceButton = new System.Windows.Forms.Button();
            this.disableVoiceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(12, 12);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(457, 246);
            this.outputTextBox.TabIndex = 0;
            this.outputTextBox.Text = "-Log-";
            // 
            // enableVoiceButton
            // 
            this.enableVoiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableVoiceButton.Location = new System.Drawing.Point(12, 291);
            this.enableVoiceButton.Name = "enableVoiceButton";
            this.enableVoiceButton.Size = new System.Drawing.Size(221, 36);
            this.enableVoiceButton.TabIndex = 1;
            this.enableVoiceButton.Text = "Enable Voice Control";
            this.enableVoiceButton.UseVisualStyleBackColor = true;
            this.enableVoiceButton.Click += new System.EventHandler(this.enableVoiceButton_Click);
            // 
            // disableVoiceButton
            // 
            this.disableVoiceButton.Enabled = false;
            this.disableVoiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disableVoiceButton.Location = new System.Drawing.Point(251, 291);
            this.disableVoiceButton.Name = "disableVoiceButton";
            this.disableVoiceButton.Size = new System.Drawing.Size(218, 36);
            this.disableVoiceButton.TabIndex = 2;
            this.disableVoiceButton.Text = "Disable Voice Control";
            this.disableVoiceButton.UseVisualStyleBackColor = true;
            this.disableVoiceButton.Click += new System.EventHandler(this.disableVoiceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 335);
            this.Controls.Add(this.disableVoiceButton);
            this.Controls.Add(this.enableVoiceButton);
            this.Controls.Add(this.outputTextBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LazyVoice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.Button enableVoiceButton;
        private System.Windows.Forms.Button disableVoiceButton;
    }
}

