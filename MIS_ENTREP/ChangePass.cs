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
    public partial class ChangePass : Form
    {
        Database db = new Database();
        public ChangePass(String user)
        {
            InitializeComponent();
            txtUser.Text = user;
            txtUser.ContextMenu = new ContextMenu();
        }
        Alert msg = null;
        private void pb_seePass_MouseDown(object sender, MouseEventArgs e)
        {
            pb_seePass.BackgroundImage = MIS_ENTREP.Properties.Resources.Eye_96px;
            txtNewPass.UseSystemPasswordChar = false;
        }

        private void pb_seePass_MouseUp(object sender, MouseEventArgs e)
        {
            pb_seePass.BackgroundImage = MIS_ENTREP.Properties.Resources.Eye_96px;
            txtNewPass.UseSystemPasswordChar = true;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtOldPass.Text))
            {
                if (!string.IsNullOrWhiteSpace(txtNewPass.Text))
                {
                    if (!string.IsNullOrWhiteSpace(txtCPass.Text))
                    {
                        if (pb_check.Visible == true)
                        {

                            if (Custom_messageBox.Show("Change the account password?") == DialogResult.Yes)
                            {

                                db.Connect();
                                db.cmd = new MySqlCommand("select * from tb_user where user = @User and pass = @Pass", db.con);
                                db.cmd.Parameters.Add(new MySqlParameter("User", txtUser.Text));
                                db.cmd.Parameters.Add(new MySqlParameter("Pass", txtOldPass.Text));
                                db.dr = db.cmd.ExecuteReader();

                                if (db.dr.Read())
                                {
                                    db.dr.Close();
                                    db.cmd = new MySqlCommand("update tb_user set pass = @NewPass where user = @getUser and pass = @getPass", db.con);
                                    db.cmd.Parameters.Add(new MySqlParameter("NewPass", txtCPass.Text));
                                    db.cmd.Parameters.Add(new MySqlParameter("getUser", txtUser.Text));
                                    db.cmd.Parameters.Add(new MySqlParameter("getPass", txtOldPass.Text));
                                    db.cmd.ExecuteNonQuery();

                                    if (msg == null)
                                    {
                                        msg = new Alert("Password changed", "Information");
                                        msg.Show();
                                        msg.FormClosed += msg_FormClosed;
                                    }
                                    this.Hide();
                                }
                                else
                                {
                                    if (msg == null)
                                    {
                                        msg = new Alert("Incorrect Password", "");
                                        msg.Show();
                                        msg.FormClosed += msg_FormClosed;
                                    }
                                }

                                db.Disconnect();
                            }

                        }
                        else
                        {
                            if (msg == null)
                            {
                                msg = new Alert("Password is not match", "");
                                msg.Show();
                                msg.FormClosed += msg_FormClosed;
                            }
                        }
                    }
                    else
                    {
                        if (msg == null)
                        {
                            msg = new Alert("Please retype the new password", "");
                            msg.Show();
                            msg.FormClosed += msg_FormClosed;
                        }
                    }
                }
                else
                {
                    if (msg == null)
                    {
                        msg = new Alert("Please type the new password", "");
                        msg.Show();
                        msg.FormClosed += msg_FormClosed;
                    }
                }
            }
            else
            {
                if (msg == null)
                {
                    msg = new Alert("Please type the old password", "");
                    msg.Show();
                    msg.FormClosed += msg_FormClosed;
                }
            }
        }
        void msg_FormClosed(object sender, FormClosedEventArgs e)
        {
            msg = null;
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNewPass.Text))
            {
                pb_seePass.Visible = true;
            }
            else
            {
                pb_seePass.Visible = false;
            }

            if (!txtNewPass.Text.Equals(txtCPass.Text))
            {
                pb_check.Visible = false;
            }
            else
            {
                pb_check.Visible = true;
            }
        }

        private void txtCPass_TextChanged(object sender, EventArgs e)
        {
            if (!txtCPass.Text.Equals(txtNewPass.Text))
            {
                pb_check.Visible = false;
            }
            else
            {
                pb_check.Visible = true;
            }
        }

        private void ChangePass_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
