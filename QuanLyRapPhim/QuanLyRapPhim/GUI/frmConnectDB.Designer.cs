
namespace QuanLyRapPhim.GUI
{
    partial class frmConnectDB
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
            this.btnCheckConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCheckConnect
            // 
            this.btnCheckConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnCheckConnect.FlatAppearance.BorderSize = 0;
            this.btnCheckConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckConnect.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCheckConnect.Location = new System.Drawing.Point(130, 162);
            this.btnCheckConnect.Name = "btnCheckConnect";
            this.btnCheckConnect.Size = new System.Drawing.Size(181, 44);
            this.btnCheckConnect.TabIndex = 0;
            this.btnCheckConnect.TabStop = false;
            this.btnCheckConnect.Text = "Kiểm tra kết nối";
            this.btnCheckConnect.UseVisualStyleBackColor = false;
            this.btnCheckConnect.Click += new System.EventHandler(this.btnCheckConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên máy chủ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên cơ sở dữ liệu:";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(184, 31);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(202, 30);
            this.txtServerName.TabIndex = 1;
            // 
            // txtDBName
            // 
            this.txtDBName.Location = new System.Drawing.Point(184, 97);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(202, 30);
            this.txtDBName.TabIndex = 2;
            // 
            // frmConnectDB
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(433, 236);
            this.Controls.Add(this.txtDBName);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheckConnect);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConnectDB";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết nối cơ sở dữ liệu";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.AcceptButton = this.btnCheckConnect;

        }

        #endregion

        private System.Windows.Forms.Button btnCheckConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.TextBox txtDBName;
    }
}