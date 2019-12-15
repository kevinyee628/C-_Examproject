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
        public void showInfo()
        {
            DataSet ds = new DataSet();
            SFact sFact = new SFact();
            SOperate s = sFact.Select();
            ds = s._Select("staff");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                metroComboBox1.Items.Add(ds.Tables[0].Rows[i][1].ToString().Trim());
            }

        }
        private void WagesMange_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            showInfo();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SFact sFact = new SFact();
            SOperate s = sFact.Select();
            SOperate s_updateWage = sFact.Update();
            string wage = wageVule.Text;
            String table_wage = s._Select("wage", "staff", "sta_name",metroComboBox1.Text).Tables[0].Rows[0][0].ToString().Trim();
            if(table_wage == "0")
            {
                s_updateWage._Update("staff", "wage", "sta_name", metroComboBox1.Text);
            }
            else
            {
                MessageBox.Show("已发放薪资");
            }
        }
    }
}
