using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoDWWII_FoV_Fix
{
    public partial class Form1 : Form
    {
    

        public Form1()
        {
            InitializeComponent();                 
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (FileReader.SetLabel() != 0)
            {
                fovLabel.Text = FileReader.SetLabel().ToString();
                fovTrack.Value = FileReader.SetLabel();
            }
        }

        private void fovTrack_Scroll(object sender, EventArgs e)
        {
            fovLabel.Text = fovTrack.Value.ToString();
        }

        private void fovButton_Click(object sender, EventArgs e)
        {
            FileReader.SetFov(fovTrack.Value);

            if (FileReader.ConfirmChanges(fovTrack.Value))
                MessageBox.Show(this,"Successfully Changed Fov!", "Success!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
