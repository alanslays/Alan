namespace ZADANIE6
{
    public partial class Form1 : Form
    {
        public class MenuMaker
        {
            public Random Randomizer;

            string[] Meats = { "Pieczona wo�owina", "Salami", "Indyk", "Szynka", "Kark�wka" };
            string[] Condiments = { "��ta musztarda", "br�zowa musztarda", "musztarda miodowa", "majonez", "przyprawa", "sos francuski"};
            string[] Breads = { "chleb ry�owy", "chleb bia�y", "chleb zbo�owy", "pumpernikiel", "chleb w�oski", "bu�ka" };

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
