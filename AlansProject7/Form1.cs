using System.Drawing.Text;

namespace AlansProject7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            workerBeeJob.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Zbieranie nektaru", "Wytwarzanie miodu" });
            workers[1] = new Worker(new string[] { "Piel�gnacja jaj", "Nauczanie pszcz�ek" });
            workers[2] = new Worker(new string[] { "Utrzymywanie ula", "Patrol z ��d�ami" });
            workers[3] = new Worker(new string[] { "Piel�gnacja jaj", "Nauczanie pszcz�ek", "Utrzymywanie ula", "Patrol z ��d�ami" });

            queen = new Queen(workers);
        }

        private Queen queen;

        private void assignJob_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workerBeeJob.Text, (int)shifts.Value) == false)
                MessageBox.Show("Nie ma dost�pnych robotnic do wykonania zadania '" + workerBeeJob.Text + "'", "Kr�lowa pszcz� m�wi...");
            else
                MessageBox.Show("Zadanie '" + workerBeeJob.Text + "' b�dzie uko�czone za " + shifts.Value + " zmiany", "Kr�lowa pszcz� m�wi");

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nextShift_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }
    }
}
