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
                label4.Text = amountOwed.ToString() + " z�";
            }
            else
            {
                MessageBox.Show("Pocz�tkowy stan licznika musi by� mniejszy ni� ko�cowy", "Nie mog� obliczy� odleg�o�ci");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled + " kilometr�w", "Przebyta odleg�o��");
        }
    }
}
