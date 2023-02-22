namespace LinearRegression
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
            this.Openprice = new System.Windows.Forms.TextBox();
            this.HighPrice = new System.Windows.Forms.TextBox();
            this.LowPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PredictedClose = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Openprice
            // 
            this.Openprice.Location = new System.Drawing.Point(110, 31);
            this.Openprice.Name = "Openprice";
            this.Openprice.Size = new System.Drawing.Size(144, 22);
            this.Openprice.TabIndex = 1;
            // 
            // HighPrice
            // 
            this.HighPrice.Location = new System.Drawing.Point(110, 69);
            this.HighPrice.Name = "HighPrice";
            this.HighPrice.Size = new System.Drawing.Size(144, 22);
            this.HighPrice.TabIndex = 2;
            // 
            // LowPrice
            // 
            this.LowPrice.Location = new System.Drawing.Point(110, 111);
            this.LowPrice.Name = "LowPrice";
            this.LowPrice.Size = new System.Drawing.Size(144, 22);
            this.LowPrice.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Open Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Low Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Predicted Close:";
            // 
            // PredictedClose
            // 
            this.PredictedClose.AutoSize = true;
            this.PredictedClose.Location = new System.Drawing.Point(137, 236);
            this.PredictedClose.Name = "PredictedClose";
            this.PredictedClose.Size = new System.Drawing.Size(0, 16);
            this.PredictedClose.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "High Price:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 287);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PredictedClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LowPrice);
            this.Controls.Add(this.HighPrice);
            this.Controls.Add(this.Openprice);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Linear Regression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Openprice;
        private System.Windows.Forms.TextBox HighPrice;
        private System.Windows.Forms.TextBox LowPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PredictedClose;
        private System.Windows.Forms.Label label2;
    }
}

