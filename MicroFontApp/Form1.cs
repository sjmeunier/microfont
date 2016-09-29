using MicroFont;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroFontApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butGenerate_Click(object sender, EventArgs e)
        {
            MicroFont.MicroFont microFont = new MicroFont.MicroFont();
            picGeneratedImage.Image = microFont.Generate(txtInputText.Text, picGeneratedImage.Width, picGeneratedImage.Height, 5, 5, chkInvertColours.Checked);

        }
    }
}
