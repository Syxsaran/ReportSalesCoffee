﻿namespace ReportSalesCoffee
{
    partial class Form2
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
            this.radioButtonCoffee = new System.Windows.Forms.RadioButton();
            this.radioButtonSweet = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButtonCoffee
            // 
            this.radioButtonCoffee.AutoSize = true;
            this.radioButtonCoffee.Location = new System.Drawing.Point(46, 66);
            this.radioButtonCoffee.Name = "radioButtonCoffee";
            this.radioButtonCoffee.Size = new System.Drawing.Size(51, 19);
            this.radioButtonCoffee.TabIndex = 0;
            this.radioButtonCoffee.TabStop = true;
            this.radioButtonCoffee.Text = "กาแฟ";
            this.radioButtonCoffee.UseVisualStyleBackColor = true;
            // 
            // radioButtonSweet
            // 
            this.radioButtonSweet.AutoSize = true;
            this.radioButtonSweet.Location = new System.Drawing.Point(119, 66);
            this.radioButtonSweet.Name = "radioButtonSweet";
            this.radioButtonSweet.Size = new System.Drawing.Size(67, 19);
            this.radioButtonSweet.TabIndex = 1;
            this.radioButtonSweet.TabStop = true;
            this.radioButtonSweet.Text = "ของหวาน";
            this.radioButtonSweet.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "ยืนยัน";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "เลือกประเภทสินค้า";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(226, 177);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonSweet);
            this.Controls.Add(this.radioButtonCoffee);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton radioButtonCoffee;
        private RadioButton radioButtonSweet;
        private Button button1;
        private Label label1;
    }
}