using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocCarti
{ 
    public class Spatiu
    {
        public PictureBox PB = new PictureBox();
        public PictureBox Carte = new PictureBox();

        public void Create()
        {
            PB.Size = new Size(105, 170);
            PB.SizeMode = PictureBoxSizeMode.StretchImage;
            Carte.Size = new Size(105, 170);
            Carte.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public Spatiu(Point locatie)
        {
            PB.Location = locatie;
            Carte.Location = locatie;
            Create();
        }
    }
}
