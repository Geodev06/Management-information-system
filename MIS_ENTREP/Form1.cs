using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace MIS_ENTREP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
          
            InitializeComponent();
            txtUser.Focus();
            try
            {
                db.Connect();
                db.Disconnect();
            }
            catch (MySqlException)
            {
                try
                {
                    MySqlConnection con = new MySqlConnection("server=127.0.0.1; user=root;");
                    con.Open();

                    using (MySqlCommand cmds = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmds))
                        {
                            cmds.Connection = con;
                            mb.ImportFromFile("Database.sql");
                        }
                    }
                    con.Close();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Please open wampserver first.", "Message.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Environment.Exit(0);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pb_seePass_MouseUp(object sender, MouseEventArgs e)
        {
            pb_seePass.BackgroundImage = MIS_ENTREP.Properties.Resources.Eye_96px;
            txtPass.UseSystemPasswordChar = true;
        }

        private void pb_seePass_MouseDown(object sender, MouseEventArgs e)
        {
            pb_seePass.BackgroundImage = MIS_ENTREP.Properties.Resources.Eye_96px;
            txtPass.UseSystemPasswordChar=false;
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
        Database db = new Database();
        Alert msgAlert = null;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            db.Connect();
            db.cmd = new MySqlCommand("select * from tb_user where user = @User and pass = @Pass", db.con);
            db.cmd.Parameters.Add(new MySqlParameter("User", txtUser.Text));
            db.cmd.Parameters.Add(new MySqlParameter("Pass", txtPass.Text));
            db.dr = db.cmd.ExecuteReader();

            if (db.dr.Read())
            {
                String user = db.dr["user"].ToString();
                String lname = db.dr["lname"].ToString();
                String gender = db.dr["gender"].ToString();
                this.Hide();
                new MainForm(user, lname, gender).Show();
            }
            else
            {
                if (msgAlert == null)
                {
                    msgAlert = new Alert("Incorrect username or password", "");
                    msgAlert.Show();
                    msgAlert.FormClosed += msgAlert_FormClosed;
                }
            }

            db.Disconnect();
        }
        void msgAlert_FormClosed(object sender, FormClosedEventArgs e)
        {
            msgAlert = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
            hasAccount();

        }
        public void hasAccount()
        {
            db.Connect();
            db.cmd = new MySqlCommand("select * from tb_user", db.con);
            db.dr = db.cmd.ExecuteReader();

            if (db.dr.Read())
            {
                // Has Account...

            }
            else
            {
                Account_UI acc = new Account_UI();
                acc.Show();
                timer1.Enabled = true;
                timer1.Start();
            }
            db.Disconnect();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {
             db.Connect();
            db.cmd = new MySqlCommand("select * from tb_user where user = '" + txtUser.Text + "'", db.con);
            db.dr = db.cmd.ExecuteReader();

            if (db.dr.Read())
            {
                this.Hide();
                new Reset_UI(db.dr["user"].ToString(), db.dr["Sec_Ques"].ToString(), db.dr["Sec_Ans"].ToString()).Show();
            }
            else
            {
                if (msgAlert == null)
                {
                    msgAlert = new Alert("Username doesn't exists", "");
                    msgAlert.Show();
                    msgAlert.FormClosed += msgAlert_FormClosed;
                }
            }
            
            db.Disconnect();
        }
    }
}
