namespace PileRa
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读入文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.增加一行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除一行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnGetRa = new System.Windows.Forms.Button();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCircumference = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读取文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.写入文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSCoeffient = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxECoeffient = new System.Windows.Forms.TextBox();
            this.简化显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column13,
            this.Column14,
            this.Column3,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column16,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column15});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1045, 568);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新ToolStripMenuItem,
            this.读入文件ToolStripMenuItem,
            this.导出文件ToolStripMenuItem,
            this.退出ToolStripMenuItem1,
            this.增加一行ToolStripMenuItem,
            this.删除一行ToolStripMenuItem,
            this.简化显示ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 158);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.刷新ToolStripMenuItem.Text = "显示全部";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.显示全部ToolStripMenuItem_Click);
            // 
            // 读入文件ToolStripMenuItem
            // 
            this.读入文件ToolStripMenuItem.Name = "读入文件ToolStripMenuItem";
            this.读入文件ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.读入文件ToolStripMenuItem.Text = "读入文件";
            this.读入文件ToolStripMenuItem.Click += new System.EventHandler(this.读入文件ToolStripMenuItem_Click);
            // 
            // 导出文件ToolStripMenuItem
            // 
            this.导出文件ToolStripMenuItem.Name = "导出文件ToolStripMenuItem";
            this.导出文件ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.导出文件ToolStripMenuItem.Text = "导出文件";
            this.导出文件ToolStripMenuItem.Click += new System.EventHandler(this.导出文件ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem1
            // 
            this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            this.退出ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem1.Text = "退出";
            this.退出ToolStripMenuItem1.Click += new System.EventHandler(this.退出ToolStripMenuItem1_Click);
            // 
            // 增加一行ToolStripMenuItem
            // 
            this.增加一行ToolStripMenuItem.Name = "增加一行ToolStripMenuItem";
            this.增加一行ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.增加一行ToolStripMenuItem.Text = "增加一行";
            this.增加一行ToolStripMenuItem.Click += new System.EventHandler(this.增加一行ToolStripMenuItem_Click);
            // 
            // 删除一行ToolStripMenuItem
            // 
            this.删除一行ToolStripMenuItem.Name = "删除一行ToolStripMenuItem";
            this.删除一行ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除一行ToolStripMenuItem.Text = "删除一行";
            this.删除一行ToolStripMenuItem.Click += new System.EventHandler(this.删除一行ToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.progressBar1);
            this.splitContainer1.Panel1.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnGetRa);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxECoeffient);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxArea);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxSCoeffient);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxCircumference);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxDia);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1248, 593);
            this.splitContainer1.SplitterDistance = 1045;
            this.splitContainer1.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar1.Location = new System.Drawing.Point(63, 570);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(367, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 571);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1045, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel1.Text = "提示";
            // 
            // btnGetRa
            // 
            this.btnGetRa.Location = new System.Drawing.Point(24, 203);
            this.btnGetRa.Name = "btnGetRa";
            this.btnGetRa.Size = new System.Drawing.Size(75, 23);
            this.btnGetRa.TabIndex = 0;
            this.btnGetRa.Text = "计算Ra";
            this.btnGetRa.UseVisualStyleBackColor = true;
            this.btnGetRa.Click += new System.EventHandler(this.btnGetRa_Click);
            // 
            // textBoxArea
            // 
            this.textBoxArea.Location = new System.Drawing.Point(112, 90);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(66, 21);
            this.textBoxArea.TabIndex = 2;
            this.textBoxArea.Text = "0.8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "面积m2";
            // 
            // textBoxCircumference
            // 
            this.textBoxCircumference.Location = new System.Drawing.Point(112, 57);
            this.textBoxCircumference.Name = "textBoxCircumference";
            this.textBoxCircumference.Size = new System.Drawing.Size(66, 21);
            this.textBoxCircumference.TabIndex = 2;
            this.textBoxCircumference.Text = "0.8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "周长m";
            // 
            // textBoxDia
            // 
            this.textBoxDia.Location = new System.Drawing.Point(112, 20);
            this.textBoxDia.Name = "textBoxDia";
            this.textBoxDia.Size = new System.Drawing.Size(66, 21);
            this.textBoxDia.TabIndex = 2;
            this.textBoxDia.Text = "0.8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "直径m";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1248, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.读取文件ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.另存为ToolStripMenuItem,
            this.写入文件ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 读取文件ToolStripMenuItem
            // 
            this.读取文件ToolStripMenuItem.Name = "读取文件ToolStripMenuItem";
            this.读取文件ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.读取文件ToolStripMenuItem.Text = "读取文件";
            this.读取文件ToolStripMenuItem.Click += new System.EventHandler(this.读取文件ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.另存为ToolStripMenuItem.Text = "另存为";
            this.另存为ToolStripMenuItem.Click += new System.EventHandler(this.另存为ToolStripMenuItem_Click);
            // 
            // 写入文件ToolStripMenuItem
            // 
            this.写入文件ToolStripMenuItem.Name = "写入文件ToolStripMenuItem";
            this.写入文件ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.写入文件ToolStripMenuItem.Text = "写入文件";
            this.写入文件ToolStripMenuItem.Click += new System.EventHandler(this.写入文件ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "桩侧调整系数";
            // 
            // textBoxSCoeffient
            // 
            this.textBoxSCoeffient.Location = new System.Drawing.Point(112, 122);
            this.textBoxSCoeffient.Name = "textBoxSCoeffient";
            this.textBoxSCoeffient.Size = new System.Drawing.Size(66, 21);
            this.textBoxSCoeffient.TabIndex = 2;
            this.textBoxSCoeffient.Text = "1.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "桩端调整系数";
            // 
            // textBoxECoeffient
            // 
            this.textBoxECoeffient.Location = new System.Drawing.Point(112, 155);
            this.textBoxECoeffient.Name = "textBoxECoeffient";
            this.textBoxECoeffient.Size = new System.Drawing.Size(66, 21);
            this.textBoxECoeffient.TabIndex = 2;
            this.textBoxECoeffient.Text = "1.0";
            // 
            // 简化显示ToolStripMenuItem
            // 
            this.简化显示ToolStripMenuItem.Name = "简化显示ToolStripMenuItem";
            this.简化显示ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.简化显示ToolStripMenuItem.Text = "简化显示";
            this.简化显示ToolStripMenuItem.Click += new System.EventHandler(this.简化显示ToolStripMenuItem_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Label";
            this.Column1.HeaderText = "孔编号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "LayerName";
            this.Column2.HeaderText = "土层名";
            this.Column2.Name = "Column2";
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "StartElevation";
            this.Column13.HeaderText = "起高程";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "EndElevation";
            this.Column14.HeaderText = "止高程";
            this.Column14.Name = "Column14";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "LayerThickness";
            this.Column3.HeaderText = "土层厚度/m";
            this.Column3.Name = "Column3";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Diameter";
            this.Column10.HeaderText = "直径";
            this.Column10.Name = "Column10";
            this.Column10.Visible = false;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Circumference";
            this.Column11.HeaderText = "周长";
            this.Column11.Name = "Column11";
            this.Column11.Visible = false;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "Area";
            this.Column12.HeaderText = "面积";
            this.Column12.Name = "Column12";
            this.Column12.Visible = false;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "TCoeffient";
            this.Column16.HeaderText = "调整系数";
            this.Column16.Name = "Column16";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Qs";
            this.Column4.HeaderText = "qsi/KPa";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SCoeffient";
            this.Column5.HeaderText = "侧摩调整系数";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SideFrictionResistance";
            this.Column6.HeaderText = "侧阻力/KN";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Qp";
            this.Column7.HeaderText = "qp/KPa";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ECoeffient";
            this.Column8.HeaderText = "端阻调整系数";
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "EndFrictionResistance";
            this.Column9.HeaderText = "端阻力/KN";
            this.Column9.Name = "Column9";
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "Ra";
            this.Column15.HeaderText = "单层Ra/KN";
            this.Column15.Name = "Column15";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1248, 618);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox textBoxDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetRa;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读取文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 写入文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读入文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 增加一行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除一行ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCircumference;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxECoeffient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSCoeffient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem 简化显示ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
    }
}

