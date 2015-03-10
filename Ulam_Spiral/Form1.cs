using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ulam_Spiral
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Primes primes = new Primes(1000000);
            UlamGrid ulamGrid = new UlamGrid();
            Bitmap bitmap = ulamGrid.GetBitmap(primes.list);

            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(1000, 1000);
            pictureBox.Image = bitmap;
            this.Controls.Add(pictureBox);
            this.AutoSize = true;

            bitmap.Save("ulamspiral.jpg");
        }
    }
}
