using System.Linq;
using System.Windows.Forms;

namespace Hangman.UI
{
    public partial class Main : Form
    {
        private readonly Game game;
        private const int AvailableAttempts = 6;

        public Main()
        {
            InitializeComponent();

            game = new Game("SUPERCALIFRAGILISTICXPCALIDOCIA");
            UpdateScreen();
        }

        private void OnInput(char letter)
        {
            game.Guess(letter);
            UpdateScreen();
        }

        private void UpdateScreen()
        {
            incorrectLetters.Set(game.GetMisses());
            remainingAttempts.Set(AvailableAttempts - game.GetMisses().Count());
            revealedWord.Set(game.GetHits());
        }
    }
}