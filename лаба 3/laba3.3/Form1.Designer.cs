namespace laba3._2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.приветствиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стихотворениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переводСистемСчисленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.решениеКвадратногоУравненияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 28);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Авторизация";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.приветствиеToolStripMenuItem,
            this.стихотворениеToolStripMenuItem,
            this.переводСистемСчисленияToolStripMenuItem,
            this.решениеКвадратногоУравненияToolStripMenuItem,
            this.справкаToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // приветствиеToolStripMenuItem
            // 
            this.приветствиеToolStripMenuItem.Name = "приветствиеToolStripMenuItem";
            this.приветствиеToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.приветствиеToolStripMenuItem.Text = "Приветствие";
            this.приветствиеToolStripMenuItem.Click += new System.EventHandler(this.приветствиеToolStripMenuItem_Click);
            // 
            // стихотворениеToolStripMenuItem
            // 
            this.стихотворениеToolStripMenuItem.Name = "стихотворениеToolStripMenuItem";
            this.стихотворениеToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.стихотворениеToolStripMenuItem.Text = "Стихотворение";
            this.стихотворениеToolStripMenuItem.Click += new System.EventHandler(this.стихотворениеToolStripMenuItem_Click);
            // 
            // переводСистемСчисленияToolStripMenuItem
            // 
            this.переводСистемСчисленияToolStripMenuItem.Name = "переводСистемСчисленияToolStripMenuItem";
            this.переводСистемСчисленияToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.переводСистемСчисленияToolStripMenuItem.Text = "Перевод систем счисления";
            this.переводСистемСчисленияToolStripMenuItem.Click += new System.EventHandler(this.переводСистемСчисленияToolStripMenuItem_Click);
            // 
            // решениеКвадратногоУравненияToolStripMenuItem
            // 
            this.решениеКвадратногоУравненияToolStripMenuItem.Name = "решениеКвадратногоУравненияToolStripMenuItem";
            this.решениеКвадратногоУравненияToolStripMenuItem.Size = new System.Drawing.Size(255, 24);
            this.решениеКвадратногоУравненияToolStripMenuItem.Text = "Решение квадратного уравнения";
            this.решениеКвадратногоУравненияToolStripMenuItem.Click += new System.EventHandler(this.решениеКвадратногоУравненияToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem1
            // 
            this.справкаToolStripMenuItem1.Name = "справкаToolStripMenuItem1";
            this.справкаToolStripMenuItem1.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem1.Text = "Справка";
            this.справкаToolStripMenuItem1.Click += new System.EventHandler(this.справкаToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 414);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Приветсвие стихотворение перевод систем счисления  и решение уравнений";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Label1_MouseEnter(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem приветствиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стихотворениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переводСистемСчисленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem решениеКвадратногоУравненияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem1;
    }
}

