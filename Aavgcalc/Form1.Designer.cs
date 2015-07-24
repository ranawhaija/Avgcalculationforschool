namespace Aavgcalc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.t2t = new System.Windows.Forms.Label();
            this.avgt = new System.Windows.Forms.Label();
            this.calc = new System.Windows.Forms.Button();
            this.m1t = new System.Windows.Forms.TextBox();
            this.t2tt = new System.Windows.Forms.TextBox();
            this.avgtt = new System.Windows.Forms.TextBox();
            this.m2t = new System.Windows.Forms.TextBox();
            this.m3t = new System.Windows.Forms.TextBox();
            this.m4t = new System.Windows.Forms.TextBox();
            this.t1t = new System.Windows.Forms.TextBox();
            this.clearbt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "m1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "m2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "m3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "m4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "total_first";
            // 
            // t2t
            // 
            this.t2t.AutoSize = true;
            this.t2t.Location = new System.Drawing.Point(217, 22);
            this.t2t.Name = "t2t";
            this.t2t.Size = new System.Drawing.Size(50, 13);
            this.t2t.TabIndex = 5;
            this.t2t.Text = "total_sec";
            // 
            // avgt
            // 
            this.avgt.AutoSize = true;
            this.avgt.Location = new System.Drawing.Point(220, 63);
            this.avgt.Name = "avgt";
            this.avgt.Size = new System.Drawing.Size(29, 13);
            this.avgt.TabIndex = 6;
            this.avgt.Text = "AVG";
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(257, 220);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(153, 23);
            this.calc.TabIndex = 7;
            this.calc.Text = "Calculate";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // m1t
            // 
            this.m1t.Location = new System.Drawing.Point(64, 22);
            this.m1t.Name = "m1t";
            this.m1t.Size = new System.Drawing.Size(100, 20);
            this.m1t.TabIndex = 8;
            // 
            // t2tt
            // 
            this.t2tt.Location = new System.Drawing.Point(286, 21);
            this.t2tt.Name = "t2tt";
            this.t2tt.Size = new System.Drawing.Size(100, 20);
            this.t2tt.TabIndex = 9;
            // 
            // avgtt
            // 
            this.avgtt.Location = new System.Drawing.Point(286, 63);
            this.avgtt.Name = "avgtt";
            this.avgtt.Size = new System.Drawing.Size(100, 20);
            this.avgtt.TabIndex = 10;
            // 
            // m2t
            // 
            this.m2t.Location = new System.Drawing.Point(64, 55);
            this.m2t.Name = "m2t";
            this.m2t.Size = new System.Drawing.Size(100, 20);
            this.m2t.TabIndex = 11;
            // 
            // m3t
            // 
            this.m3t.Location = new System.Drawing.Point(64, 100);
            this.m3t.Name = "m3t";
            this.m3t.Size = new System.Drawing.Size(100, 20);
            this.m3t.TabIndex = 12;
            // 
            // m4t
            // 
            this.m4t.Location = new System.Drawing.Point(64, 142);
            this.m4t.Name = "m4t";
            this.m4t.Size = new System.Drawing.Size(100, 20);
            this.m4t.TabIndex = 13;
            // 
            // t1t
            // 
            this.t1t.Location = new System.Drawing.Point(64, 183);
            this.t1t.Name = "t1t";
            this.t1t.Size = new System.Drawing.Size(100, 20);
            this.t1t.TabIndex = 14;
            // 
            // clearbt
            // 
            this.clearbt.Location = new System.Drawing.Point(257, 179);
            this.clearbt.Name = "clearbt";
            this.clearbt.Size = new System.Drawing.Size(153, 23);
            this.clearbt.TabIndex = 15;
            this.clearbt.Text = "clear";
            this.clearbt.UseVisualStyleBackColor = true;
            this.clearbt.Click += new System.EventHandler(this.clearbt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 261);
            this.Controls.Add(this.clearbt);
            this.Controls.Add(this.t1t);
            this.Controls.Add(this.m4t);
            this.Controls.Add(this.m3t);
            this.Controls.Add(this.m2t);
            this.Controls.Add(this.avgtt);
            this.Controls.Add(this.t2tt);
            this.Controls.Add(this.m1t);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.avgt);
            this.Controls.Add(this.t2t);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label t2t;
        private System.Windows.Forms.Label avgt;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.TextBox m1t;
        private System.Windows.Forms.TextBox t2tt;
        private System.Windows.Forms.TextBox avgtt;
        private System.Windows.Forms.TextBox m2t;
        private System.Windows.Forms.TextBox m3t;
        private System.Windows.Forms.TextBox m4t;
        private System.Windows.Forms.TextBox t1t;
        private System.Windows.Forms.Button clearbt;
    }
}

