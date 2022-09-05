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
    public partial class Inquire_Students : Form
    {
        public Inquire_Students()
        {
            InitializeComponent();
        }

        private void Inquire_Students_Load(object sender, EventArgs e)
        {
            cbLevel.selectedIndex = 0;
            cb_course.selectedIndex = 0;
            loadcombo();
            txtsno.MaxLength = 11;
            txtcp.MaxLength = 11;
        }

        Database db = new Database();
        public void loadcombo()
        {

            db.Connect();
            db.cmd = new MySqlCommand("select course from tb_course", db.con);
            db.dr = db.cmd.ExecuteReader();

            while (db.dr.Read())
            {
                String getCourse = db.dr.GetString("course").ToString();
                cb_course.AddItem(getCourse);
            }
            db.Disconnect();


        }

        void Clear()
        {
            txtfn.Clear();
            txtmn.Clear();
            txtln.Clear();
            txtadd.Clear();
            txtsno.Clear();
            txtcp.Clear();
            txtemail.Clear();
            cb_course.selectedIndex = 0;
            cbLevel.selectedIndex = 0;
            lbcourse.Text = "";
            lbdept.Text = "";
            lbdesc.Text = "";
            s1.Text = "";
            s2.Text = "";
            s3.Text = "";
            s4.Text = "";
            s5.Text = "";
            s6.Text = "";
            s7.Text = "";
            s8.Text = "";

        }
        Alert msgAlert = null;
        void msgAlert_FormClosed(object sender, FormClosedEventArgs e)
        {
            msgAlert = null;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
          if(!string.IsNullOrWhiteSpace(txtfn.Text))
          {
              if(!string.IsNullOrWhiteSpace(txtmn.Text))
              {
                  if(!string.IsNullOrWhiteSpace(txtln.Text))
                  {
                      if(!string.IsNullOrWhiteSpace(txtadd.Text))
                      {
                          if(!string.IsNullOrWhiteSpace(txtcp.Text))
                          {
                              if(!string.IsNullOrWhiteSpace(txtemail.Text))
                              {
                                  if(!string.IsNullOrWhiteSpace(txtsno.Text))
                                  {
                                      if (cb_course.selectedIndex != 0)
                                      {
                                          if(cbLevel.selectedIndex!=0)
                                          {
                                              try
                                              {
                                                  if (Custom_messageBox.Show("Save this record?") == DialogResult.Yes)
                                                  {
                                                      if (txtcp.TextLength == 11)
                                                      {
                                                          if(txtsno.TextLength==11)
                                                          {
                                                              String gender;
                                                              String type;
                                                              if (radioButton1.Checked)
                                                              {
                                                                  gender = radioButton1.Text;
                                                              }
                                                              else
                                                              {
                                                                  gender = radioButton2.Text;
                                                              }
                                                              if (radioButton4.Checked)
                                                              {
                                                                  type = radioButton4.Text;
                                                              }
                                                              else
                                                              {
                                                                  type = radioButton3.Text;
                                                              }
                                                              db.Connect();
                                                              db.cmd = new MySqlCommand("insert into tb_student (fn,mn,ln,gender,address,bday,level,type,cell_no,email, Course, Student_No,dept,s1,s2,s3,s4,s5,s6,s7,s8 )values (@fn,@mn,@ln,@gender,@address,@bday,@level,@type,@cell_no,@email, @Course, @Student_No,@dept,@s1,@s2,@s3,@s4,@s5,@s6,@s7,@s8)", db.con);
                                                              db.cmd.Parameters.Add(new MySqlParameter("fn", txtfn.Text));
                                                              db.cmd.Parameters.Add(new MySqlParameter("mn", txtmn.Text));
                                                              db.cmd.Parameters.Add(new MySqlParameter("ln", txtln.Text));
                                                              db.cmd.Parameters.Add(new MySqlParameter("gender", gender));
                                                              db.cmd.Parameters.Add(new MySqlParameter("address", txtadd.Text));
                                                              db.cmd.Parameters.Add(new MySqlParameter("bday", cb_bday.Value.ToString("MMMM dd yyyy")));
                                                              db.cmd.Parameters.Add(new MySqlParameter("level", cbLevel.selectedValue.ToString()));
                                                              db.cmd.Parameters.Add(new MySqlParameter("type", type));
                                                              db.cmd.Parameters.Add(new MySqlParameter("cell_no", txtcp.Text));
                                                              db.cmd.Parameters.Add(new MySqlParameter("email", txtemail.Text));
                                                              db.cmd.Parameters.Add(new MySqlParameter("Course", cb_course.selectedValue.ToString()));
                                                              db.cmd.Parameters.Add(new MySqlParameter("Student_No", txtsno.Text));
                                                              db.cmd.Parameters.Add(new MySqlParameter("dept", lbdept.Text));
                                                              db.cmd.Parameters.Add(new MySqlParameter("s1", s1.Text));
                                                              db.cmd.Parameters.Add(new MySqlParameter("s2", s2.Text));
                                                              db.cmd.Parameters.Add(new MySqlParameter("s3", s3.Text));
                                                              db.cmd.Parameters.Add(new MySqlParameter("s4", s4.Text));
                                                              db.cmd.Parameters.Add(new MySqlParameter("s5", s5.Text));
                                                              db.cmd.Parameters.Add(new MySqlParameter("s6", s6.Text));
                                                              db.cmd.Parameters.Add(new MySqlParameter("s7", s7.Text));
                                                              db.cmd.Parameters.Add(new MySqlParameter("s8", s8.Text));
                                                              db.cmd.ExecuteNonQuery();
                                                              db.Disconnect();
                                                              Clear();
                                                              if (msgAlert == null)
                                                              {
                                                                  msgAlert = new Alert("Successfully Saved!", "Information");
                                                                  msgAlert.Show();
                                                                  msgAlert.FormClosed += msgAlert_FormClosed;
                                                              }
                                                          }
                                                          else
                                                          {
                                                              if (msgAlert == null)
                                                              {
                                                                  msgAlert = new Alert("Student no is Invalid!", "");
                                                                  msgAlert.Show();
                                                                  msgAlert.FormClosed += msgAlert_FormClosed;
                                                              }
                                                          }
                                                      }
                                                      else
                                                      {
                                                          if (msgAlert == null)
                                                          {
                                                              msgAlert = new Alert("Cp no. is Invalid!", "");
                                                              msgAlert.Show();
                                                              msgAlert.FormClosed += msgAlert_FormClosed;
                                                          }
                                                      }
                                                  }
                                              }catch(Exception ex)
                                              {
                                                  if (msgAlert == null)
                                                  {
                                                      msgAlert = new Alert("Student no is already existing!", "");
                                                      msgAlert.Show();
                                                      msgAlert.FormClosed += msgAlert_FormClosed;
                                                  }
                                              }
                                             
                                          }
                                          else
                                          {
                                              if (msgAlert == null)
                                              {
                                                  msgAlert = new Alert("Please Select year level", "");
                                                  msgAlert.Show();
                                                  msgAlert.FormClosed += msgAlert_FormClosed;
                                              }
                                          }
                                      }
                                      else
                                      {
                                          if (msgAlert == null)
                                          {
                                              msgAlert = new Alert("Please select course", "");
                                              msgAlert.Show();
                                              msgAlert.FormClosed += msgAlert_FormClosed;
                                          }
                                      }
                                  }
                                  else
                                  {
                                      if (msgAlert == null)
                                      {
                                          msgAlert = new Alert("Please put Student no", "");
                                          msgAlert.Show();
                                          msgAlert.FormClosed += msgAlert_FormClosed;
                                      }
                                  }
                              }
                              else
                              {
                                  if (msgAlert == null)
                                  {
                                      msgAlert = new Alert("Email address is required", "");
                                      msgAlert.Show();
                                      msgAlert.FormClosed += msgAlert_FormClosed;
                                  }
                              }
                          }
                          else
                          {
                              if (msgAlert == null)
                              {
                                  msgAlert = new Alert("Cellphone no is required", "");
                                  msgAlert.Show();
                                  msgAlert.FormClosed += msgAlert_FormClosed;
                              }
                          }
                      }
                      else
                      {
                          if (msgAlert == null)
                          {
                              msgAlert = new Alert("Put you address", "");
                              msgAlert.Show();
                              msgAlert.FormClosed += msgAlert_FormClosed;
                          }
                      }
                  }
                  else
                  {
                         if (msgAlert == null)  {
                  msgAlert = new Alert("Put your lastname", "");
                  msgAlert.Show();
                  msgAlert.FormClosed += msgAlert_FormClosed;
              }
                  }
              }
              else
              {
                   if (msgAlert == null)
              {
                  msgAlert = new Alert("put your middlename", "");
                  msgAlert.Show();
                  msgAlert.FormClosed += msgAlert_FormClosed;
              }
              }
          }
            else
          {
              if (msgAlert == null)
              {
                  msgAlert = new Alert("Put your firstname", "");
                  msgAlert.Show();
                  msgAlert.FormClosed += msgAlert_FormClosed;
              }
          }
        }


        private void cb_course_onItemSelected(object sender, EventArgs e)
        {
            if (cb_course.selectedIndex == 0)
            {
                lbcourse.Text = "";
                lbdept.Text = "";
                lbdesc.Text = "";
                s1.Text = "";
                s2.Text = "";
                s3.Text = "";
                s4.Text = "";
                s5.Text = "";
                s6.Text = "";
                s7.Text = "";
                s8.Text = "";

            }
            db.Connect();
            db.cmd = new MySqlCommand("select * from tb_course where course='" + cb_course.selectedValue.ToString() + "'", db.con);
            db.dr = db.cmd.ExecuteReader();
            if (db.dr.Read())
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

                lbcourse.Text = course;
                lbdept.Text = dept;
                lbdesc.Text = desc;
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

        private void bunifuCustomLabel40_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtfn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void txtcp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }


    }
}
