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
using Novacode;
using System.Diagnostics;
using System.IO;

namespace MIS_ENTREP
{
    public partial class View : UserControl
    {
        public View()
        {
            InitializeComponent();
        }

        private void txtfn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void View_Load(object sender, EventArgs e)
        {
            lberoor.Visible = false;
            txtSearch.MaxLength = 11;
        }
         Alert msgAlert = null;
        void msgAlert_FormClosed(object sender, FormClosedEventArgs e)
        {
            msgAlert = null;
        }

        String sb1;
        String sb2;
        String sb3;
        String sb4;
        String sb5;
        String sb6;
        String sb7;
        String sb8;

        Database db = new Database();
        private void btnGo_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
              if(Custom_messageBox.Show("Proceed searching")==DialogResult.Yes)
              {
                  db.Connect();
                  db.cmd = new MySqlCommand("Select * from tb_student where Student_No='"+txtSearch.Text+"'",db.con);
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
                      String Studentno = db.dr.GetString("Student_No").ToString();
                      String lvl = db.dr.GetString("level").ToString();
                      String course = db.dr.GetString("course").ToString();
                      String dept = db.dr.GetString("dept").ToString();
                       sb1 = db.dr.GetString("s1").ToString();
                   sb2 = db.dr.GetString("s2").ToString();
                       sb3 = db.dr.GetString("s3").ToString();
                       sb4 = db.dr.GetString("s4").ToString();
                   sb5 = db.dr.GetString("s5").ToString();
                     sb6 = db.dr.GetString("s6").ToString();
                      sb7 = db.dr.GetString("s7").ToString();
                       sb8 = db.dr.GetString("s8").ToString();

                      lberoor.Visible = false;
                      lbname.Text = fn + " " + mn + " " + ln;
                      lbgender.Text = gender;
                      lbcontact.Text = cellno;
                      lbbdate.Text = bday;
                      lblvl.Text = lvl;
                      lbstudentno.Text = Studentno;
                      lbdept.Text = dept;
                      lbcourse.Text = course;
                      lbaddress.Text = address;

                  }
                  else
                  {
                      if (msgAlert == null)
                      {
                          msgAlert = new Alert("Couldn't find the Student no. ", "");
                          msgAlert.Show();
                          msgAlert.FormClosed += msgAlert_FormClosed;
                      }
                      lberoor.Visible = true;
                      lbaddress.Text = "";
                      lbbdate.Text = "";
                      lbcontact.Text = "";
                      lbcourse.Text = "";
                      lbdept.Text = "";
                      lbgender.Text = "";
                      lblvl.Text = "";
                      lbname.Text = "";
                      lbstudentno.Text = "";
                  }
              }
            }
            else
            {
                if (msgAlert == null)
                {
                    msgAlert = new Alert("Please input Search number", "");
                    msgAlert.Show();
                    msgAlert.FormClosed += msgAlert_FormClosed;
                }
            }
        }
        public void createDoc()
        {
            String fullName = "";
            db.Connect();
            db.cmd = new MySqlCommand("select * from tb_user", db.con);
            db.dr = db.cmd.ExecuteReader();

            if (db.dr.Read())
            {
                fullName = db.dr["fname"].ToString() + " " + db.dr["lname"].ToString();
            }

            db.Disconnect();
            try
            {
                var doc = DocX.Create("temp.docx");

                doc.PageWidth = 556F;
                doc.PageHeight = 340F;
                doc.MarginTop = 16F;
                doc.MarginBottom = 16F;
                doc.MarginLeft = 16F;
                doc.MarginRight = 16F;

                Paragraph title = doc.InsertParagraph("BUDDY SYTEM\n The Simply Best Partner \n").Bold();
                title.Font(new FontFamily("Calibri")).Alignment = Alignment.center;
                title.FontSize(10);

                Table tbInfo = doc.AddTable(4, 5);
                Table insertInfo = doc.InsertTable(tbInfo);

                Table tbInfox = doc.AddTable(5, 5);
                Table insertInfox = doc.InsertTable(tbInfox);

                insertInfo.Rows[0].Cells[0].Paragraphs.First().Append("Name: ").Bold().FontSize(9);
                insertInfo.Rows[0].Cells[1].Paragraphs.First().Append(lbname.Text).FontSize(9);

                insertInfo.Rows[1].Cells[0].Paragraphs.First().Append("Date: ").Bold().FontSize(9);
                insertInfo.Rows[1].Cells[1].Paragraphs.First().Append(DateTime.Now.ToString("MMMM dd, yyyy")).FontSize(9);

                insertInfo.Rows[0].Cells[2].Paragraphs.First().Append("Course :").Bold().FontSize(9);
                insertInfo.Rows[0].Cells[3].Paragraphs.First().Append(lbcourse.Text).FontSize(9);

                insertInfo.Rows[1].Cells[2].Paragraphs.First().Append("Gender :").Bold().FontSize(9);
                insertInfo.Rows[1].Cells[3].Paragraphs.First().Append(lbgender.Text).FontSize(9);

                insertInfo.Rows[2].Cells[0].Paragraphs.First().Append("Student No:").Bold().FontSize(9);
                insertInfo.Rows[2].Cells[1].Paragraphs.First().Append(lbstudentno.Text).FontSize(9);

                insertInfo.Rows[2].Cells[2].Paragraphs.First().Append("Address :").Bold().FontSize(9);
                insertInfo.Rows[2].Cells[3].Paragraphs.First().Append(lbaddress.Text).FontSize(9);

                insertInfo.Rows[3].Cells[0].Paragraphs.First().Append("Contact :").Bold().FontSize(9);
                insertInfo.Rows[3].Cells[1].Paragraphs.First().Append(lbcontact.Text).FontSize(9);

                insertInfo.Design = TableDesign.LightListAccent5;

                doc.InsertParagraph("");
                doc.InsertParagraph("\n");

                tbInfo.Alignment = Alignment.center;
                insertInfo.AutoFit = AutoFit.Contents;
                insertInfo.Alignment = Alignment.center;


              
                insertInfox.Rows[0].Cells[1].Paragraphs.First().Append("SUBJECTS").FontSize(9);

                insertInfox.Rows[1].Cells[0].Paragraphs.First().Append("Subject 1:").Bold().FontSize(9);
                insertInfox.Rows[1].Cells[1].Paragraphs.First().Append(sb1.ToString()).FontSize(9);

                insertInfox.Rows[0].Cells[2].Paragraphs.First().Append("").Bold().FontSize(9);
              

                insertInfox.Rows[1].Cells[2].Paragraphs.First().Append("Subject 5 :").Bold().FontSize(9);
                insertInfox.Rows[1].Cells[3].Paragraphs.First().Append(sb5.ToString()).FontSize(9);

                insertInfox.Rows[2].Cells[0].Paragraphs.First().Append("Subject 2 :").Bold().FontSize(9);
                insertInfox.Rows[2].Cells[1].Paragraphs.First().Append(sb2.ToString()).FontSize(9);

                insertInfox.Rows[2].Cells[2].Paragraphs.First().Append("Subject 6 :").Bold().FontSize(9);
                insertInfox.Rows[2].Cells[3].Paragraphs.First().Append(sb6.ToString()).FontSize(9);


                insertInfox.Rows[3].Cells[0].Paragraphs.First().Append("Subject 3 :").Bold().FontSize(9);
                insertInfox.Rows[3].Cells[1].Paragraphs.First().Append(sb3.ToString()).FontSize(9);

                insertInfox.Rows[4].Cells[0].Paragraphs.First().Append("Subject 4 :").Bold().FontSize(9);
                insertInfox.Rows[4].Cells[1].Paragraphs.First().Append(sb4.ToString()).FontSize(9);

                insertInfox.Rows[4].Cells[2].Paragraphs.First().Append("Subject 8 :").Bold().FontSize(9);
                insertInfox.Rows[4].Cells[3].Paragraphs.First().Append(sb8.ToString()).FontSize(9);

                insertInfox.Rows[3].Cells[2].Paragraphs.First().Append("Subject 7 :").Bold().FontSize(9);
                insertInfox.Rows[3].Cells[3].Paragraphs.First().Append(sb7.ToString()).FontSize(9);






                insertInfox.Design = TableDesign.LightListAccent2;

                doc.InsertParagraph("");

                tbInfox.Alignment = Alignment.center;
                insertInfox.AutoFit = AutoFit.Contents;
                insertInfox.Alignment = Alignment.center;

                doc.InsertParagraph("");

                Table tblInfo1 = doc.AddTable(3, 3);
                Table insertInfo1 = doc.InsertTable(tblInfo1);

                insertInfo1.Rows[0].Cells[0].Paragraphs.First().Append("Issued by :").Bold().FontSize(9).Alignment = Alignment.left;
                insertInfo1.Rows[0].Cells[1].Paragraphs.First().Append(fullName).FontSize(9).Append("\n(BUDDY SYSTEM)").FontSize(9).Bold().Alignment = Alignment.center;
                insertInfo1.Rows[0].Cells[2].Paragraphs.First().Append("Date: ").Bold().FontSize(9).Append("\t" + DateTime.Now.ToString("MMMM dd, yyyy")).FontSize(9).Alignment = Alignment.center;

                insertInfo1.Rows[1].Cells[0].Paragraphs.First().Append("Received by:").Bold().FontSize(9).Alignment = Alignment.left;
                insertInfo1.Rows[1].Cells[1].Paragraphs.First().Append("______________").FontSize(9).Alignment = Alignment.center;

                insertInfo1.Rows[1].Cells[2].Paragraphs.First().Append("Date: ").Bold().FontSize(10).Append("\t" + "______________").FontSize(9).Alignment = Alignment.center;

                insertInfo1.Rows[2].Cells[1].Paragraphs.First().Append("Signature").Bold().FontSize(9).Alignment = Alignment.center;

                insertInfo1.Design = TableDesign.None;

                tblInfo1.Alignment = Alignment.center;
                insertInfo1.AutoFit = AutoFit.Contents;
                insertInfo1.Alignment = Alignment.center;

                doc.InsertParagraph("Sheet No" + "____  ").FontSize(9).Bold().Alignment = Alignment.right;
                doc.Save();

                Process.Start("winword.exe", "temp.docx");
            }
            catch (Exception)
            { }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(lbname.Text))
            {
                if(Custom_messageBox.Show("Generate a word document?")==DialogResult.Yes)
                {
                    if (msgAlert == null)
                    {
                        msgAlert = new Alert("Document Generated", "Information");
                        msgAlert.Show();
                        msgAlert.FormClosed += msgAlert_FormClosed;
                    }
                    createDoc();
                }
            }
            else
            {
                if (msgAlert == null)
                {
                    msgAlert = new Alert("Select Record first", "");
                    msgAlert.Show();
                    msgAlert.FormClosed += msgAlert_FormClosed;
                }
            }
        }
    }
}
