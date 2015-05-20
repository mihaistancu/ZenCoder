using System.Windows.Forms;

namespace Hangman.UI
{
    public partial class RemainingAttempts : UserControl
    {
        public RemainingAttempts()
        {
            InitializeComponent();
        }

        public void Set(int remainingAttempts)
        {
            label.Text = "Remaining attempts: " + remainingAttempts;
        }
    }
}