
namespace TicTacToe
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.lblplx = new System.Windows.Forms.Label();
            this.newgamebtn = new System.Windows.Forms.Button();
            this.lblplo = new System.Windows.Forms.Label();
            this.resetbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 112);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(311, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 112);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(476, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 112);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(156, 119);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 112);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(311, 119);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 112);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(476, 119);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 112);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(156, 252);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(122, 112);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(311, 252);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(122, 112);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(476, 252);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(122, 112);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // lblplx
            // 
            this.lblplx.AutoSize = true;
            this.lblplx.Location = new System.Drawing.Point(214, 383);
            this.lblplx.Name = "lblplx";
            this.lblplx.Size = new System.Drawing.Size(17, 20);
            this.lblplx.TabIndex = 9;
            this.lblplx.Text = "0";
            this.lblplx.Click += new System.EventHandler(this.label1_Click);
            // 
            // newgamebtn
            // 
            this.newgamebtn.Location = new System.Drawing.Point(156, 424);
            this.newgamebtn.Name = "newgamebtn";
            this.newgamebtn.Size = new System.Drawing.Size(199, 63);
            this.newgamebtn.TabIndex = 10;
            this.newgamebtn.Text = "New Game";
            this.newgamebtn.UseVisualStyleBackColor = true;
            this.newgamebtn.Click += new System.EventHandler(this.newgamebtn_Click);
            // 
            // lblplo
            // 
            this.lblplo.AutoSize = true;
            this.lblplo.Location = new System.Drawing.Point(440, 383);
            this.lblplo.Name = "lblplo";
            this.lblplo.Size = new System.Drawing.Size(17, 20);
            this.lblplo.TabIndex = 11;
            this.lblplo.Text = "0";
            // 
            // resetbtn
            // 
            this.resetbtn.Location = new System.Drawing.Point(394, 424);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(204, 63);
            this.resetbtn.TabIndex = 12;
            this.resetbtn.Text = "Reset";
            this.resetbtn.UseVisualStyleBackColor = true;
            this.resetbtn.Click += new System.EventHandler(this.resetgme_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.lblplo);
            this.Controls.Add(this.newgamebtn);
            this.Controls.Add(this.lblplx);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label lblplx;
        private System.Windows.Forms.Button newgamebtn;
        private System.Windows.Forms.Label lblplo;
        private System.Windows.Forms.Button resetbtn;
    }
}

