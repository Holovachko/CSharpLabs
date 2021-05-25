
namespace Ex2
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
            this.зберегтиФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завантажитиФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операціїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.згенеруватиМасивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кстьПарнихЕлементівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.операціїToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зберегтиФайлToolStripMenuItem,
            this.завантажитиФайлToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // зберегтиФайлToolStripMenuItem
            // 
            this.зберегтиФайлToolStripMenuItem.Name = "зберегтиФайлToolStripMenuItem";
            this.зберегтиФайлToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.зберегтиФайлToolStripMenuItem.Text = "Зберегти файл";
            this.зберегтиФайлToolStripMenuItem.Click += new System.EventHandler(this.зберегтиФайлToolStripMenuItem_Click);
            // 
            // завантажитиФайлToolStripMenuItem
            // 
            this.завантажитиФайлToolStripMenuItem.Name = "завантажитиФайлToolStripMenuItem";
            this.завантажитиФайлToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.завантажитиФайлToolStripMenuItem.Text = "Завантажити файл";
            this.завантажитиФайлToolStripMenuItem.Click += new System.EventHandler(this.завантажитиФайлToolStripMenuItem_Click);
            // 
            // операціїToolStripMenuItem
            // 
            this.операціїToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.згенеруватиМасивToolStripMenuItem,
            this.кстьПарнихЕлементівToolStripMenuItem});
            this.операціїToolStripMenuItem.Name = "операціїToolStripMenuItem";
            this.операціїToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.операціїToolStripMenuItem.Text = "Операції";
            // 
            // згенеруватиМасивToolStripMenuItem
            // 
            this.згенеруватиМасивToolStripMenuItem.Name = "згенеруватиМасивToolStripMenuItem";
            this.згенеруватиМасивToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.згенеруватиМасивToolStripMenuItem.Text = "Згенерувати масив";
            this.згенеруватиМасивToolStripMenuItem.Click += new System.EventHandler(this.згенеруватиМасивToolStripMenuItem_Click);
            // 
            // кстьПарнихЕлементівToolStripMenuItem
            // 
            this.кстьПарнихЕлементівToolStripMenuItem.Name = "кстьПарнихЕлементівToolStripMenuItem";
            this.кстьПарнихЕлементівToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.кстьПарнихЕлементівToolStripMenuItem.Text = "К-сть парних елементів";
            this.кстьПарнихЕлементівToolStripMenuItem.Click += new System.EventHandler(this.кстьПарнихЕлементівToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(373, 255);
            this.dataGridView1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(21, 105);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "К-сть парних елементів";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(670, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завантажитиФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операціїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem згенеруватиМасивToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кстьПарнихЕлементівToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

