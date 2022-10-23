namespace lab1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autocontrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бинаризацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точечнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ниблэкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.globalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сравнениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pSNRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sSIMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шумToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uniformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.railethToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.убратьШумToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.арифметическоеСреднееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.геометрическоеСреднеееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медианныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гауссToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.минимальныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гистограммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрыToolStripMenuItem,
            this.бинаризацияToolStripMenuItem,
            this.отменаToolStripMenuItem,
            this.сравнениеToolStripMenuItem,
            this.шумToolStripMenuItem,
            this.убратьШумToolStripMenuItem,
            this.инструментыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.загрузитьToolStripMenuItem.Text = "Открыть";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayscaleToolStripMenuItem,
            this.averageToolStripMenuItem,
            this.autocontrastToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.grayscaleToolStripMenuItem.Text = "Grayscale";
            this.grayscaleToolStripMenuItem.Click += new System.EventHandler(this.grayscaleToolStripMenuItem_Click);
            // 
            // averageToolStripMenuItem
            // 
            this.averageToolStripMenuItem.Name = "averageToolStripMenuItem";
            this.averageToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.averageToolStripMenuItem.Text = "Average";
            this.averageToolStripMenuItem.Click += new System.EventHandler(this.averageToolStripMenuItem_Click);
            // 
            // autocontrastToolStripMenuItem
            // 
            this.autocontrastToolStripMenuItem.Name = "autocontrastToolStripMenuItem";
            this.autocontrastToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.autocontrastToolStripMenuItem.Text = "Autocontrast";
            this.autocontrastToolStripMenuItem.Click += new System.EventHandler(this.autocontrastToolStripMenuItem_Click);
            // 
            // бинаризацияToolStripMenuItem
            // 
            this.бинаризацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечнаяToolStripMenuItem,
            this.ниблэкToolStripMenuItem,
            this.globalToolStripMenuItem});
            this.бинаризацияToolStripMenuItem.Name = "бинаризацияToolStripMenuItem";
            this.бинаризацияToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.бинаризацияToolStripMenuItem.Text = "Бинаризация";
            // 
            // точечнаяToolStripMenuItem
            // 
            this.точечнаяToolStripMenuItem.Name = "точечнаяToolStripMenuItem";
            this.точечнаяToolStripMenuItem.Size = new System.Drawing.Size(286, 24);
            this.точечнаяToolStripMenuItem.Text = "Точечная(Глобальный порог)";
            this.точечнаяToolStripMenuItem.Click += new System.EventHandler(this.globalToolStripMenuItem_Click);
            // 
            // ниблэкToolStripMenuItem
            // 
            this.ниблэкToolStripMenuItem.Name = "ниблэкToolStripMenuItem";
            this.ниблэкToolStripMenuItem.Size = new System.Drawing.Size(286, 24);
            this.ниблэкToolStripMenuItem.Text = " Ниблэк";
            this.ниблэкToolStripMenuItem.Click += new System.EventHandler(this.niblackToolStripMenuItem_Click);
            // 
            // globalToolStripMenuItem
            // 
            this.globalToolStripMenuItem.Name = "globalToolStripMenuItem";
            this.globalToolStripMenuItem.Size = new System.Drawing.Size(286, 24);
            this.globalToolStripMenuItem.Text = "Глобальная(Гистограмма)";
            this.globalToolStripMenuItem.Click += new System.EventHandler(this.globalToolStripMenuItem_Click_1);
            // 
            // отменаToolStripMenuItem
            // 
            this.отменаToolStripMenuItem.Name = "отменаToolStripMenuItem";
            this.отменаToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.отменаToolStripMenuItem.Text = "Отмена";
            this.отменаToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // сравнениеToolStripMenuItem
            // 
            this.сравнениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pSNRToolStripMenuItem,
            this.sSIMToolStripMenuItem});
            this.сравнениеToolStripMenuItem.Name = "сравнениеToolStripMenuItem";
            this.сравнениеToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.сравнениеToolStripMenuItem.Text = "Сравнение";
            // 
            // pSNRToolStripMenuItem
            // 
            this.pSNRToolStripMenuItem.Name = "pSNRToolStripMenuItem";
            this.pSNRToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.pSNRToolStripMenuItem.Text = "PSNR";
            this.pSNRToolStripMenuItem.Click += new System.EventHandler(this.pSNRToolStripMenuItem_Click);
            // 
            // sSIMToolStripMenuItem
            // 
            this.sSIMToolStripMenuItem.Name = "sSIMToolStripMenuItem";
            this.sSIMToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.sSIMToolStripMenuItem.Text = "SSIM";
            this.sSIMToolStripMenuItem.Click += new System.EventHandler(this.sSIMToolStripMenuItem_Click);
            // 
            // шумToolStripMenuItem
            // 
            this.шумToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uniformToolStripMenuItem,
            this.railethToolStripMenuItem});
            this.шумToolStripMenuItem.Name = "шумToolStripMenuItem";
            this.шумToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.шумToolStripMenuItem.Text = "Шум";
            // 
            // uniformToolStripMenuItem
            // 
            this.uniformToolStripMenuItem.Name = "uniformToolStripMenuItem";
            this.uniformToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.uniformToolStripMenuItem.Text = "Uniform";
            this.uniformToolStripMenuItem.Click += new System.EventHandler(this.uniformToolStripMenuItem_Click);
            // 
            // railethToolStripMenuItem
            // 
            this.railethToolStripMenuItem.Name = "railethToolStripMenuItem";
            this.railethToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.railethToolStripMenuItem.Text = "Raileth";
            this.railethToolStripMenuItem.Click += new System.EventHandler(this.railethToolStripMenuItem_Click);
            // 
            // убратьШумToolStripMenuItem
            // 
            this.убратьШумToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.арифметическоеСреднееToolStripMenuItem,
            this.геометрическоеСреднеееToolStripMenuItem,
            this.медианныйToolStripMenuItem,
            this.гауссToolStripMenuItem,
            this.минимальныйToolStripMenuItem});
            this.убратьШумToolStripMenuItem.Name = "убратьШумToolStripMenuItem";
            this.убратьШумToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.убратьШумToolStripMenuItem.Text = "Убрать шум";
            // 
            // арифметическоеСреднееToolStripMenuItem
            // 
            this.арифметическоеСреднееToolStripMenuItem.Name = "арифметическоеСреднееToolStripMenuItem";
            this.арифметическоеСреднееToolStripMenuItem.Size = new System.Drawing.Size(261, 24);
            this.арифметическоеСреднееToolStripMenuItem.Text = "Арифметическое среднее";
            this.арифметическоеСреднееToolStripMenuItem.Click += new System.EventHandler(this.ariphmeticMean);
            // 
            // геометрическоеСреднеееToolStripMenuItem
            // 
            this.геометрическоеСреднеееToolStripMenuItem.Name = "геометрическоеСреднеееToolStripMenuItem";
            this.геометрическоеСреднеееToolStripMenuItem.Size = new System.Drawing.Size(261, 24);
            this.геометрическоеСреднеееToolStripMenuItem.Text = "Геометрическое среднеее";
            this.геометрическоеСреднеееToolStripMenuItem.Click += new System.EventHandler(this.geometricMean);
            // 
            // медианныйToolStripMenuItem
            // 
            this.медианныйToolStripMenuItem.Name = "медианныйToolStripMenuItem";
            this.медианныйToolStripMenuItem.Size = new System.Drawing.Size(261, 24);
            this.медианныйToolStripMenuItem.Text = "Медианный";
            this.медианныйToolStripMenuItem.Click += new System.EventHandler(this.медианныйToolStripMenuItem_Click);
            // 
            // гауссToolStripMenuItem
            // 
            this.гауссToolStripMenuItem.Name = "гауссToolStripMenuItem";
            this.гауссToolStripMenuItem.Size = new System.Drawing.Size(261, 24);
            this.гауссToolStripMenuItem.Text = "Гаусс";
            this.гауссToolStripMenuItem.Click += new System.EventHandler(this.gauss);
            // 
            // минимальныйToolStripMenuItem
            // 
            this.минимальныйToolStripMenuItem.Name = "минимальныйToolStripMenuItem";
            this.минимальныйToolStripMenuItem.Size = new System.Drawing.Size(261, 24);
            this.минимальныйToolStripMenuItem.Text = "Минимальный";
            this.минимальныйToolStripMenuItem.Click += new System.EventHandler(this.минимальныйToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 710);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 20;
            this.trackBar1.Location = new System.Drawing.Point(26, 775);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(678, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(710, 775);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.гистограммаToolStripMenuItem});
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            // 
            // гистограммаToolStripMenuItem
            // 
            this.гистограммаToolStripMenuItem.Name = "гистограммаToolStripMenuItem";
            this.гистограммаToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.гистограммаToolStripMenuItem.Text = "Гистограмма";
            this.гистограммаToolStripMenuItem.Click += new System.EventHandler(this.гистограммаToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(826, 832);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autocontrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бинаризацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem точечнаяToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem ниблэкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem globalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сравнениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pSNRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sSIMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шумToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uniformToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem убратьШумToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem арифметическоеСреднееToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem геометрическоеСреднеееToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem медианныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гауссToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem railethToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem минимальныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гистограммаToolStripMenuItem;
    }
}

