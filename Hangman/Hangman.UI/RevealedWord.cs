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
            int length = hits.Keys.Max() + 1;
            char[] letters = Enumerable.Repeat('_', length).ToArray();
            
            foreach (var letterIndex in hits.Keys)
            {
                letters[letterIndex] = hits[letterIndex];
            }

            label.Text = String.Join(" ", letters);
        }
    }
}