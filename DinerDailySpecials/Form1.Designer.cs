namespace DinerDailySpecials
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
            this.txtEnterSpecial = new System.Windows.Forms.TextBox();
            this.btnGetSpecial = new System.Windows.Forms.Button();
            this.lblOutPut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a day number(1-7) to see our specials";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "For example Sunday = 1";
            // 
            // txtEnterSpecial
            // 
            this.txtEnterSpecial.Location = new System.Drawing.Point(191, 87);
            this.txtEnterSpecial.Name = "txtEnterSpecial";
            this.txtEnterSpecial.Size = new System.Drawing.Size(100, 20);
            this.txtEnterSpecial.TabIndex = 2;
            // 
            // btnGetSpecial
            // 
            this.btnGetSpecial.Location = new System.Drawing.Point(203, 135);
            this.btnGetSpecial.Name = "btnGetSpecial";
            this.btnGetSpecial.Size = new System.Drawing.Size(75, 23);
            this.btnGetSpecial.TabIndex = 3;
            this.btnGetSpecial.Text = "getSpecial";
            this.btnGetSpecial.UseVisualStyleBackColor = true;
            this.btnGetSpecial.Click += new System.EventHandler(this.btnGetSpecial_Click);
            // 
            // lblOutPut
            // 
            this.lblOutPut.AutoSize = true;
            this.lblOutPut.Location = new System.Drawing.Point(227, 187);
            this.lblOutPut.Name = "lblOutPut";
            this.lblOutPut.Size = new System.Drawing.Size(0, 13);
            this.lblOutPut.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutPut);
            this.Controls.Add(this.btnGetSpecial);
            this.Controls.Add(this.txtEnterSpecial);
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
        private System.Windows.Forms.TextBox txtEnterSpecial;
        private System.Windows.Forms.Button btnGetSpecial;
        private System.Windows.Forms.Label lblOutPut;
    }
}

