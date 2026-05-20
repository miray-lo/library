namespace liberary
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lvwBooks = new System.Windows.Forms.ListView();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.lstBorrow = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imgL = new System.Windows.Forms.ImageList(this.components);
            this.imgS = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwBooks
            // 
            this.lvwBooks.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvwBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwBooks.HideSelection = false;
            this.lvwBooks.LargeImageList = this.imgL;
            this.lvwBooks.Location = new System.Drawing.Point(0, 0);
            this.lvwBooks.Name = "lvwBooks";
            this.lvwBooks.Size = new System.Drawing.Size(800, 535);
            this.lvwBooks.StateImageList = this.imgS;
            this.lvwBooks.TabIndex = 0;
            this.lvwBooks.UseCompatibleStateImageBehavior = false;
            this.lvwBooks.ItemActivate += new System.EventHandler(this.lvwBooks_ItemActivate);
            this.lvwBooks.SelectedIndexChanged += new System.EventHandler(this.lvwBooks_SelectedIndexChanged);
            // 
            // cmbView
            // 
            this.cmbView.FormattingEnabled = true;
            this.cmbView.Location = new System.Drawing.Point(46, 35);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(121, 20);
            this.cmbView.TabIndex = 1;
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);
            // 
            // lstBorrow
            // 
            this.lstBorrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBorrow.FormattingEnabled = true;
            this.lstBorrow.ItemHeight = 12;
            this.lstBorrow.Location = new System.Drawing.Point(3, 18);
            this.lstBorrow.Name = "lstBorrow";
            this.lstBorrow.Size = new System.Drawing.Size(194, 79);
            this.lstBorrow.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbView);
            this.groupBox1.Location = new System.Drawing.Point(449, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "檢視方式：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstBorrow);
            this.groupBox2.Location = new System.Drawing.Point(449, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "借書清單：";
            // 
            // imgL
            // 
            this.imgL.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgL.ImageStream")));
            this.imgL.TransparentColor = System.Drawing.Color.Transparent;
            this.imgL.Images.SetKeyName(0, "Book1.bmp");
            this.imgL.Images.SetKeyName(1, "Book2.bmp");
            this.imgL.Images.SetKeyName(2, "Book3.bmp");
            this.imgL.Images.SetKeyName(3, "Book4.bmp");
            this.imgL.Images.SetKeyName(4, "Book5.bmp");
            this.imgL.Images.SetKeyName(5, "Book6.bmp");
            this.imgL.Images.SetKeyName(6, "Book7.bmp");
            this.imgL.Images.SetKeyName(7, "Book8.bmp");
            // 
            // imgS
            // 
            this.imgS.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgS.ImageStream")));
            this.imgS.TransparentColor = System.Drawing.Color.Transparent;
            this.imgS.Images.SetKeyName(0, "Book1.bmp");
            this.imgS.Images.SetKeyName(1, "Book2.bmp");
            this.imgS.Images.SetKeyName(2, "Book3.bmp");
            this.imgS.Images.SetKeyName(3, "Book4.bmp");
            this.imgS.Images.SetKeyName(4, "Book5.bmp");
            this.imgS.Images.SetKeyName(5, "Book6.bmp");
            this.imgS.Images.SetKeyName(6, "Book7.bmp");
            this.imgS.Images.SetKeyName(7, "Book8.bmp");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvwBooks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwBooks;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.ListBox lstBorrow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ImageList imgL;
        private System.Windows.Forms.ImageList imgS;
    }
}

