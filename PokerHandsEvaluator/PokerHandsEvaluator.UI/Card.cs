using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Poker;
using PokerHandsEvaluator.UI.Properties;

namespace PokerHandsEvaluator.UI
{
    public partial class Card : UserControl
    {
        public Card()
        {
            InitializeComponent();
        }

        private Rank rank;

        public Rank Rank
        {
            get { return rank; }
            set
            {
                rank = value;
                UpdateImage();
            }
        }

        private Suit suit;

        public Suit Suit
        {
            get { return suit; }
            set
            {
                suit = value;
                UpdateImage();
            }
        }

        private readonly Dictionary<Rank, string> rankMap = new Dictionary<Rank, string>
        {
            {Rank.Ace, "ace"}, {Rank.Two, "2"}, {Rank.Three, "3"}, {Rank.Four, "4"}, {Rank.Five, "5"},
            {Rank.Six, "6"}, {Rank.Seven, "7"}, {Rank.Eight, "8"}, {Rank.Nine, "9"}, {Rank.Ten, "10"},
            {Rank.Jack, "jack"}, {Rank.Queen, "queen"}, {Rank.King, "king"}
        };

        private readonly Dictionary<Suit, string> suitMap = new Dictionary<Suit, string>
        {
            {Suit.Clubs, "clubs"},
            {Suit.Diamonds, "diamonds"},
            {Suit.Hearts, "hearts"},
            {Suit.Spades, "spades"},
        };

        private void UpdateImage()
        {
            var imageName = string.Format("{0}_of_{1}", rankMap[Rank], suitMap[Suit]);
            BackgroundImage = (Image)Resources.ResourceManager.GetObject(imageName);
        }

        bool dragging;
        Point dragStart = Point.Empty;

        protected override void OnMouseDown(MouseEventArgs mouseEventArgs)
        {
            base.OnMouseDown(mouseEventArgs);

            BringToFront();

            dragging = true;
            dragStart = new Point(mouseEventArgs.X, mouseEventArgs.Y);
            Capture = true;
        }

        protected override void OnMouseUp(MouseEventArgs mouseEventArgs)
        {
            base.OnMouseUp(mouseEventArgs);

            dragging = false;
            Capture = false;
        }

        protected override void OnMouseMove(MouseEventArgs mouseEventArgs)
        {
            base.OnMouseMove(mouseEventArgs);

            if (dragging)
            {
                Left = Math.Max(0, mouseEventArgs.X + Left - dragStart.X);
                Top = Math.Max(0, mouseEventArgs.Y + Top - dragStart.Y);
            }
        }
    }
}
