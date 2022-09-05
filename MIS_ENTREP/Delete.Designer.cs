namespace MIS_ENTREP
{
    partial class Delete
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete));
            this.cb_St = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel40 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtfn = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtsno = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtGender = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtc = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.idd = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btr = new BunifuAnimatorNS.BunifuTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_St
            // 
            this.cb_St.BackColor = System.Drawing.Color.Transparent;
            this.cb_St.BorderRadius = 3;
            this.btr.SetDecoration(this.cb_St, BunifuAnimatorNS.DecorationType.None);
            this.cb_St.DisabledColor = System.Drawing.Color.DimGray;
            this.cb_St.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_St.ForeColor = System.Drawing.Color.Gainsboro;
            this.cb_St.Items = new string[] {
        "Choose one"};
            this.cb_St.Location = new System.Drawing.Point(151, 43);
            this.cb_St.Name = "cb_St";
            this.cb_St.NomalColor = System.Drawing.Color.DarkSlateGray;
            this.cb_St.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(80)))), ((int)(((byte)(98)))));
            this.cb_St.selectedIndex = -1;
            this.cb_St.Size = new System.Drawing.Size(370, 40);
            this.cb_St.TabIndex = 122;
            this.cb_St.onItemSelected += new System.EventHandler(this.cb_St_onItemSelected);
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.btr.SetDecoration(this.bunifuCustomLabel13, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(238, 11);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(196, 19);
            this.bunifuCustomLabel13.TabIndex = 124;
            this.bunifuCustomLabel13.Text = "Registered Student No\'s lists";
            // 
            // bunifuCustomLabel40
            // 
            this.bunifuCustomLabel40.AutoSize = true;
            this.bunifuCustomLabel40.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btr.SetDecoration(this.bunifuCustomLabel40, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel40.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel40.Location = new System.Drawing.Point(7, 7);
            this.bunifuCustomLabel40.Name = "bunifuCustomLabel40";
            this.bunifuCustomLabel40.Size = new System.Drawing.Size(86, 19);
            this.bunifuCustomLabel40.TabIndex = 123;
            this.bunifuCustomLabel40.Text = "Delete form";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btr.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(253, 129);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(80, 19);
            this.bunifuCustomLabel1.TabIndex = 125;
            this.bunifuCustomLabel1.Text = "Full name :";
            // 
            // txtfn
            // 
            this.txtfn.AutoSize = true;
            this.txtfn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btr.SetDecoration(this.txtfn, BunifuAnimatorNS.DecorationType.None);
            this.txtfn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtfn.Location = new System.Drawing.Point(345, 129);
            this.txtfn.Name = "txtfn";
            this.txtfn.Size = new System.Drawing.Size(0, 19);
            this.txtfn.TabIndex = 126;
            // 
            // txtsno
            // 
            this.txtsno.AutoSize = true;
            this.txtsno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btr.SetDecoration(this.txtsno, BunifuAnimatorNS.DecorationType.None);
            this.txtsno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsno.Location = new System.Drawing.Point(345, 160);
            this.txtsno.Name = "txtsno";
            this.txtsno.Size = new System.Drawing.Size(0, 19);
            this.txtsno.TabIndex = 128;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btr.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(247, 160);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(86, 19);
            this.bunifuCustomLabel4.TabIndex = 127;
            this.bunifuCustomLabel4.Text = "Student no :";
            // 
            // txtGender
            // 
            this.txtGender.AutoSize = true;
            this.txtGender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btr.SetDecoration(this.txtGender, BunifuAnimatorNS.DecorationType.None);
            this.txtGender.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGender.Location = new System.Drawing.Point(345, 192);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(0, 19);
            this.txtGender.TabIndex = 130;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btr.SetDecoration(this.bunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(269, 192);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(64, 19);
            this.bunifuCustomLabel6.TabIndex = 129;
            this.bunifuCustomLabel6.Text = "Gender :";
            // 
            // txtc
            // 
            this.txtc.AutoSize = true;
            this.txtc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btr.SetDecoration(this.txtc, BunifuAnimatorNS.DecorationType.None);
            this.txtc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtc.Location = new System.Drawing.Point(345, 224);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(0, 19);
            this.txtc.TabIndex = 132;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btr.SetDecoration(this.bunifuCustomLabel8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(271, 224);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(62, 19);
            this.bunifuCustomLabel8.TabIndex = 131;
            this.bunifuCustomLabel8.Text = "Course :";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Close";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btr.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::MIS_ENTREP.Properties.Resources.Delete_96px;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 60D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(221, 274);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(80)))), ((int)(((byte)(98)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(112, 37);
            this.bunifuFlatButton1.TabIndex = 134;
            this.bunifuFlatButton1.Text = "Close";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.btnSave.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 0;
            this.btnSave.ButtonText = "Delete";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btr.SetDecoration(this.btnSave, BunifuAnimatorNS.DecorationType.None);
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = global::MIS_ENTREP.Properties.Resources.icons8_delete_40;
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 60D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(339, 274);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(80)))), ((int)(((byte)(98)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(112, 37);
            this.btnSave.TabIndex = 133;
            this.btnSave.Text = "Delete";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.btr.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::MIS_ENTREP.Properties.Resources.Query_96px1;
            this.pictureBox1.Location = new System.Drawing.Point(54, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 135;
            this.pictureBox1.TabStop = false;
            // 
            // idd
            // 
            this.idd.AutoSize = true;
            this.idd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btr.SetDecoration(this.idd, BunifuAnimatorNS.DecorationType.None);
            this.idd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.idd.Location = new System.Drawing.Point(342, 101);
            this.idd.Name = "idd";
            this.idd.Size = new System.Drawing.Size(0, 19);
            this.idd.TabIndex = 137;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btr.SetDecoration(this.bunifuCustomLabel10, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(302, 101);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(31, 19);
            this.bunifuCustomLabel10.TabIndex = 136;
            this.bunifuCustomLabel10.Text = "ID :";
            // 
            // btr
            // 
            this.btr.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.btr.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.btr.DefaultAnimation = animation2;
            this.btr.Interval = 15;
            this.btr.MaxAnimationTime = 5000;
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.idd);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.txtsno);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.txtfn);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel13);
            this.Controls.Add(this.bunifuCustomLabel40);
            this.Controls.Add(this.cb_St);
            this.btr.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "Delete";
            this.Size = new System.Drawing.Size(672, 563);
            this.Load += new System.EventHandler(this.Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDropdown cb_St;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel40;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel txtfn;
        private Bunifu.Framework.UI.BunifuCustomLabel txtsno;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel txtGender;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel txtc;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel idd;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private BunifuAnimatorNS.BunifuTransition btr;
    }
}
