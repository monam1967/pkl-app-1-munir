
namespace pkl_app_1_munir
{
    partial class Calc
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
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.tambah = new System.Windows.Forms.Button();
            this.kurang = new System.Windows.Forms.Button();
            this.kali = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.bagi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input1.Location = new System.Drawing.Point(213, 83);
            this.input1.Multiline = true;
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(183, 35);
            this.input1.TabIndex = 0;
            // 
            // input2
            // 
            this.input2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input2.Location = new System.Drawing.Point(213, 134);
            this.input2.Multiline = true;
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(183, 36);
            this.input2.TabIndex = 1;
            // 
            // tambah
            // 
            this.tambah.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tambah.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambah.Location = new System.Drawing.Point(213, 183);
            this.tambah.Margin = new System.Windows.Forms.Padding(0);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(38, 38);
            this.tambah.TabIndex = 2;
            this.tambah.Text = "+";
            this.tambah.UseVisualStyleBackColor = true;
            this.tambah.Click += new System.EventHandler(this.tambah_Click);
            // 
            // kurang
            // 
            this.kurang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kurang.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kurang.ForeColor = System.Drawing.Color.Black;
            this.kurang.Location = new System.Drawing.Point(262, 183);
            this.kurang.Margin = new System.Windows.Forms.Padding(0);
            this.kurang.Name = "kurang";
            this.kurang.Size = new System.Drawing.Size(38, 38);
            this.kurang.TabIndex = 3;
            this.kurang.Text = "-";
            this.kurang.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.kurang.UseVisualStyleBackColor = true;
            this.kurang.Click += new System.EventHandler(this.kurang_Click);
            // 
            // kali
            // 
            this.kali.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kali.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kali.Location = new System.Drawing.Point(312, 184);
            this.kali.Margin = new System.Windows.Forms.Padding(0);
            this.kali.Name = "kali";
            this.kali.Size = new System.Drawing.Size(38, 38);
            this.kali.TabIndex = 4;
            this.kali.Text = "X";
            this.kali.UseVisualStyleBackColor = true;
            this.kali.Click += new System.EventHandler(this.kali_Click);
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(234, 268);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(137, 33);
            this.output.TabIndex = 5;
            this.output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bagi
            // 
            this.bagi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bagi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagi.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.bagi.Location = new System.Drawing.Point(358, 184);
            this.bagi.Margin = new System.Windows.Forms.Padding(0);
            this.bagi.Name = "bagi";
            this.bagi.Size = new System.Drawing.Size(38, 38);
            this.bagi.TabIndex = 6;
            this.bagi.Text = ":";
            this.bagi.UseVisualStyleBackColor = true;
            this.bagi.Click += new System.EventHandler(this.bagi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hasil :";
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(649, 413);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bagi);
            this.Controls.Add(this.output);
            this.Controls.Add(this.kali);
            this.Controls.Add(this.kurang);
            this.Controls.Add(this.tambah);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Name = "Calc";
            this.Text = "Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.Button tambah;
        private System.Windows.Forms.Button kurang;
        private System.Windows.Forms.Button kali;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button bagi;
        private System.Windows.Forms.Label label1;
    }
}