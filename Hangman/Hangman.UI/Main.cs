using System.Linq;
using System.Windows.Forms;

namespace Hangman.UI
{
    public partial class Main : Form
    {
        private Game game;
        private const int AvailableAttempts = 6;

        public Main()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame()
        {
            game = new Game("SUPERCALIFRAGILISTICXPCALIDOCIOUS");
            UpdateScreen();
        }

        private void UpdateScreen()
        {
            incorrectLetters.Set(game.GetMisses());
            remainingAttempts.Set(GetRemainingAttempts());
            revealedWord.Set(game.GetHits());
        }

        private int GetRemainingAttempts()
        {
            return AvailableAttempts - game.GetMisses().Count();
        }

        private void OnInput(char letter)
        {
            game.Guess(letter);
            UpdateScreen();
            
            if (GetRemainingAttempts() < 0)
            {
                MessageBox.Show("CONDOLENCES");
                StartNewGame();
            }

            if (game.IsWordGuessed())
            {
                MessageBox.Show("CONGRATULATIONS");
                StartNewGame();
            }
        }
    }
}