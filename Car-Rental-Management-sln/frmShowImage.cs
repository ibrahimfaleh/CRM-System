using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CarRental
{
    public partial class frmShowImage : Form
    {
        string _ImagePath;
        public frmShowImage(string ImagePath)
        {
            InitializeComponent();
            _ImagePath = ImagePath;
        }

        private void frmShowImage_Load(object sender, EventArgs e)
        {
            if (File.Exists(_ImagePath))
                pbFrontPart.Load(_ImagePath);
            else
            {
                MessageBox.Show("");
                this.Close();   
            }
        }
    }
}
