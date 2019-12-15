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
        string str;
        public static SpInForm f = null;
        public static SpInForm GetForm(Form f1, string str)
        {
            if (f == null || f.IsDisposed)
            {
                f = new SpInForm(f1, str);
            }

            return f;
        }
        public SpInForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        public SpInForm(Form f, string str)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.str = str;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
