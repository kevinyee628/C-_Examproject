using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 大作业.Staff
{
    public partial class Achm : MetroFramework.Forms.MetroForm
    {
        string str;
        public static Achm f = null;
        public static Achm GetForm(Form f1, string str)
        {
            if (f == null || f.IsDisposed)
            {
                f = new Achm(f1, str);
            }

            return f;
        }
        public Achm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        public Achm(Form f, string str)
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
