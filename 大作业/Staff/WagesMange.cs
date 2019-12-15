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
    public partial class WagesMange : MetroFramework.Forms.MetroForm
    {
        string str;
        public static WagesMange f = null;
        public static WagesMange GetForm(Form f1, string str)
        {
            if (f == null || f.IsDisposed)
            {
                f = new WagesMange(f1, str);
            }

            return f;
        }
        public WagesMange()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        public WagesMange(Form f, string str)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.str = str;
        }
        private void WagesMange_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
