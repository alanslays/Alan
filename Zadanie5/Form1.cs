namespace Zadanie5
{
    public partial class Form1 : Form
    {
        int startingMileage;
        int endingMileage;
        double milesTraveled;
        double reimburseRate = .39;
        double amountOwned;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startingMileage = (int)numericUpDown1.Value;
            endingMileage = (int)numericUpDown2.Value;
            if (startingMileage <= endingMileage)
            {
                milesTraveled = endingMileage -= startingMileage;
                amountOwned = milesTraveled *= reimburseRate;
                label4.Text = amountOwned.ToString() + " z³";
            } else
            {
                MessageBox.Show(
                    "Pocz¹tkowy stan licznika musi byæ mniejszy ni¿ koñcowy", "Nie mogê obliczyæ odleg³oœci");
            }
        }
    }
}
