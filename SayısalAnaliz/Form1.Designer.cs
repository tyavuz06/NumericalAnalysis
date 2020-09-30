namespace SayısalAnaliz
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBiSection = new System.Windows.Forms.Button();
            this.btnGoldenRate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(285, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = " NEWTON RAPHSON ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Numerical Analysis";
            // 
            // btnBiSection
            // 
            this.btnBiSection.BackColor = System.Drawing.Color.Transparent;
            this.btnBiSection.Location = new System.Drawing.Point(285, 205);
            this.btnBiSection.Name = "btnBiSection";
            this.btnBiSection.Size = new System.Drawing.Size(157, 36);
            this.btnBiSection.TabIndex = 2;
            this.btnBiSection.Text = "BiSection";
            this.btnBiSection.UseVisualStyleBackColor = false;
            this.btnBiSection.Click += new System.EventHandler(this.btnBiSection_Click);
            // 
            // btnGoldenRate
            // 
            this.btnGoldenRate.BackColor = System.Drawing.Color.Transparent;
            this.btnGoldenRate.Location = new System.Drawing.Point(285, 247);
            this.btnGoldenRate.Name = "btnGoldenRate";
            this.btnGoldenRate.Size = new System.Drawing.Size(157, 36);
            this.btnGoldenRate.TabIndex = 3;
            this.btnGoldenRate.Text = "Golden Rate";
            this.btnGoldenRate.UseVisualStyleBackColor = false;
            this.btnGoldenRate.Click += new System.EventHandler(this.btnGoldenRate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SayısalAnaliz.Properties.Resources.math1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 420);
            this.Controls.Add(this.btnGoldenRate);
            this.Controls.Add(this.btnBiSection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBiSection;
        private System.Windows.Forms.Button btnGoldenRate;
    }
}

