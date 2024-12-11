using System.Security.Cryptography.X509Certificates;

namespace Zadanie4
{

    
    class Guy
    {
        public string Name;
        public int Cash;

        public int GiveCash(int amount)
        {
            if (amount <= Cash && amount > 0) { Cash -= amount; return amount; }
            else
            {
                MessageBox.Show("Nie mam wystarczaj¹cej iloœci pieniêdzy, aby Ci daæ " + amount, Name + " powiedzia³...");
                return 0;
            }
        }


        public int ReceiveCash(int amount)
        {
            if (amount > 0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show(amount + " to nie jest iloœæ pieniêdzy, jak¹ mogê wzi¹æ ", Name + " powiedzia³...");
                return 0;
            }


        }
        public partial class Form1 : Form
        {
            Guy joe;
            Guy bob;
            int bank = 100;
            

            private void label2_Click(object sender, EventArgs e)
            {

            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void button1_Click(object sender, EventArgs e)
            {
                if (bank >= 10)
                {
                    bank -= joe.ReceiveCash(10);
                    UpdateForm();
                }
                else
                {
                    MessageBox.Show("Bank nie posiada takiej iloœci pieniêdzy");
                }
            }

            private void UpdateForm()
            {
                throw new NotImplementedException();
            }

            private void button2_Click(object sender, EventArgs e)
            {
                bank += bob.GiveCash(5);
                UpdateForm();
            }
            public Form1() {
                InitializeComponent();
                bob = new Guy();
                bob.Name = "Bob";
                bob.Cash = 100;

                joe = new Guy();
                joe.Name = "Joe";
                joe.Cash = 50;

                UpdateForm();
            }
        }
    }
   
}
