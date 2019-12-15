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
    public partial class MsgPushVip : MetroFramework.Forms.MetroForm
    {
        string str;
        public static MsgPushVip f = null;
        public static MsgPushVip GetForm(Form f1, string str)
        {
            if (f == null || f.IsDisposed)
            {
                f = new MsgPushVip(f1, str);
            }

            return f;
        }
        public MsgPushVip()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        public MsgPushVip(Form f, string str)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.str = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
