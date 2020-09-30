namespace SayısalAnaliz
{
    partial class BiSection
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
            this.txtRootStart = new System.Windows.Forms.TextBox();
            this.txtRootFinish = new System.Windows.Forms.TextBox();
            this.txtTolerance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRootStart
            // 
            this.txtRootStart.Location = new System.Drawing.Point(195, 135);
            this.txtRootStart.Name = "txtRootStart";
            this.txtRootStart.Size = new System.Drawing.Size(127, 20);
            this.txtRootStart.TabIndex = 0;
            // 
            // txtRootFinish
            // 
            this.txtRootFinish.Location = new System.Drawing.Point(195, 161);
            this.txtRootFinish.Name = "txtRootFinish";
            this.txtRootFinish.Size = new System.Drawing.Size(127, 20);
            this.txtRootFinish.TabIndex = 1;
            // 
            // txtTolerance
            // 
            this.txtTolerance.Location = new System.Drawing.Point(195, 187);
            this.txtTolerance.Name = "txtTolerance";
            this.txtTolerance.Size = new System.Drawing.Size(127, 20);
            this.txtTolerance.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "End value for root";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Initial value for root";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tolerance Value";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(220, 224);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(138, 266);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(222, 147);
            this.listBox1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Write down the formula for \'e\'";
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(195, 108);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(127, 20);
            this.txtE.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Write down the formula for X";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(195, 55);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(127, 20);
            this.txtX.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(28, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 16);
            this.label9.TabIndex = 37;
            this.label9.Text = "EG: 3_3;2_4 =>3x^3+2x^4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(48, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(381, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Write \'factor\' after that power for \'e\'. e.g : 2_3;1_4 => 2e^3x +e^4x";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(28, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(483, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "Write \'factor\' after that write \'power\'. You can write what you want  with \';\' se" +
    "perate. ";
            // 
            // BiSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 475);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTolerance);
            this.Controls.Add(this.txtRootFinish);
            this.Controls.Add(this.txtRootStart);
            this.Name = "BiSection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BiSection";
            this.Load += new System.EventHandler(this.BiSection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRootStart;
        private System.Windows.Forms.TextBox txtRootFinish;
        private System.Windows.Forms.TextBox txtTolerance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}