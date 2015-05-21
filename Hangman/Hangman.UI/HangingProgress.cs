using System.Windows.Forms;

namespace Hangman.UI
{
    public partial class HangingProgress : UserControl
    {
        public HangingProgress()
        {
            InitializeComponent();
        }

        public void Set(int step)
        {
            pictureBox.Image = imageList.Images[step];
        }
    }
}
