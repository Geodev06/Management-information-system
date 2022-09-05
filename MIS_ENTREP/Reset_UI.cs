using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MIS_ENTREP
{
    public partial class Reset_UI : Form
    {
        String getAns;
        public Reset_UI(String user, String ques, String ans)
        {
            InitializeComponent();
            txtQuestion.Text = ques;
            lblUsee.Text = user;
            getAns = ans;
        }
        Alert mda = null;

        private void Reset_UI_Load(object sender, EventArgs e)
        {
            txtQuestion.ContextMenu = new ContextMenu();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        Database db = new Database();
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }

        private void txtQuestion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        void mda_FormClosed(object sender, FormClosedEventArgs e)
        {
            mda = null;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text.Equals(getAns))
            {
                if (Custom_messageBox.Show("Reset account?") == DialogResult.Yes)
                {
                    db.Connect();
                    db.cmd = new MySqlCommand("delete from tb_user where Sec_Ques = @ques and Sec_Ans = @ans", db.con);
                    db.cmd.Parameters.Add(new MySqlParameter("ques", txtQuestion.Text));
                    db.cmd.Parameters.Add(new MySqlParameter("ans", txtAnswer.Text));
                    db.cmd.ExecuteNonQuery();
                    db.Disconnect();

                    if (mda == null)
                    {
                        mda = new Alert("Reset account success", "Information");
                        mda.Show();
                        mda.FormClosed += mda_FormClosed;
                    }

                    this.Hide();
                    new Form1().Show();
                }
            }
            else
            {
                if (mda == null)
                {
                    mda = new Alert("Security answer is incorrect", "");
                    mda.Show();
                    mda.FormClosed += mda_FormClosed;
                }
            }
        }
    }
}
