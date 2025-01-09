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
            workers[1] = new Worker(new string[] { "Pielêgnacja jaj", "Nauczanie pszczó³ek" });
            workers[2] = new Worker(new string[] { "Utrzymywanie ula", "Patrol z ¿¹d³ami" });
            workers[3] = new Worker(new string[] { "Pielêgnacja jaj", "Nauczanie pszczó³ek", "Utrzymywanie ula", "Patrol z ¿¹d³ami" });

            queen = new Queen(workers);
        }

        private Queen queen;

        private void assignJob_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workerBeeJob.Text, (int)shifts.Value) == false)
                MessageBox.Show("Nie ma dostêpnych robotnic do wykonania zadania '" + workerBeeJob.Text + "'", "Królowa pszczó³ mówi...");
            else
                MessageBox.Show("Zadanie '" + workerBeeJob.Text + "' bêdzie ukoñczone za " + shifts.Value + " zmiany", "Królowa pszczó³ mówi");

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
