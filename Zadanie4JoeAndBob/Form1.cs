using System.Windows.Forms;

namespace Zadanie4JoeAndBob
{
    

    public partial class Form1 : Form
    {
        /* class Elephant
    {
        public string Name;
        public int EarSize;

        public void WhoAmI()
        {
            MessageBox.Show("Moje uszy maj¹ " + EarSize + " centymetrów szerokoœci. " + Name + " mówi...");
        }
    }
        */

        Elephant lucinda;
        Elephant lloyd;
        public Form1()
        {
            InitializeComponent();
            lucinda = new Elephant()
            {
                Name = "Lucinda",
                EarSize = 33
            };
            lloyd = new Elephant()
            {
                Name = "Lloyd",
                EarSize = 40
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elephant holder;
            holder = lloyd;
            lloyd = lucinda;
            lucinda = holder;
            MessageBox.Show("Obiekty zamienione");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
