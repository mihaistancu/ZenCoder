using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Hangman.UI
{
    public partial class RevealedWord : UserControl
    {
        public RevealedWord()
        {
            InitializeComponent();
        }

        public void Set(Dictionary<int, char> hits)
        {
            int length = GetWordLength(hits);
            char[] letters = GetPlaceHolders(length);
            
            foreach (var letterIndex in hits.Keys)
            {
                letters[letterIndex] = hits[letterIndex];
            }

            label.Text = String.Join(" ", letters);
        }

        private int GetWordLength(Dictionary<int, char> hits)
        {
            return hits.Keys.Max() + 1;
        }

        private char[] GetPlaceHolders(int length)
        {
            return Enumerable.Repeat('_', length).ToArray();
        }
    }
}