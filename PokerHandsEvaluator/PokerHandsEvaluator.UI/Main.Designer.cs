namespace PokerHandsEvaluator.UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.card2 = new PokerHandsEvaluator.UI.Card();
            this.card1 = new PokerHandsEvaluator.UI.Card();
            this.SuspendLayout();
            // 
            // card2
            // 
            this.card2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("card2.BackgroundImage")));
            this.card2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card2.Location = new System.Drawing.Point(279, 357);
            this.card2.Name = "card2";
            this.card2.Rank = Poker.Rank.Two;
            this.card2.Size = new System.Drawing.Size(90, 130);
            this.card2.Suit = Poker.Suit.Clubs;
            this.card2.TabIndex = 1;
            // 
            // card1
            // 
            this.card1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("card1.BackgroundImage")));
            this.card1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card1.Location = new System.Drawing.Point(127, 399);
            this.card1.Name = "card1";
            this.card1.Rank = Poker.Rank.Eight;
            this.card1.Size = new System.Drawing.Size(90, 130);
            this.card1.Suit = Poker.Suit.Hearts;
            this.card1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 737);
            this.Controls.Add(this.card2);
            this.Controls.Add(this.card1);
            this.Name = "Main";
            this.Text = "Poker Hands Evaluator";
            this.ResumeLayout(false);

        }

        #endregion

        private Card card1;
        private Card card2;
    }
}

