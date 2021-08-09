
namespace Simple_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.tbxX = new System.Windows.Forms.TextBox();
            this.tbxY = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(141, 123);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(64, 15);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "Variable X: ";
            this.lblX.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(420, 123);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(61, 15);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Variable Y:";
            // 
            // tbxX
            // 
            this.tbxX.Location = new System.Drawing.Point(141, 153);
            this.tbxX.Name = "tbxX";
            this.tbxX.Size = new System.Drawing.Size(100, 23);
            this.tbxX.TabIndex = 2;
            // 
            // tbxY
            // 
            this.tbxY.Location = new System.Drawing.Point(420, 152);
            this.tbxY.Name = "tbxY";
            this.tbxY.Size = new System.Drawing.Size(100, 23);
            this.tbxY.TabIndex = 3;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(295, 275);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(49, 15);
            this.lblAnswer.TabIndex = 4;
            this.lblAnswer.Text = "Answer:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 309);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.tbxY);
            this.Controls.Add(this.tbxX);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox tbxX;
        private System.Windows.Forms.TextBox tbxY;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox textBox1;
    }
}

