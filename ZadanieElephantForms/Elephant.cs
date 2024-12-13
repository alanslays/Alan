using System.Windows.Forms;

class Elephant
{
    public int EarSize;
    public string Name;

    public void WhoAmI()
    {
        MessageBox.Show("Moje uszy mają: " + EarSize + " długości. ", Name + " mówi...");
    }

    public void TellMe(string message, Elephant whoSaidIt)
    {
        MessageBox.Show(whoSaidIt.Name + " mowi: " + message);
    }

    public void SpeakTo(Elephant whoToTalkTo, string message)
    {
        whoToTalkTo.TellMe(message, this);
    }
}