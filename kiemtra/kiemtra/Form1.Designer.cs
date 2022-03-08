
namespace kiemtra
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
            if (disposing && (components != null)) {
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
            this.textboxusername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxmatkhau = new System.Windows.Forms.TextBox();
            this.btblogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập";
            // 
            // textboxusername
            // 
            this.textboxusername.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxusername.Location = new System.Drawing.Point(305, 121);
            this.textboxusername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxusername.Name = "textboxusername";
            this.textboxusername.Size = new System.Drawing.Size(417, 44);
            this.textboxusername.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // textboxmatkhau
            // 
            this.textboxmatkhau.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxmatkhau.Location = new System.Drawing.Point(305, 220);
            this.textboxmatkhau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxmatkhau.Name = "textboxmatkhau";
            this.textboxmatkhau.PasswordChar = '*';
            this.textboxmatkhau.Size = new System.Drawing.Size(417, 44);
            this.textboxmatkhau.TabIndex = 3;
            // 
            // btblogin
            // 
            this.btblogin.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btblogin.Location = new System.Drawing.Point(357, 315);
            this.btblogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btblogin.Name = "btblogin";
            this.btblogin.Size = new System.Drawing.Size(214, 61);
            this.btblogin.TabIndex = 4;
            this.btblogin.Text = "Đăng nhập";
            this.btblogin.UseVisualStyleBackColor = true;
            this.btblogin.Click += new System.EventHandler(this.btblogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 469);
            this.Controls.Add(this.btblogin);
            this.Controls.Add(this.textboxmatkhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textboxusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxusername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxmatkhau;
        private System.Windows.Forms.Button btblogin;
    }
}

