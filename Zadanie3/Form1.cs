class DinnerParty
{
    internal object setHealthyOption;
    int NumberOfPeople;
    int CostOfBeveragesPerPerson;
    int CostOfDecorations;

    bool SetHealthyOption;

    internal void setHealthyOption(bool v)
    {
        throw new NotImplementedException();
    }

    internal void CalculateCostOfDecorations(bool v)
    {
        throw new NotImplementedException();
    }
}

namespace Zadanie3
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;

        private void numericUpDown1_ValueChanged (object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            if(fancy)
            {
                CalculateCostOfDecorations.
            }
        }
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty();
            object setHealthyOption = dinnerParty.setHealthyOption;
            dinnerParty.setHealthyOption(false);
            dinnerParty.CalculateCostOfDecorations(true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
