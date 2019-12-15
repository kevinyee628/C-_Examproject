using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 大作业.Sp
{
    public partial class SpInForm : MetroFramework.Forms.MetroForm
    {
        public SpInForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
