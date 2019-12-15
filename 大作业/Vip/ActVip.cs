using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 大作业.Vip
{
    public partial class ActVip : MetroFramework.Forms.MetroForm
    {
        string str;
        public static ActVip f = null;
        public static ActVip GetForm(Form f1, string str)
        {
            if (f == null || f.IsDisposed)
            {
                f = new ActVip(f1, str);
            }

            return f;
        }

        public ActVip()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        public ActVip(Form f, string str)
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
