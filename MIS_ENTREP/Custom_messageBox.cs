using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS_ENTREP
{
    public partial class Custom_messageBox : Form
    {
        public Custom_messageBox()
        {
            InitializeComponent();
        }
        static Custom_messageBox msgBox; static DialogResult result = DialogResult.No;

        public static DialogResult Show(string text)
        {
            msgBox = new Custom_messageBox();
            msgBox.Message.Text = text;
            msgBox.ShowDialog();
            return result;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes; msgBox.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            result = DialogResult.No; msgBox.Close();
        }
    }
}
