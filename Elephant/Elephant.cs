using System;
using System.Windows.Forms;

namespace Elephant
{
    class Elephant
    {
        public int EarSize;
        public string Name;

        public void WhoAmI()
        {
            MessageBox.Show("Moje uszy mają " + EarSize + " długości", Name + " mówi...");
        }
    }
}