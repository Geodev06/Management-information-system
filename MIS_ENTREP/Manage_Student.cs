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
    public partial class Manage_Student : Form
    {
        public Manage_Student()
        {
            InitializeComponent();
        }
        Database db = new Database();
        private void bunifuCustomLabel40_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
        private void btnManageStudent_Click(object sender, EventArgs e)
        {
            view1.Visible = false;
            delete1.Visible = false;
            btr.ShowSync(update1);
            btr.HideSync(delete1);
            btr.HideSync(view1);
            update1.Visible = true;
        }

        private void update1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            view1.Visible = false;
            update1.Visible = false;
            btr.ShowSync(delete1);
            btr.HideSync(view1);
            btr.HideSync(update1);
            delete1.Visible = true;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            btr.HideSync(delete1);
            btr.HideSync(update1);
            btr.ShowSync(view1);
            view1.Visible = true;
            update1.Visible = false;
            delete1.Visible = false;
        }
    }
}
