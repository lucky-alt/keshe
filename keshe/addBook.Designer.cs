﻿
namespace keshe
{
    partial class 添加图书
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labBookID = new System.Windows.Forms.Label();
            this.labBookName = new System.Windows.Forms.Label();
            this.labBookAuthor = new System.Windows.Forms.Label();
            this.labBookPress = new System.Windows.Forms.Label();
            this.labPressDate = new System.Windows.Forms.Label();
            this.txtBBookID = new System.Windows.Forms.TextBox();
            this.txtBBookName = new System.Windows.Forms.TextBox();
            this.txtBBookAuthor = new System.Windows.Forms.TextBox();
            this.txtBBookPress = new System.Windows.Forms.TextBox();
            this.labISBN = new System.Windows.Forms.Label();
            this.txtBISBN = new System.Windows.Forms.TextBox();
            this.labDeptName = new System.Windows.Forms.Label();
            this.labLanguage = new System.Windows.Forms.Label();
            this.labBookPageNum = new System.Windows.Forms.Label();
            this.labBookPrice = new System.Windows.Forms.Label();
            this.txtBBookPageNum = new System.Windows.Forms.TextBox();
            this.txtBBookPrice = new System.Windows.Forms.TextBox();
            this.labAddDate = new System.Windows.Forms.Label();
            this.labBookQty = new System.Windows.Forms.Label();
            this.txtBBookQty = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dTPPressDate = new System.Windows.Forms.DateTimePicker();
            this.dTPAddDate = new System.Windows.Forms.DateTimePicker();
            this.cbBLanguage = new System.Windows.Forms.ComboBox();
            this.cbBDeptName = new System.Windows.Forms.ComboBox();
            this.txtBBookOrder = new System.Windows.Forms.TextBox();
            this.labBookOrder = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picBBookPicture = new System.Windows.Forms.PictureBox();
            this.labDetailsIntro = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBBookPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // labBookID
            // 
            this.labBookID.AutoSize = true;
            this.labBookID.Location = new System.Drawing.Point(24, 38);
            this.labBookID.Name = "labBookID";
            this.labBookID.Size = new System.Drawing.Size(82, 15);
            this.labBookID.TabIndex = 0;
            this.labBookID.Text = "图书编号：";
            this.labBookID.Click += new System.EventHandler(this.label1_Click);
            // 
            // labBookName
            // 
            this.labBookName.AutoSize = true;
            this.labBookName.Location = new System.Drawing.Point(24, 81);
            this.labBookName.Name = "labBookName";
            this.labBookName.Size = new System.Drawing.Size(82, 15);
            this.labBookName.TabIndex = 0;
            this.labBookName.Text = "图书名称：";
            this.labBookName.Click += new System.EventHandler(this.label1_Click);
            // 
            // labBookAuthor
            // 
            this.labBookAuthor.AutoSize = true;
            this.labBookAuthor.Location = new System.Drawing.Point(24, 126);
            this.labBookAuthor.Name = "labBookAuthor";
            this.labBookAuthor.Size = new System.Drawing.Size(82, 15);
            this.labBookAuthor.TabIndex = 0;
            this.labBookAuthor.Text = "图书作者：";
            this.labBookAuthor.Click += new System.EventHandler(this.label1_Click);
            // 
            // labBookPress
            // 
            this.labBookPress.AutoSize = true;
            this.labBookPress.Location = new System.Drawing.Point(24, 172);
            this.labBookPress.Name = "labBookPress";
            this.labBookPress.Size = new System.Drawing.Size(82, 15);
            this.labBookPress.TabIndex = 0;
            this.labBookPress.Text = "出版社名：";
            this.labBookPress.Click += new System.EventHandler(this.label1_Click);
            // 
            // labPressDate
            // 
            this.labPressDate.AutoSize = true;
            this.labPressDate.Location = new System.Drawing.Point(24, 213);
            this.labPressDate.Name = "labPressDate";
            this.labPressDate.Size = new System.Drawing.Size(82, 15);
            this.labPressDate.TabIndex = 0;
            this.labPressDate.Text = "出版日期：";
            this.labPressDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBBookID
            // 
            this.txtBBookID.Location = new System.Drawing.Point(112, 35);
            this.txtBBookID.Name = "txtBBookID";
            this.txtBBookID.Size = new System.Drawing.Size(184, 25);
            this.txtBBookID.TabIndex = 1;
            // 
            // txtBBookName
            // 
            this.txtBBookName.Location = new System.Drawing.Point(112, 78);
            this.txtBBookName.Name = "txtBBookName";
            this.txtBBookName.Size = new System.Drawing.Size(184, 25);
            this.txtBBookName.TabIndex = 1;
            this.txtBBookName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtBBookAuthor
            // 
            this.txtBBookAuthor.Location = new System.Drawing.Point(112, 123);
            this.txtBBookAuthor.Name = "txtBBookAuthor";
            this.txtBBookAuthor.Size = new System.Drawing.Size(184, 25);
            this.txtBBookAuthor.TabIndex = 1;
            // 
            // txtBBookPress
            // 
            this.txtBBookPress.Location = new System.Drawing.Point(112, 169);
            this.txtBBookPress.Name = "txtBBookPress";
            this.txtBBookPress.Size = new System.Drawing.Size(184, 25);
            this.txtBBookPress.TabIndex = 1;
            // 
            // labISBN
            // 
            this.labISBN.AutoSize = true;
            this.labISBN.Location = new System.Drawing.Point(24, 258);
            this.labISBN.Name = "labISBN";
            this.labISBN.Size = new System.Drawing.Size(84, 15);
            this.labISBN.TabIndex = 0;
            this.labISBN.Text = "标准ISBN：";
            this.labISBN.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBISBN
            // 
            this.txtBISBN.Location = new System.Drawing.Point(112, 255);
            this.txtBISBN.Name = "txtBISBN";
            this.txtBISBN.Size = new System.Drawing.Size(184, 25);
            this.txtBISBN.TabIndex = 1;
            // 
            // labDeptName
            // 
            this.labDeptName.AutoSize = true;
            this.labDeptName.Location = new System.Drawing.Point(24, 302);
            this.labDeptName.Name = "labDeptName";
            this.labDeptName.Size = new System.Drawing.Size(82, 15);
            this.labDeptName.TabIndex = 0;
            this.labDeptName.Text = "分类名称：";
            this.labDeptName.Click += new System.EventHandler(this.label1_Click);
            // 
            // labLanguage
            // 
            this.labLanguage.AutoSize = true;
            this.labLanguage.Location = new System.Drawing.Point(24, 349);
            this.labLanguage.Name = "labLanguage";
            this.labLanguage.Size = new System.Drawing.Size(82, 15);
            this.labLanguage.TabIndex = 0;
            this.labLanguage.Text = "所属语种：";
            this.labLanguage.Click += new System.EventHandler(this.label1_Click);
            // 
            // labBookPageNum
            // 
            this.labBookPageNum.AutoSize = true;
            this.labBookPageNum.Location = new System.Drawing.Point(24, 394);
            this.labBookPageNum.Name = "labBookPageNum";
            this.labBookPageNum.Size = new System.Drawing.Size(82, 15);
            this.labBookPageNum.TabIndex = 0;
            this.labBookPageNum.Text = "图书页数：";
            this.labBookPageNum.Click += new System.EventHandler(this.label1_Click);
            // 
            // labBookPrice
            // 
            this.labBookPrice.AutoSize = true;
            this.labBookPrice.Location = new System.Drawing.Point(24, 440);
            this.labBookPrice.Name = "labBookPrice";
            this.labBookPrice.Size = new System.Drawing.Size(82, 15);
            this.labBookPrice.TabIndex = 0;
            this.labBookPrice.Text = "图书价格：";
            this.labBookPrice.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBBookPageNum
            // 
            this.txtBBookPageNum.Location = new System.Drawing.Point(112, 391);
            this.txtBBookPageNum.Name = "txtBBookPageNum";
            this.txtBBookPageNum.Size = new System.Drawing.Size(184, 25);
            this.txtBBookPageNum.TabIndex = 1;
            // 
            // txtBBookPrice
            // 
            this.txtBBookPrice.Location = new System.Drawing.Point(112, 437);
            this.txtBBookPrice.Name = "txtBBookPrice";
            this.txtBBookPrice.Size = new System.Drawing.Size(184, 25);
            this.txtBBookPrice.TabIndex = 1;
            // 
            // labAddDate
            // 
            this.labAddDate.AutoSize = true;
            this.labAddDate.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAddDate.Location = new System.Drawing.Point(26, 491);
            this.labAddDate.Name = "labAddDate";
            this.labAddDate.Size = new System.Drawing.Size(82, 15);
            this.labAddDate.TabIndex = 0;
            this.labAddDate.Text = "入馆日期：";
            this.labAddDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // labBookQty
            // 
            this.labBookQty.AutoSize = true;
            this.labBookQty.Location = new System.Drawing.Point(24, 545);
            this.labBookQty.Name = "labBookQty";
            this.labBookQty.Size = new System.Drawing.Size(82, 15);
            this.labBookQty.TabIndex = 0;
            this.labBookQty.Text = "图书本数：";
            this.labBookQty.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBBookQty
            // 
            this.txtBBookQty.Location = new System.Drawing.Point(114, 542);
            this.txtBBookQty.Name = "txtBBookQty";
            this.txtBBookQty.Size = new System.Drawing.Size(182, 25);
            this.txtBBookQty.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dTPPressDate);
            this.groupBox1.Controls.Add(this.dTPAddDate);
            this.groupBox1.Controls.Add(this.cbBLanguage);
            this.groupBox1.Controls.Add(this.cbBDeptName);
            this.groupBox1.Controls.Add(this.txtBBookOrder);
            this.groupBox1.Controls.Add(this.labBookOrder);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.picBBookPicture);
            this.groupBox1.Controls.Add(this.labDetailsIntro);
            this.groupBox1.Controls.Add(this.labBookID);
            this.groupBox1.Controls.Add(this.txtBBookQty);
            this.groupBox1.Controls.Add(this.txtBBookID);
            this.groupBox1.Controls.Add(this.labBookQty);
            this.groupBox1.Controls.Add(this.labBookName);
            this.groupBox1.Controls.Add(this.txtBBookPrice);
            this.groupBox1.Controls.Add(this.labAddDate);
            this.groupBox1.Controls.Add(this.labBookAuthor);
            this.groupBox1.Controls.Add(this.txtBBookPageNum);
            this.groupBox1.Controls.Add(this.txtBBookName);
            this.groupBox1.Controls.Add(this.labBookPrice);
            this.groupBox1.Controls.Add(this.txtBBookAuthor);
            this.groupBox1.Controls.Add(this.labBookPageNum);
            this.groupBox1.Controls.Add(this.labBookPress);
            this.groupBox1.Controls.Add(this.labDeptName);
            this.groupBox1.Controls.Add(this.txtBISBN);
            this.groupBox1.Controls.Add(this.labLanguage);
            this.groupBox1.Controls.Add(this.txtBBookPress);
            this.groupBox1.Controls.Add(this.labPressDate);
            this.groupBox1.Controls.Add(this.labISBN);
            this.groupBox1.Location = new System.Drawing.Point(25, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1108, 579);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图书明细";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(373, 78);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 428);
            this.textBox1.TabIndex = 9;
            // 
            // dTPPressDate
            // 
            this.dTPPressDate.Location = new System.Drawing.Point(112, 206);
            this.dTPPressDate.Name = "dTPPressDate";
            this.dTPPressDate.Size = new System.Drawing.Size(182, 25);
            this.dTPPressDate.TabIndex = 8;
            this.dTPPressDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dTPAddDate
            // 
            this.dTPAddDate.Location = new System.Drawing.Point(114, 484);
            this.dTPAddDate.Name = "dTPAddDate";
            this.dTPAddDate.Size = new System.Drawing.Size(182, 25);
            this.dTPAddDate.TabIndex = 8;
            this.dTPAddDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cbBLanguage
            // 
            this.cbBLanguage.FormattingEnabled = true;
            this.cbBLanguage.Location = new System.Drawing.Point(112, 346);
            this.cbBLanguage.Name = "cbBLanguage";
            this.cbBLanguage.Size = new System.Drawing.Size(182, 23);
            this.cbBLanguage.TabIndex = 7;
            // 
            // cbBDeptName
            // 
            this.cbBDeptName.FormattingEnabled = true;
            this.cbBDeptName.Location = new System.Drawing.Point(112, 299);
            this.cbBDeptName.Name = "cbBDeptName";
            this.cbBDeptName.Size = new System.Drawing.Size(182, 23);
            this.cbBDeptName.TabIndex = 7;
            // 
            // txtBBookOrder
            // 
            this.txtBBookOrder.Location = new System.Drawing.Point(508, 542);
            this.txtBBookOrder.Name = "txtBBookOrder";
            this.txtBBookOrder.Size = new System.Drawing.Size(190, 25);
            this.txtBBookOrder.TabIndex = 6;
            // 
            // labBookOrder
            // 
            this.labBookOrder.AutoSize = true;
            this.labBookOrder.Location = new System.Drawing.Point(370, 544);
            this.labBookOrder.Name = "labBookOrder";
            this.labBookOrder.Size = new System.Drawing.Size(112, 15);
            this.labBookOrder.TabIndex = 5;
            this.labBookOrder.Text = "图书起始序号：";
            this.labBookOrder.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(965, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "上载图片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(769, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "图书封面：";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // picBBookPicture
            // 
            this.picBBookPicture.Location = new System.Drawing.Point(772, 74);
            this.picBBookPicture.Name = "picBBookPicture";
            this.picBBookPicture.Size = new System.Drawing.Size(330, 432);
            this.picBBookPicture.TabIndex = 3;
            this.picBBookPicture.TabStop = false;
            // 
            // labDetailsIntro
            // 
            this.labDetailsIntro.AutoSize = true;
            this.labDetailsIntro.Location = new System.Drawing.Point(367, 37);
            this.labDetailsIntro.Name = "labDetailsIntro";
            this.labDetailsIntro.Size = new System.Drawing.Size(82, 15);
            this.labDetailsIntro.TabIndex = 2;
            this.labDetailsIntro.Text = "内容简介：";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(54, 630);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(228, 630);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 34);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // 添加图书
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 676);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "添加图书";
            this.Text = "添加图书";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBBookPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labBookID;
        private System.Windows.Forms.Label labBookName;
        private System.Windows.Forms.Label labBookAuthor;
        private System.Windows.Forms.Label labBookPress;
        private System.Windows.Forms.Label labPressDate;
        private System.Windows.Forms.TextBox txtBBookID;
        private System.Windows.Forms.TextBox txtBBookName;
        private System.Windows.Forms.TextBox txtBBookAuthor;
        private System.Windows.Forms.TextBox txtBBookPress;
        private System.Windows.Forms.Label labISBN;
        private System.Windows.Forms.TextBox txtBISBN;
        private System.Windows.Forms.Label labDeptName;
        private System.Windows.Forms.Label labLanguage;
        private System.Windows.Forms.Label labBookPageNum;
        private System.Windows.Forms.Label labBookPrice;
        private System.Windows.Forms.TextBox txtBBookPageNum;
        private System.Windows.Forms.TextBox txtBBookPrice;
        private System.Windows.Forms.Label labAddDate;
        private System.Windows.Forms.Label labBookQty;
        private System.Windows.Forms.TextBox txtBBookQty;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labDetailsIntro;
        private System.Windows.Forms.PictureBox picBBookPicture;
        private System.Windows.Forms.Label labBookOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBBookOrder;
        private System.Windows.Forms.DateTimePicker dTPAddDate;
        private System.Windows.Forms.ComboBox cbBLanguage;
        private System.Windows.Forms.ComboBox cbBDeptName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dTPPressDate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}