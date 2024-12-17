namespace Zadanie12
{
    public partial class Form1 : Form
    {
        int startingMileage;
        int endingMileage;
        double milesTraveled;
        double reimburseRate = .39;
        double amountOwed;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startingMileage = (int)Checkbox1.Value;
            endingMileage = (int)Checkbox2.Value;

            if (startingMileage <= endingMileage)
            {
                milesTraveled = endingMileage - startingMileage;
                amountOwed = milesTraveled * reimburseRate;
                label4.Text = amountOwed.ToString() + " z³";
            }
            else
            {
                MessageBox.Show("Pocz¹tkowy stan licznika musi byæ mniejszy ni¿ koñcowy", "Nie mogê obliczyæ odleg³oœci");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled + " kilometrów", "Przebyta odleg³oœæ");
        }
    }
}
