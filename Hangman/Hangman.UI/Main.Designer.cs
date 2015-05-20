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
            this.remainingAttempts1 = new Hangman.UI.RemainingAttempts();
            this.revealedWord1 = new Hangman.UI.RevealedWord();
            this.input1 = new Hangman.UI.LetterInput();
            this.incorrectLetters1 = new Hangman.UI.IncorrectLetters();
            this.SuspendLayout();
            // 
            // remainingAttempts1
            // 
            this.remainingAttempts1.Location = new System.Drawing.Point(13, 12);
            this.remainingAttempts1.Name = "remainingAttempts1";
            this.remainingAttempts1.Size = new System.Drawing.Size(270, 35);
            this.remainingAttempts1.TabIndex = 2;
            // 
            // revealedWord1
            // 
            this.revealedWord1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.revealedWord1.AutoScroll = true;
            this.revealedWord1.BackColor = System.Drawing.SystemColors.Control;
            this.revealedWord1.Location = new System.Drawing.Point(13, 305);
            this.revealedWord1.Name = "revealedWord1";
            this.revealedWord1.Size = new System.Drawing.Size(480, 60);
            this.revealedWord1.TabIndex = 1;
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
            // incorrectLetters1
            // 
            this.incorrectLetters1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.incorrectLetters1.Location = new System.Drawing.Point(13, 269);
            this.incorrectLetters1.Name = "incorrectLetters1";
            this.incorrectLetters1.Size = new System.Drawing.Size(480, 30);
            this.incorrectLetters1.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 529);
            this.Controls.Add(this.incorrectLetters1);
            this.Controls.Add(this.remainingAttempts1);
            this.Controls.Add(this.revealedWord1);
            this.Controls.Add(this.input1);
            this.MinimumSize = new System.Drawing.Size(523, 576);
            this.Name = "Main";
            this.Text = "Hangman";
            this.ResumeLayout(false);

        }

        #endregion

        private LetterInput input1;
        private RevealedWord revealedWord1;
        private RemainingAttempts remainingAttempts1;
        private IncorrectLetters incorrectLetters1;

    }
}

