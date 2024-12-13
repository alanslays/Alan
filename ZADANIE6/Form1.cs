namespace ZADANIE6
{
    public partial class Form1 : Form
    {
        public class MenuMaker
        {
            public Random Randomizer;

            string[] Meats = { "Pieczona wo這wina", "Salami", "Indyk", "Szynka", "Kark闚ka" };
            string[] Condiments = { "鄴速a musztarda", "br頊owa musztarda", "musztarda miodowa", "majonez", "przyprawa", "sos francuski"};
            string[] Breads = { "chleb ry穎wy", "chleb bia造", "chleb zbo穎wy", "pumpernikiel", "chleb w這ski", "bu趾a" };

            public string GetMenuItem()
            {
                string randomMeat = Meats[Randomizer.Next(Meats.Length)];
                string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
                string randomBread = Breads[Randomizer.Next(Breads.Length)];

                return randomMeat + ", " + randomCondiment + ", " + randomBread;
            }
        }
        public Form1()
        {
            InitializeComponent();

            MenuMaker menu = new MenuMaker() { Randomizer = new Random() };
            label1.Text = menu.GetMenuItem();
            label2.Text = menu.GetMenuItem();
            label3.Text = menu.GetMenuItem();
            label4.Text = menu.GetMenuItem();
            label5.Text = menu.GetMenuItem();
            label6.Text = menu.GetMenuItem();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
