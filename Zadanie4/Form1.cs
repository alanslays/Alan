using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Zadanie4;


    class Guy
    {
        public required string Name;
        public int Cash;

        public int GiveCash(int amount)
        {
        if (amount <= Cash && amount > 0)
        {
            Cash -= amount;
            return amount;
        }
        else
            {
                MessageBox.Show(
                    "Nie mam wystarczaj�cej ilo�ci pieni�dzy, aby Ci da�" + amount, Name + " powiedzia�...");
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
            else {
                MessageBox.Show(amount + "to nie jest ilo�� pieni�dzy, jak� mog� wzi��", Name = "powiedzia�...");
                return 0;
            }
        }
    }

public partial class Form1 : Form
{
    Guy joe;
    Guy bob;
    int bank = 100;


    public Form1()
    {
        InitializeComponent(GetV());
        bob = new Guy() { Cash = 100, Name = "Bob" };
        joe = new Guy() { Cash = 50, Name = "Joe" };
        UpdateForm();
    }
    public void UpdateForm()
    {
        joesCashLabel.Text = joe.Name + " ma " + joe.Cash + " z�";
        bobsCashLabel.Text = bob.Name + " ma " + bob.Cash + " z�";
        bankCashLabel.Text = "Bank ma " + bank + " z�";
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
            MessageBox.Show("Bank nie posiada takiej ilo�ci pieni�dzy");
        }
    }
    private void button2_Click(object sender, EventArgs e)
    {
        bank += bob.GiveCash(5);
        UpdateForm();
    }

    private void joeGivesToBob_Click(object sender, EventArgs e)
    {
        bob.ReceiveCash(joe.GiveCash(10));
        UpdateForm();
    }

    private void bobGivesToJoe_Click(object sender, EventArgs e)
    {
        joe.ReceiveCash(bob.GiveCash(5));
        UpdateForm();
    }


}



