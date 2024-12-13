using System;
using System.Windows.Forms;

class Elephant
{
    public string Name;
    public int EarSize;

    public void WhoAmI()
    {
        MessageBox.Show("Moje uszy mają " + EarSize + " centymetrów szerokości. " + Name + " mówi...");
    }
}
