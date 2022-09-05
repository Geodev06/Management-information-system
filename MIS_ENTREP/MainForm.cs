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
    public partial class MainForm : Form
    {
        Database db = new Database();
        String getUser, getLname, getGender;
        public MainForm(String user, String lname, String gender)
        {
            InitializeComponent();
            getUser = user;
            getLname = lname;
            getGender = gender;

            checkProfile();
        }
        public void checkProfile()
        {
            try
            {
                db.Connect();
                db.cmd = new MySqlCommand("select * from tb_user where user = '" + getUser + "'", db.con);
                db.dr = db.cmd.ExecuteReader();

                if (db.dr.Read())
                {
                    pictureBox1.ImageLocation = db.dr["profile_pic"].ToString();
                }

                db.Disconnect();
            }
            catch (NullReferenceException)
            { }
        }
        public void getCurrentTime()
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:tt");
            lblDate.Text = DateTime.Now.ToString("dd MMMM, yyyy");
            lblTime.Left = (this.plobby.Width - lblTime.Width) / 2;
            lblDate.Left = (this.plobby.Width - lblDate.Width) / 2;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            loadTable();
            lblTot.Text = dataCritical.Rows.Count.ToString();
            dateTimer.Enabled = true;
            dateTimer.Start();
            if (getGender.Equals("Male"))
            {
                lblName.Text = "Mr. " + getLname;
            }
            else
            {
                lblName.Text = "Ms. " + getLname;
            }
            lblName.Left = (this.panel2.Width - lblName.Width) / 2;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logout_Click(object sender, EventArgs e)
        {

            if (Custom_messageBox.Show("Logout this account?") == DialogResult.Yes)
            {
                new Form1().Show();
                this.Hide();
            }
        }

        private void dateTimer_Tick(object sender, EventArgs e)
        {
            getCurrentTime();
        }

     
        public void loadTable()
        {
            
            DataTable dt = new DataTable();
            dt.Columns.Add("Firstname");
            dt.Columns.Add("Lastname");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Course");
            dt.Columns.Add("Student_No.");

            db.Connect();
            
            db.cmd = new MySqlCommand("select * from tb_student where ln Like '%" + txtSearch.Text + "%' OR ln Like '%" + txtSearch.Text + "%'OR gender Like '%" + txtSearch.Text + "%' OR Course like '%" +txtSearch.Text+"%'  OR Student_No like '%"+txtSearch.Text+"%'", db.con);
            db.dr = db.cmd.ExecuteReader();

            while (db.dr.Read())
            {
                dt.Rows.Add(new Object[] 
                { 
                    db.dr["fn"],
                    db.dr["ln"],
                    db.dr["gender"],
                    db.dr["Course"],
                    db.dr["Student_No"],
                });
            }
            dataCritical.DataSource = dt;
            db.Disconnect();
        }
        Manage_Course mc = null;
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadTable();
        }

        private void btnMc_Click(object sender, EventArgs e)
        {
            if (cp != null)
            {
                cp.Hide();
            }
            if (ms != null)
            {
                ms.Hide();
            }
            if(inc!=null)
            {
                inc.Hide();
            }
            if (mc== null)
            {
                mc = new Manage_Course();
                mc.TopLevel = false;
                mc.Parent = this;
                mc.Location = new Point(254, 85);
                mc.Show();
                mc.VisibleChanged += mc_VisibleChanged;
                btnMc.Normalcolor = Color.SeaGreen;
            }

            plobby.Visible = false;
        }
        void mc_VisibleChanged(object sender, EventArgs e)
        {
            btnMc.Normalcolor = Color.FromArgb(37, 122, 114);
            mc = null;
            plobby.Visible = true;
            loadTable();
        }

        Inquire_Students inc = null;
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {


            if (cp != null)
            {
                cp.Hide();
            }
            if (mc != null)
           {
               mc.Hide();
           }
           if (ms != null)
           {
               ms.Hide();
           }
            if (inc == null)
            {
                inc = new  Inquire_Students();
                inc.TopLevel = false;
                inc.Parent = this;
                inc.Location = new Point(254, 85);
                inc.Show();
                inc.VisibleChanged += inc_VisibleChanged;
                btnMc.Normalcolor = Color.SeaGreen;
            }

            plobby.Visible = false;
        }
        void inc_VisibleChanged(object sender, EventArgs e)
        {
            bunifuFlatButton1.Normalcolor = Color.FromArgb(37, 122, 114);
           inc = null;
            plobby.Visible = true;
            loadTable();
        }

        Manage_Student ms  = null;
        private void btnManageStudent_Click(object sender, EventArgs e)
        {
            if (mc != null)
            {
                mc.Hide();
            }
            if(inc != null)
            {
                inc.Hide();
            }
            if (cp != null)
            {
                cp.Hide();
            }
            if (ms == null)
            {
                ms = new Manage_Student();
                ms.TopLevel = false;
                ms.Parent = this;
                ms.Location = new Point(254, 85);
                ms.Show();
                ms.VisibleChanged += ms_VisibleChanged;
                btnMc.Normalcolor = Color.SeaGreen;
            }

            plobby.Visible = false;
        }

        void ms_VisibleChanged(object sender, EventArgs e)
        {
            btnManageStudent.Normalcolor = Color.FromArgb(37, 122, 114);
            ms = null;
            plobby.Visible = true;
            loadTable();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (mc != null)
            {
                mc.Hide();
            }
            if (inc != null)
            {
                inc.Hide();
            }
            if (ms != null)
            {
                ms.Hide();
            }
            if (cp == null)
            {
                cp = new ChangePass(getUser);
                cp.TopLevel = false;
                cp.Parent = this;
                cp.Location = new Point(254, 85);
                cp.Show();
                cp.VisibleChanged += cp_VisibleChanged;
                bunifuFlatButton3.Normalcolor = Color.SeaGreen;
            }

            plobby.Visible = false;
        }
        ChangePass cp = null;
        void cp_VisibleChanged(object sender, EventArgs e)
        {
            bunifuFlatButton3.Normalcolor = Color.FromArgb(37, 122, 114);
            cp = null;
            plobby.Visible = true;
            loadTable();
        }

        Alert msg = null;
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "Backup.sql";
            sfd.Filter = "SQL Files (*.sql)|*.sql";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                db.Connect();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = db.con;
                        mb.ExportToFile(sfd.FileName);

                        if (msg == null)
                        {
                            msg = new Alert("Backup Database success", "Information");
                            msg.Show();
                            msg.FormClosed += msg_FormClosed;
                        }
                    }
                }
                db.Disconnect();
            }
        }
        void msg_FormClosed(object sender, FormClosedEventArgs e)
        {
            msg = null;
            loadTable();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Filter = "SQL Files (*.sql)|*.sql";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                db.Connect();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = db.con;
                        mb.ImportFromFile(ofd.FileName);

                        if (msg == null)
                        {
                            msg = new Alert("Restore Database success", "Information");
                            msg.Show();
                            msg.FormClosed += msg_FormClosed;
                        }
                    }
                }
                db.Disconnect();
            }
            loadTable();
        }
    }
}
