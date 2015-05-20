using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hangman.UI
{
    public partial class IncorrectLetters : UserControl
    {
        public IncorrectLetters()
        {
            InitializeComponent();
        }

        public void Set(IEnumerable<char> letters)
        {
            label.Text = "Misses: " + String.Join(", ", letters);
        }
    }
}