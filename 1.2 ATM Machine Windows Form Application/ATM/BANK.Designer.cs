
namespace ATM
{
    partial class BANK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BANK));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SIGNBTN = new System.Windows.Forms.Button();
            this.textPin = new System.Windows.Forms.TextBox();
            this.textUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.SIGNBTN);
            this.panel1.Controls.Add(this.textPin);
            this.panel1.Controls.Add(this.textUser);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 643);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(176)))));
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(176)))));
            this.panel3.Location = new System.Drawing.Point(211, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 64);
            this.panel3.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(176)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1087, 64);
            this.panel2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(345, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "WELCOME TO AL Rajhi Bank ";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(587, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 51);
            this.button2.TabIndex = 6;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SIGNBTN
            // 
            this.SIGNBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SIGNBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SIGNBTN.Location = new System.Drawing.Point(329, 382);
            this.SIGNBTN.Name = "SIGNBTN";
            this.SIGNBTN.Size = new System.Drawing.Size(153, 51);
            this.SIGNBTN.TabIndex = 5;
            this.SIGNBTN.Text = "SIGN IN";
            this.SIGNBTN.UseVisualStyleBackColor = true;
            this.SIGNBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // textPin
            // 
            this.textPin.Location = new System.Drawing.Point(329, 310);
            this.textPin.Multiline = true;
            this.textPin.Name = "textPin";
            this.textPin.Size = new System.Drawing.Size(411, 38);
            this.textPin.TabIndex = 4;
            this.textPin.TextChanged += new System.EventHandler(this.textPin_TextChanged);
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(329, 225);
            this.textUser.Multiline = true;
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(411, 38);
            this.textUser.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(228, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 38);
            this.label4.TabIndex = 2;
            this.label4.Text = "PIN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(180, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "User ID:";
            // 
            // BANK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1070, 565);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BANK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WELCOME TO AL Rajhi Bank ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SIGNBTN;
        private System.Windows.Forms.TextBox textPin;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}