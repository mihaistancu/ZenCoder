namespace Hangman.UI
{
    partial class Main
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
            this.input1 = new Hangman.UI.Input();
            this.revealedWord1 = new Hangman.UI.RevealedWord();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input1.BackColor = System.Drawing.SystemColors.Control;
            this.input1.Location = new System.Drawing.Point(13, 371);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(480, 146);
            this.input1.TabIndex = 0;
            // 
            // revealedWord1
            // 
            this.revealedWord1.AutoScroll = true;
            this.revealedWord1.BackColor = System.Drawing.SystemColors.Control;
            this.revealedWord1.Location = new System.Drawing.Point(13, 305);
            this.revealedWord1.Name = "revealedWord1";
            this.revealedWord1.Size = new System.Drawing.Size(480, 60);
            this.revealedWord1.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 529);
            this.Controls.Add(this.revealedWord1);
            this.Controls.Add(this.input1);
            this.Name = "Main";
            this.Text = "Hangman";
            this.ResumeLayout(false);

        }

        #endregion

        private Input input1;
        private RevealedWord revealedWord1;

    }
}

