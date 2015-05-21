using System.Linq;
using System.Windows.Forms;

namespace Hangman.UI
{
    public partial class Main : Form
    {
        private readonly WordList wordList = new WordList();
        private const int AvailableAttempts = 6;
        private Game game;

        public Main()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame()
        {
            string word = wordList.GetRandomWord();
            game = new Game(word);
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
                MessageBox.Show("CONDOLENCES. The word you were looking for was: " + game.GetWord());
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