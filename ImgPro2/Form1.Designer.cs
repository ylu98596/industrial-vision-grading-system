
namespace ImgPro2
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.颜色变换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.单色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.红ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.绿ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.蓝ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hSI空间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab空间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图像处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图像分割ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.颜色识别训练ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.橘黄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.柠黄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.青黄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.棕红ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.颜色分割ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.橘黄ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.柠黄ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.青黄ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.棕红ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.种类识别ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.存档ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读档ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.颜色变换ToolStripMenuItem,
            this.图像处理ToolStripMenuItem,
            this.图像分割ToolStripMenuItem,
            this.种类识别ToolStripMenuItem,
            this.存档ToolStripMenuItem,
            this.读档ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开文件ToolStripMenuItem,
            this.保存文件ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.文件ToolStripMenuItem.Text = "文件";
            this.文件ToolStripMenuItem.Click += new System.EventHandler(this.File_Click);
            // 
            // 打开文件ToolStripMenuItem
            // 
            this.打开文件ToolStripMenuItem.Name = "打开文件ToolStripMenuItem";
            this.打开文件ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.打开文件ToolStripMenuItem.Text = "打开文件";
            this.打开文件ToolStripMenuItem.Click += new System.EventHandler(this.File_Open);
            // 
            // 保存文件ToolStripMenuItem
            // 
            this.保存文件ToolStripMenuItem.Name = "保存文件ToolStripMenuItem";
            this.保存文件ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.保存文件ToolStripMenuItem.Text = "保存文件";
            this.保存文件ToolStripMenuItem.Click += new System.EventHandler(this.File_Save);
            // 
            // 颜色变换ToolStripMenuItem
            // 
            this.颜色变换ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.单色ToolStripMenuItem,
            this.hSI空间ToolStripMenuItem,
            this.lab空间ToolStripMenuItem});
            this.颜色变换ToolStripMenuItem.Name = "颜色变换ToolStripMenuItem";
            this.颜色变换ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.颜色变换ToolStripMenuItem.Text = "颜色空间";
            // 
            // 单色ToolStripMenuItem
            // 
            this.单色ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.红ToolStripMenuItem,
            this.绿ToolStripMenuItem,
            this.蓝ToolStripMenuItem});
            this.单色ToolStripMenuItem.Name = "单色ToolStripMenuItem";
            this.单色ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.单色ToolStripMenuItem.Text = "单色提取";
            this.单色ToolStripMenuItem.Click += new System.EventHandler(this.单色ToolStripMenuItem_Click);
            // 
            // 红ToolStripMenuItem
            // 
            this.红ToolStripMenuItem.Name = "红ToolStripMenuItem";
            this.红ToolStripMenuItem.Size = new System.Drawing.Size(128, 34);
            this.红ToolStripMenuItem.Text = "红";
            this.红ToolStripMenuItem.Click += new System.EventHandler(this.R_Danse);
            // 
            // 绿ToolStripMenuItem
            // 
            this.绿ToolStripMenuItem.Name = "绿ToolStripMenuItem";
            this.绿ToolStripMenuItem.Size = new System.Drawing.Size(128, 34);
            this.绿ToolStripMenuItem.Text = "绿";
            this.绿ToolStripMenuItem.Click += new System.EventHandler(this.绿ToolStripMenuItem_Click);
            // 
            // 蓝ToolStripMenuItem
            // 
            this.蓝ToolStripMenuItem.Name = "蓝ToolStripMenuItem";
            this.蓝ToolStripMenuItem.Size = new System.Drawing.Size(128, 34);
            this.蓝ToolStripMenuItem.Text = "蓝";
            this.蓝ToolStripMenuItem.Click += new System.EventHandler(this.蓝ToolStripMenuItem_Click);
            // 
            // hSI空间ToolStripMenuItem
            // 
            this.hSI空间ToolStripMenuItem.Name = "hSI空间ToolStripMenuItem";
            this.hSI空间ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.hSI空间ToolStripMenuItem.Text = "HSI空间";
            this.hSI空间ToolStripMenuItem.Click += new System.EventHandler(this.HSI空间ToolStripMenuItem_Click);
            // 
            // lab空间ToolStripMenuItem
            // 
            this.lab空间ToolStripMenuItem.Name = "lab空间ToolStripMenuItem";
            this.lab空间ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.lab空间ToolStripMenuItem.Text = "Lab空间";
            this.lab空间ToolStripMenuItem.Click += new System.EventHandler(this.Lab空间ToolStripMenuItem_Click);
            // 
            // 图像处理ToolStripMenuItem
            // 
            this.图像处理ToolStripMenuItem.Name = "图像处理ToolStripMenuItem";
            this.图像处理ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.图像处理ToolStripMenuItem.Text = "图像处理";
            this.图像处理ToolStripMenuItem.Click += new System.EventHandler(this.图像处理ToolStripMenuItem_Click);
            // 
            // 图像分割ToolStripMenuItem
            // 
            this.图像分割ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.颜色识别训练ToolStripMenuItem,
            this.颜色分割ToolStripMenuItem});
            this.图像分割ToolStripMenuItem.Name = "图像分割ToolStripMenuItem";
            this.图像分割ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.图像分割ToolStripMenuItem.Text = "图像分割";
            this.图像分割ToolStripMenuItem.Click += new System.EventHandler(this.图像分割ToolStripMenuItem_Click);
            // 
            // 颜色识别训练ToolStripMenuItem
            // 
            this.颜色识别训练ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.橘黄ToolStripMenuItem,
            this.柠黄ToolStripMenuItem,
            this.青黄ToolStripMenuItem,
            this.棕红ToolStripMenuItem});
            this.颜色识别训练ToolStripMenuItem.Name = "颜色识别训练ToolStripMenuItem";
            this.颜色识别训练ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.颜色识别训练ToolStripMenuItem.Text = "颜色训练";
            this.颜色识别训练ToolStripMenuItem.Click += new System.EventHandler(this.颜色识别训练ToolStripMenuItem_Click);
            // 
            // 橘黄ToolStripMenuItem
            // 
            this.橘黄ToolStripMenuItem.Name = "橘黄ToolStripMenuItem";
            this.橘黄ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.橘黄ToolStripMenuItem.Text = "橘黄";
            this.橘黄ToolStripMenuItem.Click += new System.EventHandler(this.橘黄ToolStripMenuItem_Click);
            // 
            // 柠黄ToolStripMenuItem
            // 
            this.柠黄ToolStripMenuItem.Name = "柠黄ToolStripMenuItem";
            this.柠黄ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.柠黄ToolStripMenuItem.Text = "柠黄";
            this.柠黄ToolStripMenuItem.Click += new System.EventHandler(this.柠黄ToolStripMenuItem_Click);
            // 
            // 青黄ToolStripMenuItem
            // 
            this.青黄ToolStripMenuItem.Name = "青黄ToolStripMenuItem";
            this.青黄ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.青黄ToolStripMenuItem.Text = "青黄";
            this.青黄ToolStripMenuItem.Click += new System.EventHandler(this.青黄ToolStripMenuItem_Click);
            // 
            // 棕红ToolStripMenuItem
            // 
            this.棕红ToolStripMenuItem.Name = "棕红ToolStripMenuItem";
            this.棕红ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.棕红ToolStripMenuItem.Text = "棕红";
            this.棕红ToolStripMenuItem.Click += new System.EventHandler(this.棕红ToolStripMenuItem_Click);
            // 
            // 颜色分割ToolStripMenuItem
            // 
            this.颜色分割ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.橘黄ToolStripMenuItem1,
            this.柠黄ToolStripMenuItem1,
            this.青黄ToolStripMenuItem1,
            this.棕红ToolStripMenuItem1});
            this.颜色分割ToolStripMenuItem.Name = "颜色分割ToolStripMenuItem";
            this.颜色分割ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.颜色分割ToolStripMenuItem.Text = "颜色分割";
            this.颜色分割ToolStripMenuItem.Click += new System.EventHandler(this.颜色分割ToolStripMenuItem_Click);
            // 
            // 橘黄ToolStripMenuItem1
            // 
            this.橘黄ToolStripMenuItem1.Name = "橘黄ToolStripMenuItem1";
            this.橘黄ToolStripMenuItem1.Size = new System.Drawing.Size(146, 34);
            this.橘黄ToolStripMenuItem1.Text = "橘黄";
            this.橘黄ToolStripMenuItem1.Click += new System.EventHandler(this.橘黄ToolStripMenuItem1_Click);
            // 
            // 柠黄ToolStripMenuItem1
            // 
            this.柠黄ToolStripMenuItem1.Name = "柠黄ToolStripMenuItem1";
            this.柠黄ToolStripMenuItem1.Size = new System.Drawing.Size(146, 34);
            this.柠黄ToolStripMenuItem1.Text = "柠黄";
            this.柠黄ToolStripMenuItem1.Click += new System.EventHandler(this.柠黄ToolStripMenuItem1_Click);
            // 
            // 青黄ToolStripMenuItem1
            // 
            this.青黄ToolStripMenuItem1.Name = "青黄ToolStripMenuItem1";
            this.青黄ToolStripMenuItem1.Size = new System.Drawing.Size(146, 34);
            this.青黄ToolStripMenuItem1.Text = "青黄";
            this.青黄ToolStripMenuItem1.Click += new System.EventHandler(this.青黄ToolStripMenuItem1_Click);
            // 
            // 棕红ToolStripMenuItem1
            // 
            this.棕红ToolStripMenuItem1.Name = "棕红ToolStripMenuItem1";
            this.棕红ToolStripMenuItem1.Size = new System.Drawing.Size(146, 34);
            this.棕红ToolStripMenuItem1.Text = "棕红";
            this.棕红ToolStripMenuItem1.Click += new System.EventHandler(this.棕红ToolStripMenuItem1_Click);
            // 
            // 种类识别ToolStripMenuItem
            // 
            this.种类识别ToolStripMenuItem.Name = "种类识别ToolStripMenuItem";
            this.种类识别ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.种类识别ToolStripMenuItem.Text = "种类识别";
            this.种类识别ToolStripMenuItem.Click += new System.EventHandler(this.种类识别ToolStripMenuItem_Click);
            // 
            // 存档ToolStripMenuItem
            // 
            this.存档ToolStripMenuItem.Name = "存档ToolStripMenuItem";
            this.存档ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.存档ToolStripMenuItem.Text = "存档";
            this.存档ToolStripMenuItem.Click += new System.EventHandler(this.存档ToolStripMenuItem_Click);
            // 
            // 读档ToolStripMenuItem
            // 
            this.读档ToolStripMenuItem.Name = "读档ToolStripMenuItem";
            this.读档ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.读档ToolStripMenuItem.Text = "读档";
            this.读档ToolStripMenuItem.Click += new System.EventHandler(this.读档ToolStripMenuItem_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.imageBox1.Location = new System.Drawing.Point(12, 35);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(1076, 670);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            this.imageBox1.Click += new System.EventHandler(this.ImageBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 714);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1076, 28);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.Location = new System.Drawing.Point(12, 748);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(1076, 28);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 784);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 颜色变换ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图像处理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 单色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 红ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 绿ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 蓝ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hSI空间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lab空间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图像分割ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 颜色识别训练ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 存档ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读档ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 橘黄ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 柠黄ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 青黄ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 棕红ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 颜色分割ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 橘黄ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 柠黄ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 青黄ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 棕红ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 种类识别ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        public Emgu.CV.UI.ImageBox imageBox1;
    }
}

