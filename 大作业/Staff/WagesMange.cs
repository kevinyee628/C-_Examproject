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
        public WagesMange()
        {
            InitializeComponent();
            this.ControlBox = false;
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
