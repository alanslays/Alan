using Accessibility;

namespace AlansProject4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            ResetDeck(1);
            ResetDeck(2);
            RedrawDeck(1);
            RedrawDeck(2);
            InitializeComponent();
        }

        private void ResetDeck(int number)
        {
            if (deckNumber == 1)
            {
                int numberOfCards = Random.Next(1, 11);
                deck1 = new Deck(new Card[] { });
                for (int i = 0; i < numberOfCards; i++)
                    deck1.Add(new Card((Suits)Random.Next(4), (Values)random.Next(1, 14)));
                deck1.Sort();

            }
            else
            {
                deck2 = new Deck();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void reset1_Click(object sender, EventArgs e)
        {
            ResetDeck(1);
            RedrawDeck(1);
        }

        private void reset2_Click(object sender, EventArgs e)
        {
            ResetDeck(2);
            RedrawDeck(2);
        }

        private void shuffle1_Click(object sender, EventArgs e)
        {
            deck1.Shuffle();
            RedrawDeck(1);
        }

        private void shuffle2_Click(object sender, EventArgs e)
        {
            deck2.Shuffle();
            RedrawDeck(2);
        }

        private void MoveToDeck1_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >=0 )
                if (deck2.Count > 0)
                {
                    deck1.Add(deck2.Deal(listBox2.SelectedIndex));
                }
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void moveToDeck2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >=0 )
                if (deck1.Count > 0)
                {
                    deck2.Add(deck1.Deal(listBox1.SelectedIndex);
                }
            RedrawDeck(1);
            RedrawDeck(2);
        }
    }
}
