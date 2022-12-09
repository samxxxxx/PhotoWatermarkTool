namespace PhotoWatermarkTool
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExt = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.staFileCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowPath = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSaveDir = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TrackBar();
            this.txtFontFile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TrackBar();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtDrawText = new System.Windows.Forms.TextBox();
            this.tbFontSize = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFontSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(765, 157);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "输出水印";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(97, 4);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 25);
            this.textBox1.TabIndex = 2;
            this.textBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.textBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragEnter);
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.AllowDrop = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(504, 436);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
            this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "文件";
            this.columnHeader1.Width = 229;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "搜索路径";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(624, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "搜索扩展名";
            // 
            // txtExt
            // 
            this.txtExt.AllowDrop = true;
            this.txtExt.Location = new System.Drawing.Point(718, 13);
            this.txtExt.Margin = new System.Windows.Forms.Padding(4);
            this.txtExt.Name = "txtExt";
            this.txtExt.Size = new System.Drawing.Size(147, 25);
            this.txtExt.TabIndex = 8;
            this.txtExt.Text = ".jpg|.dll";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staFileCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 680);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1095, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // staFileCount
            // 
            this.staFileCount.Name = "staFileCount";
            this.staFileCount.Size = new System.Drawing.Size(0, 16);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 244);
            this.panel1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowPath);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtSaveDir);
            this.groupBox1.Controls.Add(this.tbY);
            this.groupBox1.Controls.Add(this.txtExt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFontFile);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbX);
            this.groupBox1.Controls.Add(this.txtColor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtY);
            this.groupBox1.Controls.Add(this.txtDrawText);
            this.groupBox1.Controls.Add(this.tbFontSize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtFontSize);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtX);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(6, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1084, 199);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // btnShowPath
            // 
            this.btnShowPath.Font = new System.Drawing.Font("Marlett", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnShowPath.Location = new System.Drawing.Point(463, 162);
            this.btnShowPath.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowPath.Name = "btnShowPath";
            this.btnShowPath.Size = new System.Drawing.Size(30, 29);
            this.btnShowPath.TabIndex = 24;
            this.btnShowPath.Text = "u";
            this.btnShowPath.UseVisualStyleBackColor = true;
            this.btnShowPath.Click += new System.EventHandler(this.btnShowPath_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 171);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "输出路径";
            // 
            // txtSaveDir
            // 
            this.txtSaveDir.AllowDrop = true;
            this.txtSaveDir.Location = new System.Drawing.Point(116, 164);
            this.txtSaveDir.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaveDir.Name = "txtSaveDir";
            this.txtSaveDir.Size = new System.Drawing.Size(348, 25);
            this.txtSaveDir.TabIndex = 18;
            // 
            // tbY
            // 
            this.tbY.AutoSize = false;
            this.tbY.LargeChange = 1;
            this.tbY.Location = new System.Drawing.Point(116, 137);
            this.tbY.Maximum = 200;
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(240, 25);
            this.tbY.TabIndex = 23;
            this.tbY.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbY.Value = 100;
            this.tbY.ValueChanged += new System.EventHandler(this.tbY_ValueChanged);
            // 
            // txtFontFile
            // 
            this.txtFontFile.AllowDrop = true;
            this.txtFontFile.Location = new System.Drawing.Point(312, 46);
            this.txtFontFile.Margin = new System.Windows.Forms.Padding(4);
            this.txtFontFile.Name = "txtFontFile";
            this.txtFontFile.Size = new System.Drawing.Size(152, 25);
            this.txtFontFile.TabIndex = 14;
            this.txtFontFile.Text = "STCAIYUN.TTF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "使用字体";
            // 
            // tbX
            // 
            this.tbX.AutoSize = false;
            this.tbX.LargeChange = 1;
            this.tbX.Location = new System.Drawing.Point(116, 106);
            this.tbX.Maximum = 200;
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(240, 25);
            this.tbX.TabIndex = 22;
            this.tbX.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbX.Value = 100;
            this.tbX.Scroll += new System.EventHandler(this.tbX_Scroll);
            this.tbX.ValueChanged += new System.EventHandler(this.tbX_ValueChanged);
            // 
            // txtColor
            // 
            this.txtColor.AllowDrop = true;
            this.txtColor.Location = new System.Drawing.Point(116, 42);
            this.txtColor.Margin = new System.Windows.Forms.Padding(4);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(101, 25);
            this.txtColor.TabIndex = 12;
            this.txtColor.Text = "f5350f";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "颜色值";
            // 
            // txtY
            // 
            this.txtY.AllowDrop = true;
            this.txtY.Location = new System.Drawing.Point(363, 137);
            this.txtY.Margin = new System.Windows.Forms.Padding(4);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(101, 25);
            this.txtY.TabIndex = 20;
            this.txtY.Text = "100";
            // 
            // txtDrawText
            // 
            this.txtDrawText.AllowDrop = true;
            this.txtDrawText.Location = new System.Drawing.Point(116, 13);
            this.txtDrawText.Margin = new System.Windows.Forms.Padding(4);
            this.txtDrawText.Name = "txtDrawText";
            this.txtDrawText.Size = new System.Drawing.Size(292, 25);
            this.txtDrawText.TabIndex = 8;
            // 
            // tbFontSize
            // 
            this.tbFontSize.AutoSize = false;
            this.tbFontSize.LargeChange = 1;
            this.tbFontSize.Location = new System.Drawing.Point(116, 75);
            this.tbFontSize.Maximum = 200;
            this.tbFontSize.Name = "tbFontSize";
            this.tbFontSize.Size = new System.Drawing.Size(240, 25);
            this.tbFontSize.TabIndex = 12;
            this.tbFontSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbFontSize.Value = 50;
            this.tbFontSize.ValueChanged += new System.EventHandler(this.tbFontSize_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "水印文字";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 140);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Y";
            // 
            // txtFontSize
            // 
            this.txtFontSize.AllowDrop = true;
            this.txtFontSize.Location = new System.Drawing.Point(363, 75);
            this.txtFontSize.Margin = new System.Windows.Forms.Padding(4);
            this.txtFontSize.Name = "txtFontSize";
            this.txtFontSize.Size = new System.Drawing.Size(101, 25);
            this.txtFontSize.TabIndex = 10;
            this.txtFontSize.Text = "50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "字体大小";
            // 
            // txtX
            // 
            this.txtX.AllowDrop = true;
            this.txtX.Location = new System.Drawing.Point(363, 107);
            this.txtX.Margin = new System.Windows.Forms.Padding(4);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(101, 25);
            this.txtX.TabIndex = 16;
            this.txtX.Text = "100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "X";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 244);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1095, 436);
            this.splitContainer1.SplitterDistance = 504;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 12;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer2.Size = new System.Drawing.Size(586, 436);
            this.splitContainer2.SplitterDistance = 340;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(340, 436);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 702);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "照片水印工具";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFontSize)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExt;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel staFileCount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFontSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDrawText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFontFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSaveDir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar tbFontSize;
        private System.Windows.Forms.TrackBar tbY;
        private System.Windows.Forms.TrackBar tbX;
        private System.Windows.Forms.Button btnShowPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

