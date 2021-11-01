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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.рассчётНДФЛToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рассчётСуществованияТреугольникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переводТемпературыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рассчетМатрицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матрица2х2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матрица3х3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рассчётНДФЛToolStripMenuItem,
            this.рассчётСуществованияТреугольникаToolStripMenuItem,
            this.переводТемпературыToolStripMenuItem,
            this.рассчетМатрицыToolStripMenuItem,
            this.справкаToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // рассчётНДФЛToolStripMenuItem
            // 
            this.рассчётНДФЛToolStripMenuItem.Name = "рассчётНДФЛToolStripMenuItem";
            this.рассчётНДФЛToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.рассчётНДФЛToolStripMenuItem.Text = "Рассчёт НДФЛ";
            this.рассчётНДФЛToolStripMenuItem.Click += new System.EventHandler(this.рассчётНДФЛToolStripMenuItem_Click);
            // 
            // рассчётСуществованияТреугольникаToolStripMenuItem
            // 
            this.рассчётСуществованияТреугольникаToolStripMenuItem.Name = "рассчётСуществованияТреугольникаToolStripMenuItem";
            this.рассчётСуществованияТреугольникаToolStripMenuItem.Size = new System.Drawing.Size(283, 24);
            this.рассчётСуществованияТреугольникаToolStripMenuItem.Text = "Рассчёт существования треугольника";
            this.рассчётСуществованияТреугольникаToolStripMenuItem.Click += new System.EventHandler(this.рассчётСуществованияТреугольникаToolStripMenuItem_Click);
            // 
            // переводТемпературыToolStripMenuItem
            // 
            this.переводТемпературыToolStripMenuItem.Name = "переводТемпературыToolStripMenuItem";
            this.переводТемпературыToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.переводТемпературыToolStripMenuItem.Text = "Перевод температуры";
            this.переводТемпературыToolStripMenuItem.Click += new System.EventHandler(this.переводТемпературыToolStripMenuItem_Click);
            // 
            // рассчетМатрицыToolStripMenuItem
            // 
            this.рассчетМатрицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.матрица2х2ToolStripMenuItem,
            this.матрица3х3ToolStripMenuItem});
            this.рассчетМатрицыToolStripMenuItem.Name = "рассчетМатрицыToolStripMenuItem";
            this.рассчетМатрицыToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.рассчетМатрицыToolStripMenuItem.Text = "Рассчет матрицы";
            // 
            // матрица2х2ToolStripMenuItem
            // 
            this.матрица2х2ToolStripMenuItem.Name = "матрица2х2ToolStripMenuItem";
            this.матрица2х2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.матрица2х2ToolStripMenuItem.Text = "Матрица 2х2";
            this.матрица2х2ToolStripMenuItem.Click += new System.EventHandler(this.матрица2х2ToolStripMenuItem_Click);
            // 
            // матрица3х3ToolStripMenuItem
            // 
            this.матрица3х3ToolStripMenuItem.Name = "матрица3х3ToolStripMenuItem";
            this.матрица3х3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.матрица3х3ToolStripMenuItem.Text = "Матрица 3х3";
            this.матрица3х3ToolStripMenuItem.Click += new System.EventHandler(this.матрица3х3ToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem1
            // 
            this.справкаToolStripMenuItem1.Name = "справкаToolStripMenuItem1";
            this.справкаToolStripMenuItem1.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem1.Text = "Справка";
            this.справкаToolStripMenuItem1.Click += new System.EventHandler(this.справкаToolStripMenuItem1_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "НДФЛ треугольника и температура матрицы";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Label1_MouseEnter(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem рассчётНДФЛToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рассчётСуществованияТреугольникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переводТемпературыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рассчетМатрицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матрица2х2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матрица3х3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

