
namespace pkl_app_1_munir
{
    partial class Home
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.latihanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.namaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.umurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.potongNamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tugasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sequentialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.latihanToolStripMenuItem,
            this.tugasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // latihanToolStripMenuItem
            // 
            this.latihanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.namaToolStripMenuItem,
            this.calculatorToolStripMenuItem,
            this.umurToolStripMenuItem,
            this.potongNamaToolStripMenuItem,
            this.toolStripMenuItem2,
            this.sequentialToolStripMenuItem});
            this.latihanToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latihanToolStripMenuItem.Name = "latihanToolStripMenuItem";
            this.latihanToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.latihanToolStripMenuItem.Text = "Latihan";
            // 
            // namaToolStripMenuItem
            // 
            this.namaToolStripMenuItem.Name = "namaToolStripMenuItem";
            this.namaToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.namaToolStripMenuItem.Text = "Nama";
            this.namaToolStripMenuItem.Click += new System.EventHandler(this.namaToolStripMenuItem_Click);
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // umurToolStripMenuItem
            // 
            this.umurToolStripMenuItem.Name = "umurToolStripMenuItem";
            this.umurToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.umurToolStripMenuItem.Text = "Umur";
            this.umurToolStripMenuItem.Click += new System.EventHandler(this.umurToolStripMenuItem_Click);
            // 
            // potongNamaToolStripMenuItem
            // 
            this.potongNamaToolStripMenuItem.Name = "potongNamaToolStripMenuItem";
            this.potongNamaToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.potongNamaToolStripMenuItem.Text = "Potong Nama";
            this.potongNamaToolStripMenuItem.Click += new System.EventHandler(this.potongNamaToolStripMenuItem_Click);
            // 
            // tugasToolStripMenuItem
            // 
            this.tugasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem1});
            this.tugasToolStripMenuItem.Name = "tugasToolStripMenuItem";
            this.tugasToolStripMenuItem.Size = new System.Drawing.Size(50, 21);
            this.tugasToolStripMenuItem.Text = "Tugas";
            // 
            // calculatorToolStripMenuItem1
            // 
            this.calculatorToolStripMenuItem1.Name = "calculatorToolStripMenuItem1";
            this.calculatorToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.calculatorToolStripMenuItem1.Text = "Calculator";
            this.calculatorToolStripMenuItem1.Click += new System.EventHandler(this.calculatorToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(271, 22);
            this.toolStripMenuItem2.Text = "---------------------------------------";
            // 
            // sequentialToolStripMenuItem
            // 
            this.sequentialToolStripMenuItem.Name = "sequentialToolStripMenuItem";
            this.sequentialToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.sequentialToolStripMenuItem.Text = "Sequential";
            this.sequentialToolStripMenuItem.Click += new System.EventHandler(this.sequentialToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem latihanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem namaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem umurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem potongNamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tugasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sequentialToolStripMenuItem;
    }
}