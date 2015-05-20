using System;
using System.Windows.Forms;

namespace Hangman.UI
{
    public partial class LetterInput : UserControl
    {
        public event Action<char> Input;

        public LetterInput()
        {
            InitializeComponent();
        }

        private void Letter_Click(object sender, EventArgs e)
        {
            if (Input != null)
            {
                var button = (Button)sender;
                char letter = button.Text[0];
                Input(letter);
            }
        }
    }
}