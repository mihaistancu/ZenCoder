using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Poker.Hands;

namespace PokerHandsEvaluator.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private readonly Evaluator evaluator = new Evaluator();

        private void CardMoved()
        {
            var firstHand = GetCardsInRegion(panel1);
            var secondHand = GetCardsInRegion(panel2);

            if (firstHand.Length == 5 && secondHand.Length == 5)
            {
                var result = evaluator.Compare(firstHand, secondHand);
                
                if (result == 1)
                {
                    panel1.BackColor = Color.LightGreen;
                    panel2.BackColor = SystemColors.ControlDark;
                }

                if (result == -1)
                {
                    panel1.BackColor = SystemColors.ControlDark;
                    panel2.BackColor = Color.LightGreen;
                }

                if (result == 0)
                {
                    panel1.BackColor = SystemColors.ControlLight;
                    panel2.BackColor = SystemColors.ControlLight;
                }
            }
            else
            {
                panel1.BackColor = SystemColors.ControlDark;
                panel2.BackColor = SystemColors.ControlDark;
            }
        }

        private Poker.Card[] GetCardsInRegion(Panel panel)
        {
            return Controls.OfType<Card>().Where(
                card =>
                    card.Location.X > panel.Location.X
                    && card.Location.Y > panel.Location.Y
                    && card.Location.X + card.Width < panel.Location.X + panel.Width
                    && card.Location.Y + card.Height < panel.Location.Y + panel.Height)
                .Select(card => new Poker.Card(card.Rank, card.Suit)).ToArray();
        }
    }
}
