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
    public partial class Manage_Course : Form
    {
        Database db = new Database();
        public Manage_Course()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel18_Click(object sender, EventArgs e)
        {
            btnEdit.Visible = true;
            cb_course.Visible = true;
            bunifuCustomLabel17.Visible = true;
            btnRem.Visible = true;
        }

        private void bunifuCustomLabel19_Click(object sender, EventArgs e)
        {
            
        }

        public void loadcombo()
        {
            
            db.Connect();
            db.cmd = new MySqlCommand("select course from tb_course",db.con);
            db.dr = db.cmd.ExecuteReader();

            while (db.dr.Read())
            {
               String getCourse = db.dr.GetString("course").ToString();
                cb_course.AddItem(getCourse);       
            }
            db.Disconnect();
           
         
        }
        private void Manage_Course_Load(object sender, EventArgs e)
        {
            loadcombo();
            cb_course.selectedIndex = 0;
        }
        Alert msgAlert = null;
        void msgAlert_FormClosed(object sender, FormClosedEventArgs e)
        {
            msgAlert = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtcourse.Text))
            {
                if(!string.IsNullOrWhiteSpace(txtdept.Text))
                {
                    if(!string.IsNullOrWhiteSpace(txtdesc.Text))
                    {
                        if(Custom_messageBox.Show("Add this now?")==DialogResult.Yes)
                        {
                            try
                            {
                                db.Connect();
                                db.cmd = new MySqlCommand("insert into tb_course(course,dept,description,s1,s2,s3,s4,s5,s6,s7,s8)values(@course,@dept,@description,@s1,@s2,@s3,@s4,@s5,@s6,@s7,@s8)", db.con);
                                db.cmd.Parameters.Add(new MySqlParameter("course", txtcourse.Text));
                                db.cmd.Parameters.Add(new MySqlParameter("dept", txtdept.Text));
                                db.cmd.Parameters.Add(new MySqlParameter("description", txtdesc.Text));
                                db.cmd.Parameters.Add(new MySqlParameter("s1", s1.Text));
                                db.cmd.Parameters.Add(new MySqlParameter("s2", s2.Text));
                                db.cmd.Parameters.Add(new MySqlParameter("s3", s3.Text));
                                db.cmd.Parameters.Add(new MySqlParameter("s4", s4.Text));
                                db.cmd.Parameters.Add(new MySqlParameter("s5", s5.Text));
                                db.cmd.Parameters.Add(new MySqlParameter("s6", s6.Text));
                                db.cmd.Parameters.Add(new MySqlParameter("s7", s7.Text));
                                db.cmd.Parameters.Add(new MySqlParameter("s8", s8.Text));
                                db.cmd.ExecuteNonQuery();

                                txtcourse.Clear();
                                txtdept.Clear();
                                txtdesc.Clear();
                                s1.Clear();
                                s2.Clear();
                                s3.Clear();
                                s4.Clear();
                                s5.Clear();
                                s6.Clear();
                                s7.Clear();
                                s8.Clear();
                                if (msgAlert == null)
                                {
                                    msgAlert = new Alert("Successfully Added!", "Information");
                                    msgAlert.Show();
                                    msgAlert.FormClosed += msgAlert_FormClosed;
                                }
                                this.Hide();
                            }
                            catch (Exception xe)
                            {
                                if (msgAlert == null)
                                {
                                    msgAlert = new Alert("Course name is already existing", "");
                                    msgAlert.Show();
                                    msgAlert.FormClosed += msgAlert_FormClosed;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (msgAlert == null)
                        {
                            msgAlert = new Alert("Please Provide Course description", "");
                            msgAlert.Show();
                            msgAlert.FormClosed += msgAlert_FormClosed;
                        }
                    }
                }
                else
                {
                    if (msgAlert == null)
                    {
                        msgAlert = new Alert("Please Provide Dept", "");
                        msgAlert.Show();
                        msgAlert.FormClosed += msgAlert_FormClosed;
                    }
                }
            }
            else{
                if (msgAlert == null)
                {
                    msgAlert = new Alert("Please Provide Course name", "");
                    msgAlert.Show();
                    msgAlert.FormClosed += msgAlert_FormClosed;
                }
            }
        }

        private void cb_course_onItemSelected(object sender, EventArgs e)
        {
            
            if (cb_course.selectedIndex == 0)
            {
                txtcourse.Clear();
                txtdept.Clear();
                txtdesc.Clear();
                s1.Clear();
                s2.Clear();
                s3.Clear();
                s4.Clear();
                s5.Clear();
                s6.Clear();
                s7.Clear();
                s8.Clear();

            }
            db.Connect();
            db.cmd = new MySqlCommand("select * from tb_course where course='"+cb_course.selectedValue.ToString()+"'",db.con);
            db.dr = db.cmd.ExecuteReader();
            if(db.dr.Read())
            {
                String course = db.dr.GetString("course").ToString();
                String dept = db.dr.GetString("dept").ToString();
                String desc = db.dr.GetString("description").ToString();
                String sb1 = db.dr.GetString("s1").ToString();
                String sb2 = db.dr.GetString("s2").ToString();
                String sb3 = db.dr.GetString("s3").ToString();
                String sb4 = db.dr.GetString("s4").ToString();
                String sb5 = db.dr.GetString("s5").ToString();
                String sb6 = db.dr.GetString("s6").ToString();
                String sb7 = db.dr.GetString("s7").ToString();
                String sb8 = db.dr.GetString("s8").ToString();

                txtcourse.Text = course;
                txtdept.Text = dept;
                txtdesc.Text = desc;
                s1.Text = sb1;
                s2.Text = sb2;
                s3.Text = sb3;
                s4.Text = sb4;
                s5.Text = sb5;
                s6.Text = sb6;
                s7.Text = sb7;
                s8.Text = sb8;
            }
        }

        void clear()
        {
            txtcourse.Clear();
            txtdept.Clear();
            txtdesc.Clear();
            s1.Clear();
            s2.Clear();
            s3.Clear();
            s4.Clear();
            s5.Clear();
            s6.Clear();
            s7.Clear();
            s8.Clear();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(cb_course.selectedIndex==0)
            {
                if (msgAlert == null)
                {
                    msgAlert = new Alert("Please choose a course to update", "");
                    msgAlert.Show();
                    msgAlert.FormClosed += msgAlert_FormClosed;
                }
            }
            else
            {

            if(!string.IsNullOrWhiteSpace(txtcourse.Text))
            {
                if(!string.IsNullOrWhiteSpace(txtdept.Text))
                {
                    if(!string.IsNullOrWhiteSpace(txtdesc.Text))
                    {
                        if (Custom_messageBox.Show("Saved changes now?") == DialogResult.Yes)
                        {
                            try
                            {
                                db.Connect();
                                db.cmd = new MySqlCommand("update tb_course set course=@course, dept=@dept, description = @description,s1=@s1,s2=@s2,s3=@s3,s4=@s4,s5=@s5,s6=@s6,s7=@s7,s8=@s8 where course = '" + cb_course.selectedValue.ToString() + "'", db.con);
                                db.cmd.Parameters.Add(new MySqlParameter("course", txtcourse.Text));
                                db.cmd.Parameters.Add(new MySqlParameter("dept", txtdept.Text));
                                db.cmd.Parameters.Add(new MySqlParameter("description", txtdesc.Text));
                                db.cmd.Parameters.Add(new MySqlParameter("s1", s1.Text));
                                db.cmd.Parameters.Add(new MySqlParameter("s2", s2.Text));
                                db.cmd.Parameters.Add(new MySqlParameter("s3", s3.Text));
                                db.cmd.Parameters.Add(new MySqlParameter("s4", s4.Text));
                                db.cmd.Parameters.Add(new MySqlParameter("s5", s5.Text));
                                db.cmd.Parameters.Add(new MySqlParameter("s6", s6.Text));
                                db.cmd.Parameters.Add(new MySqlParameter("s7", s7.Text));
                                db.cmd.Parameters.Add(new MySqlParameter("s8", s8.Text));
                                db.cmd.ExecuteNonQuery();
                                cb_course.selectedIndex = 0;
                                clear();
                                btnEdit.Visible = false;
                                bunifuCustomLabel17.Visible = false;
                                btnRem.Visible = false;

                                if (msgAlert == null)
                                {
                                    msgAlert = new Alert("Successfully updated!", "Information");
                                    msgAlert.Show();
                                    msgAlert.FormClosed += msgAlert_FormClosed;
                                }
                                db.Disconnect();
                                this.Hide();
                            }
                            catch (Exception ex)
                            {
                                if (msgAlert == null)
                                {
                                    msgAlert = new Alert("Course name is already existing!", "");
                                    msgAlert.Show();
                                    msgAlert.FormClosed += msgAlert_FormClosed;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (msgAlert == null)
                        {
                            msgAlert = new Alert("Please provide description!", "");
                            msgAlert.Show();
                            msgAlert.FormClosed += msgAlert_FormClosed;
                        }
                    }
                }
                else
                {
                      if (msgAlert == null)
                        {
                            msgAlert = new Alert("Please provide department", "");
                            msgAlert.Show();
                            msgAlert.FormClosed += msgAlert_FormClosed;
                        }
                }
            }
            else
            {
                if (msgAlert == null)
                {
                    msgAlert = new Alert("Please provide Course name", "");
                    msgAlert.Show();
                    msgAlert.FormClosed += msgAlert_FormClosed;
                }
            }
          }
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            if(cb_course.selectedIndex==0)
            {
                if (msgAlert == null)
                {
                    msgAlert = new Alert("No course selected", "");
                    msgAlert.Show();
                    msgAlert.FormClosed += msgAlert_FormClosed;
                }
            }
            else
            {
                if(Custom_messageBox.Show("Remove this now?")==DialogResult.Yes)
                {
                    db.Connect();
                    db.cmd = new MySqlCommand("delete from tb_course where course='" + cb_course.selectedValue.ToString() + "'", db.con);
                    db.cmd.ExecuteNonQuery();
                    this.Hide();
                    if (msgAlert == null)
                    {
                        msgAlert = new Alert("Successfully removed!", "Information");
                        msgAlert.Show();
                        msgAlert.FormClosed += msgAlert_FormClosed;
                    }
                }
            }
        }

        private void bunifuCustomLabel19_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuCustomLabel19_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Go Back",bunifuCustomLabel19);
        }
    }
}
