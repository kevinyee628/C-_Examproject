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
    public partial class AccountLog : MetroFramework.Forms.MetroForm
    {
        string str;
        public static AccountLog f = null;
        public static AccountLog GetForm(Form f1, string str)
        {
            if (f == null || f.IsDisposed)
            {
                f = new AccountLog(f1, str);
            }

            return f;
        }
        public AccountLog()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        public AccountLog(Form f,string str)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.str = str;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccountLog_Load(object sender, EventArgs e)
        {

        }
    }
}
