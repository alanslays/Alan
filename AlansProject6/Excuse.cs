using System;
using System.Drawing.Text;
using System.Globalization;

private Excuse currentExcuse = new Excuse();
private string selectedFolder = "";
private bool formChanged = false;
Random random = new Random();

private void folder_Click(object sender, EventArgs e)
{
    folderBrowserDialog1.SelectedPath = selectedFolder;
    DialogResult result = folderBrowserDialog1.ShowDialog();
    if (result == DialogResult.OK)
    {
        selectedFolder = folderBrowserDialog1.SelectedPath;
        save.Enabled = true;
        open.Enabled = true;
        randomExcuse.Enabled = true;
    }
}

private void save_Click(object sender, EventArgs e)
{
    if (String.IsNullOrEmpty(description.text) || String.IsNullOrEmpty(results.text))
    {
        MessageBox.Show("Określ wymówkę i rezultat", "Nie można zapisać pliku", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
    }
    saveFileDialog1.InitialDirectory = selectedFolder;
    saveFileDialog1.Filter = "Pliki tekstowe (*txt) | *.txt | Wszystkie pliki (*.*) | *.* ";
    saveFileDialog1.FileName = description.Text + ".txt";
    DialogResult result = saveFileDialog1.ShowDialog();
    if(result == DialogResult.OK)
    {
        currentExcuse.Save(saveFileDialog1.FileName);
        UpdateForm(false);
        MessageBox.Show("Wymówka zapisana");
    }
}

private void open_Click(object sender, EventArgs e)
{
    if(CheckChanged())
    {
        openFileDialog1.InitialDirectory = selectedFolder;
        openFileDialog1.Filter = "Pliki tekstowe (*.txt) | *.txt | Wszystkie pliki (*.*) | *.* ";
        openFileDialog1.FileName = description.Text + ".txt";
        DialogResult result = openFileDialog1.ShowDialog();
        if (result == DialogResult.OK)
        {
            currentExcuse = new Excuse(openFileDialog1.FileName);
            UpdateForm(false);

        }
    }
}

private void randomExcuse_Click(object sender, EventArgs e) 
{
    if (CheckChanged())
    {
        currentExcuse = new Excuse(random, selectedFolder);
        UpdateForm(false);
    }
}

private bool CheckChanged()
{
    if (formChanged)
    {
        DialogResult result = MessageBox.Show("Bieżąca wymówka nie została zapisana. Czy chcesz kontynuować?", "Ostrzeżenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (result == DialogResult.No)

            return false;
    }
    return true;
}

private void description_TextChanged(object sender, EventArgs e)
{
    currentExcuse.Description = description.Text;
    UpdateForm(true);
}

private void results_TextChanged(object sender, EventArgs e)
{
    currentExcuse.Results = results.Text;
    UpdateForm(true);
}

private void lastUsed_ValueChanged(object sender, EventArgs e)
{
    currentExcuse.LastUsed = lastUsed.Value;
    UpdateForm(true);
}

class Excuse
{
    public string Description { get; set; }
    public string Results { get; set; }
    public DayTime LastUsed { get; set; }
    public string ExcusePath { get; set; }
    public Excuse()
    {
        ExcusePath = "";
    }
    public Excuse(string ExcusePath)
    {
        OpenFile(ExcusePath);
    }

    public Excuse(Random random, string folder)
    {
        string[] fileNames = Directory.GetFiles(folder, "*.txt");
        OpenFileDialog(fileNames[random.Next(fileNames.Length)]);
    }

    private void OpenFile(string excusePath)
    {
        this.ExcusePath = excusePath;
        using (StreamReader reader = new StreamReader(ExcusePath)) {
            Description = reader.ReadLine();
            Results = reader.ReadLine();
            LastUsed = Convert.ToDateTime(reader.ReadLine());
        }
    }

    public void Save(string fileName) {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(Description);
            writer.WriteLine(Results);
            writer.WriteLine(LastUsed);
        }

    }
}