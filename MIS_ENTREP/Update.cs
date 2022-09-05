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
    public partial class Update : UserControl
    {
        public Update()
        {
            InitializeComponent();
        }
        Database db = new Database();
        private void Update_Load(object sender, EventArgs e)
        {
            txtcp.MaxLength = 11;
            txtsno.MaxLength = 11;
            loadcombo2();
            cb_course.selectedIndex = 0;
            cb_lvl.selectedIndex = 0;
            cb_St.selectedIndex = 0;
            cbtype.selectedIndex = 0;
            loadcombo();
            if(cb_St.selectedIndex==0)
            {
                btnSave.Enabled = false;
            }
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

        public void loadcombo2()
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
        
        private void cb_St_onItemSelected(object sender, EventArgs e)
        {
            if(cb_St.selectedIndex==0)
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
                idd.Text = id ;
                txtfn.Text = fn;
                txtmn.Text= mn;
                txtln.Text = ln;
                bdate.Text = bday;   
                txtadd.Text = address;
                txtGender.Text = gender;
                txtcp.Text = cellno;
                txtsno.Text = Studentno;
                txtemail.Text = email;
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
        void Clear()
        {
            cb_St.selectedIndex = 0;
            cbtype.selectedIndex = 0;
            idd.Text = "";
            txtfn.Clear();
            txtmn.Clear();
            txtln.Clear();
            txtadd.Clear();
            txtsno.Clear();
            txtcp.Clear();
            bdate.Text = "";
            txtGender.Text = "";
            txtemail.Clear();
            cb_course.selectedIndex = 0;
            cb_lvl.selectedIndex = 0;
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
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            btr.HideSync(this);
            this.Visible = false;
        }

        private void txtln_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void txtsno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        Alert msgAlert = null;
        void msgAlert_FormClosed(object sender, FormClosedEventArgs e)
        {
            msgAlert = null;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           if (idd.Text!="")
              {
              if (!string.IsNullOrWhiteSpace(txtfn.Text))
              {
                  if (!string.IsNullOrWhiteSpace(txtmn.Text))
                  {
                      if (!string.IsNullOrWhiteSpace(txtln.Text))
                      {
                          if (!string.IsNullOrWhiteSpace(txtadd.Text))
                          {
                              if (!string.IsNullOrWhiteSpace(bdate.Text))
                              {
                                  if (!string.IsNullOrWhiteSpace(txtcp.Text))
                                  {
                                      if (!string.IsNullOrWhiteSpace(txtemail.Text))
                                      {
                                          if (!string.IsNullOrWhiteSpace(txtsno.Text))
                                          {
                                              if (!string.IsNullOrWhiteSpace(txtGender.Text))
                                              {
                                                  if(txtsno.TextLength==11)
                                                  {
                                                      if (txtcp.TextLength == 11)
                                                      {
                                                          if(Custom_messageBox.Show("Save now?")==DialogResult.Yes)
                                                          {
                                                              try
                                                              {
                                                                  db.Connect();
                                                                  db.cmd = new MySqlCommand("update tb_student set fn=@fn, mn=@mn, ln=@ln, gender=@gender, address= @address, bday = @bday, level = @level, type=@type, cell_no = @cell_no, email=@email, Course = @Course, Student_No=@Student_No,dept=@dept , s1=@s1,s2=@s2,s3=@s3,s4=@s4,s5=@s5,s6=@s6,s7=@s7,s8=@s8 where id=@id", db.con);
                                                                  db.cmd.Parameters.Add(new MySqlParameter("id",idd.Text));
                                                                  db.cmd.Parameters.Add(new MySqlParameter("fn", txtfn.Text));
                                                                  db.cmd.Parameters.Add(new MySqlParameter("mn", txtmn.Text));
                                                                  db.cmd.Parameters.Add(new MySqlParameter("ln", txtln.Text));
                                                                  db.cmd.Parameters.Add(new MySqlParameter("gender", txtGender.Text));
                                                                  db.cmd.Parameters.Add(new MySqlParameter("address", txtadd.Text));
                                                                  db.cmd.Parameters.Add(new MySqlParameter("bday", bdate.Text));
                                                                  db.cmd.Parameters.Add(new MySqlParameter("level", cb_lvl.selectedValue.ToString()));
                                                                  db.cmd.Parameters.Add(new MySqlParameter("type", cbtype.selectedValue.ToString()));
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
                                                                      msgAlert = new Alert("Changes has been saved", "Information");
                                                                      msgAlert.Show();
                                                                      msgAlert.FormClosed += msgAlert_FormClosed;
                                                                  }
                                                              }
                                                              catch(Exception ex)
                                                              {
                                                                  if (msgAlert == null)
                                                                  {
                                                                      msgAlert = new Alert("Student no. is already existing", "");
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
                                                              msgAlert = new Alert("Invalid Cell no", "");
                                                              msgAlert.Show();
                                                              msgAlert.FormClosed += msgAlert_FormClosed;
                                                          }
                                                      }
                                                  }
                                                  else
                                                  {
                                                      if (msgAlert == null)
                                                      {
                                                          msgAlert = new Alert("Invalid Student no", "");
                                                          msgAlert.Show();
                                                          msgAlert.FormClosed += msgAlert_FormClosed;
                                                      }
                                                  }
                                              }
                                              else
                                              {
                                                  if (msgAlert == null)
                                                  {
                                                      msgAlert = new Alert("Put  Gender", "");
                                                      msgAlert.Show();
                                                      msgAlert.FormClosed += msgAlert_FormClosed;
                                                  }
                                              }
                                          }
                                          else
                                          {
                                              if (msgAlert == null)
                                              {
                                                  msgAlert = new Alert("Put Student no.", "");
                                                  msgAlert.Show();
                                                  msgAlert.FormClosed += msgAlert_FormClosed;
                                              }
                                          }
                                      }
                                      else
                                      {
                                          if (msgAlert == null)
                                          {
                                              msgAlert = new Alert("Put email address", "");
                                              msgAlert.Show();
                                              msgAlert.FormClosed += msgAlert_FormClosed;
                                          }
                                      }
                                  }
                                  else
                                  {
                                      if (msgAlert == null)
                                      {
                                          msgAlert = new Alert("Put Cell no.", "");
                                          msgAlert.Show();
                                          msgAlert.FormClosed += msgAlert_FormClosed;
                                      }
                                  }
                              }
                              else
                              {
                                  if (msgAlert == null)
                                  {
                                      msgAlert = new Alert("Put valid birthdate", "");
                                      msgAlert.Show();
                                      msgAlert.FormClosed += msgAlert_FormClosed;
                                  }
                              }
                          }
                          else
                          {
                              if (msgAlert == null)
                              {
                                  msgAlert = new Alert("Put address", "");
                                  msgAlert.Show();
                                  msgAlert.FormClosed += msgAlert_FormClosed;
                              }
                          }
                      }
                      else
                      {
                          if (msgAlert == null)
                          {
                              msgAlert = new Alert("Put lastname", "");
                              msgAlert.Show();
                              msgAlert.FormClosed += msgAlert_FormClosed;
                          }
                      }
                  }
                  else
                  {
                      if (msgAlert == null)
                      {
                          msgAlert = new Alert("Put middlename", "");
                          msgAlert.Show();
                          msgAlert.FormClosed += msgAlert_FormClosed;
                      }
                  }

              }
              else
              {
                  if (msgAlert == null)
                  {
                      msgAlert = new Alert("Put firstname", "");
                      msgAlert.Show();
                      msgAlert.FormClosed += msgAlert_FormClosed;
                  }
              }
              }
           else
           {
               if (msgAlert == null)
               {
                   msgAlert = new Alert("No selected record", "");
                   msgAlert.Show();
                   msgAlert.FormClosed += msgAlert_FormClosed;
               }
           }
        }
    }
}
