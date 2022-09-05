using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace MIS_ENTREP
{
    public partial class Delete : UserControl
    {
        Database db = new Database();
        public Delete()
        {
            InitializeComponent();
        }

        private void cb_St_onItemSelected(object sender, EventArgs e)
        {
            if (cb_St.selectedIndex == 0)
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
            db.Connect();
            db.cmd = new MySqlCommand("select * from tb_student where Student_No='" + cb_St.selectedValue.ToString() + "'", db.con);
            db.dr = db.cmd.ExecuteReader();
            if (db.dr.Read())
            {

                String cc = db.dr.GetString("Course").ToString();
                String fn = db.dr.GetString("fn").ToString();
                String mn = db.dr.GetString("mn").ToString();
                String ln = db.dr.GetString("ln").ToString();
                String gender = db.dr.GetString("gender").ToString();
                String address = db.dr.GetString("address").ToString();
                String bday = db.dr.GetString("bday").ToString();
                String cellno = db.dr.GetString("cell_no").ToString();
                String email = db.dr.GetString("email").ToString();
                String Studentno = db.dr.GetString("Student_No").ToString();
                String id = db.dr.GetString("id").ToString();
                idd.Text = id;
                txtc.Text = cc;
                txtfn.Text = fn + " " + mn + " " + ln + " ";
                txtGender.Text = gender;
                txtsno.Text = Studentno;
            }
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            loadcombo();
        }
        public void loadcombo()
        {

            db.Connect();
            db.cmd = new MySqlCommand("select Student_No from tb_student", db.con);
            db.dr = db.cmd.ExecuteReader();

            while (db.dr.Read())
            {
                String getCourse = db.dr.GetString("Student_No").ToString();
                cb_St.AddItem(getCourse);
            }
            db.Disconnect();


        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            btr.HideSync(this);
            this.Visible = false;
        }
        Alert msgAlert = null;
        void msgAlert_FormClosed(object sender, FormClosedEventArgs e)
        {
            msgAlert = null;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(idd.Text=="")
            {
                if (msgAlert == null)
                {
                    msgAlert = new Alert("No selected record to delete", "");
                    msgAlert.Show();
                    msgAlert.FormClosed += msgAlert_FormClosed;
                }
            }
            else
            {

                if (cb_St.selectedIndex == 0)
                {
                    btnSave.Enabled = false;
                }
                else
                {
                    if(Custom_messageBox.Show("Delete this?")==DialogResult.Yes)
                    {
                        db.Connect();
                        db.cmd = new MySqlCommand("delete from tb_student where id=@id", db.con);
                        db.cmd.Parameters.Add(new MySqlParameter("id", idd.Text));
                        db.cmd.ExecuteNonQuery();
                        db.Disconnect();
                        if (msgAlert == null)
                        {
                            msgAlert = new Alert("Successfully deleted", "Information");
                            msgAlert.Show();
                            msgAlert.FormClosed += msgAlert_FormClosed;
                        }
                        this.Dispose();
                        idd.Text = "";
                        cb_St.selectedIndex = 0;
                        txtc.Text = "";
                        txtfn.Text = "";
                        txtsno.Text = "";
                        txtGender.Text = "";
                    }
                }
            }
        }
    }
}
