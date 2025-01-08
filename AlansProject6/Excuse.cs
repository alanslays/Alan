using System;

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