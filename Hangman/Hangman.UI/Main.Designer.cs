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
            this.hangingProgress = new Hangman.UI.HangingProgress();
            this.incorrectLetters = new Hangman.UI.IncorrectLetters();
            this.remainingAttempts = new Hangman.UI.RemainingAttempts();
            this.revealedWord = new Hangman.UI.RevealedWord();
            this.letterInput = new Hangman.UI.LetterInput();
            this.SuspendLayout();
            // 
            // hangingProgress1
            // 
            this.hangingProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.hangingProgress.Location = new System.Drawing.Point(13, 53);
            this.hangingProgress.Name = "hangingProgress1";
            this.hangingProgress.Size = new System.Drawing.Size(200, 210);
            this.hangingProgress.TabIndex = 4;
            // 
            // incorrectLetters1
            // 
            this.incorrectLetters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.incorrectLetters.Location = new System.Drawing.Point(13, 269);
            this.incorrectLetters.Name = "incorrectLetters1";
            this.incorrectLetters.Size = new System.Drawing.Size(480, 30);
            this.incorrectLetters.TabIndex = 3;
            // 
            // remainingAttempts1
            // 
            this.remainingAttempts.Location = new System.Drawing.Point(13, 12);
            this.remainingAttempts.Name = "remainingAttempts1";
            this.remainingAttempts.Size = new System.Drawing.Size(270, 35);
            this.remainingAttempts.TabIndex = 2;
            // 
            // revealedWord1
            // 
            this.revealedWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.revealedWord.AutoScroll = true;
            this.revealedWord.BackColor = System.Drawing.SystemColors.Control;
            this.revealedWord.Location = new System.Drawing.Point(13, 305);
            this.revealedWord.Name = "revealedWord1";
            this.revealedWord.Size = new System.Drawing.Size(480, 60);
            this.revealedWord.TabIndex = 1;
            // 
            // input1
            // 
            this.letterInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.letterInput.BackColor = System.Drawing.SystemColors.Control;
            this.letterInput.Location = new System.Drawing.Point(13, 371);
            this.letterInput.Name = "input1";
            this.letterInput.Size = new System.Drawing.Size(480, 146);
            this.letterInput.TabIndex = 0;
            this.letterInput.Input += new System.Action<char>(this.OnInput);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 529);
            this.Controls.Add(this.hangingProgress);
            this.Controls.Add(this.incorrectLetters);
            this.Controls.Add(this.remainingAttempts);
            this.Controls.Add(this.revealedWord);
            this.Controls.Add(this.letterInput);
            this.MinimumSize = new System.Drawing.Size(523, 576);
            this.Name = "Main";
            this.Text = "Hangman";
            this.ResumeLayout(false);

        }

        #endregion

        private LetterInput letterInput;
        private RevealedWord revealedWord;
        private RemainingAttempts remainingAttempts;
        private IncorrectLetters incorrectLetters;
        private HangingProgress hangingProgress;

    }
}

