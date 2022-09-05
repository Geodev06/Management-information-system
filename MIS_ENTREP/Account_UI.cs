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
    public partial class Account_UI : Form
    {
        public Account_UI()
        {
            InitializeComponent();
        }
        Database db = new Database();
        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void pb_seePass_MouseDown(object sender, MouseEventArgs e)
        {
            pb_seePass.BackgroundImage = MIS_ENTREP.Properties.Resources.Eye_96px;
            txtPass.UseSystemPasswordChar = false;
        }

        private void pb_seePass_MouseUp(object sender, MouseEventArgs e)
        {
            pb_seePass.BackgroundImage = MIS_ENTREP.Properties.Resources.Hide_96px;
            txtPass.UseSystemPasswordChar = true;

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPass.Text))
            {
                pb_seePass.Visible = true;
            }
            else
            {
                pb_seePass.Visible = false;
            }
        }

        private void txtRPass_TextChanged(object sender, EventArgs e)
        {
            if(txtRPass.Text == txtPass.Text)
            {
                pictureBox1.Visible = true;
            }
            else{
                pictureBox1.Visible = false;
            }
        }
        Alert msg = null;
        String gender = "";
        void msg_FormClosed(object sender, FormClosedEventArgs e)
        {
            msg = null;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtfn.Text) || string.IsNullOrWhiteSpace(txtln.Text) || string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text) || cb_Ques.selectedIndex==-1 || string.IsNullOrWhiteSpace(txtAns.Text))
            {
                if (msg == null)
                {
                    msg = new Alert("Please fill up everything", "");
                    msg.Show();
                    msg.FormClosed += msg_FormClosed;
                }
            }
            
            else
            {
                if (radioButton1.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }


                if (Custom_messageBox.Show("Add this account?") == DialogResult.Yes)
                {
                    if (txtRPass.Text != txtPass.Text)
                    {
                        if (msg == null)
                        {
                            msg = new Alert("Two Pasword does not match", "");
                            msg.Show();
                            msg.FormClosed += msg_FormClosed;
                        }
                    }
                    else
                    {
                        db.Connect();
                        db.cmd = new MySqlCommand("insert into tb_user(user, pass, fname, lname, gender, Sec_Ques, Sec_Ans)values(@user, @pass, @fname, @lname, @sex, @ques, @ans)", db.con);
                        db.cmd.Parameters.Add(new MySqlParameter("user", txtUser.Text));
                        db.cmd.Parameters.Add(new MySqlParameter("pass", txtPass.Text));
                        db.cmd.Parameters.Add(new MySqlParameter("fname", txtfn.Text));
                        db.cmd.Parameters.Add(new MySqlParameter("lname", txtln.Text));
                        db.cmd.Parameters.Add(new MySqlParameter("sex", gender));
                        db.cmd.Parameters.Add(new MySqlParameter("ques", cb_Ques.selectedValue.ToString()));
                        db.cmd.Parameters.Add(new MySqlParameter("ans", txtAns.Text));
                        db.cmd.ExecuteNonQuery();
                        db.Disconnect();

                        if (msg == null)
                        {
                            msg = new Alert("Account created", "Information");
                            msg.Show();
                            msg.FormClosed += msg_FormClosed;
                        }

                        this.Hide();
                        new Form1().Show();
                    }
                }
            }
        }
    }
}
