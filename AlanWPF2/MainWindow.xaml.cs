using System;
using System.Windows;
using System.Windows.Controls;

namespace AlanWPF2
{
    public partial class MainWindow : Window
    {
        private Queen queen;
        private Worker[] workers;

        public MainWindow()
        {
            InitializeComponent();

            
            workers = new Worker[4];
            for (int i = 0; i < workers.Length; i++)
            {
                workers[i] = new Worker();
            }

            
            queen = new Queen(workers);
        }

        private void AssignWorkButton_Click(object sender, RoutedEventArgs e)
        {
            
            string job = ((ComboBoxItem)TaskComboBox.SelectedItem).Content.ToString();
            int shifts = 0;
            if (int.TryParse(ShiftsTextBox.Text, out shifts))
            {
                bool success = queen.AssignWork(job, shifts);
                if (!success)
                {
                    MessageBox.Show("Brak dostępnych robotników do przypisania tego zadania.");
                }
            }
            else
            {
                MessageBox.Show("Wprowadź poprawną liczbę zmian.");
            }

            UpdateReport();
        }

        private void NextShiftButton_Click(object sender, RoutedEventArgs e)
        {
            
            string report = queen.WorkTheNextShift();
            ReportTextBlock.Text = report;
        }

        private void UpdateReport()
        {
            
            string report = queen.WorkTheNextShift();
            ReportTextBlock.Text = report;
        }
    }
}
