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
        public ActVip()
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
