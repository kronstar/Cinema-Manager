
using QuanLyRapPhim.Additional;

namespace QuanLyRapPhim.GUI.frmUserControl
{
    partial class SelectSeatUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpClientInfo = new System.Windows.Forms.GroupBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSoldSeatColor = new System.Windows.Forms.Button();
            this.btnSelectSeatColor = new System.Windows.Forms.Button();
            this.btnSeatColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.grpTicketType = new System.Windows.Forms.GroupBox();
            this.txtTicketPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rdoStudent = new System.Windows.Forms.RadioButton();
            this.rdoAdult = new System.Windows.Forms.RadioButton();
            this.rdoChild = new System.Windows.Forms.RadioButton();
            this.flpSeat = new System.Windows.Forms.FlowLayoutPanel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grpClientInfo.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.grpTicketType.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpClientInfo);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.flpSeat);
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 672);
            this.panel1.TabIndex = 0;
            // 
            // grpClientInfo
            // 
            this.grpClientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpClientInfo.Controls.Add(this.txtClientName);
            this.grpClientInfo.Controls.Add(this.txtClientID);
            this.grpClientInfo.Controls.Add(this.label9);
            this.grpClientInfo.Controls.Add(this.txtPhoneNumber);
            this.grpClientInfo.Controls.Add(this.label8);
            this.grpClientInfo.Controls.Add(this.label2);
            this.grpClientInfo.Enabled = false;
            this.grpClientInfo.Location = new System.Drawing.Point(826, 100);
            this.grpClientInfo.Name = "grpClientInfo";
            this.grpClientInfo.Size = new System.Drawing.Size(337, 308);
            this.grpClientInfo.TabIndex = 6;
            this.grpClientInfo.TabStop = false;
            this.grpClientInfo.Text = "Thông tin khách hàng";
            // 
            // txtClientName
            // 
            this.txtClientName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientName.Location = new System.Drawing.Point(19, 234);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.ReadOnly = true;
            this.txtClientName.Size = new System.Drawing.Size(294, 30);
            this.txtClientName.TabIndex = 16;
            this.txtClientName.TabStop = false;
            // 
            // txtClientID
            // 
            this.txtClientID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientID.Location = new System.Drawing.Point(19, 157);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.ReadOnly = true;
            this.txtClientID.Size = new System.Drawing.Size(294, 30);
            this.txtClientID.TabIndex = 16;
            this.txtClientID.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Họ tên:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(19, 79);
            this.txtPhoneNumber.MaxLength = 10;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(294, 30);
            this.txtPhoneNumber.TabIndex = 16;
            this.txtPhoneNumber.TabStop = false;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số điện thoại:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSoldSeatColor);
            this.panel3.Controls.Add(this.btnSelectSeatColor);
            this.panel3.Controls.Add(this.btnSeatColor);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(106, 462);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(599, 51);
            this.panel3.TabIndex = 5;
            // 
            // btnSoldSeatColor
            // 
            this.btnSoldSeatColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.btnSoldSeatColor.Enabled = false;
            this.btnSoldSeatColor.FlatAppearance.BorderSize = 0;
            this.btnSoldSeatColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoldSeatColor.Location = new System.Drawing.Point(439, 8);
            this.btnSoldSeatColor.Name = "btnSoldSeatColor";
            this.btnSoldSeatColor.Size = new System.Drawing.Size(30, 30);
            this.btnSoldSeatColor.TabIndex = 8;
            this.btnSoldSeatColor.UseVisualStyleBackColor = false;
            // 
            // btnSelectSeatColor
            // 
            this.btnSelectSeatColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnSelectSeatColor.Enabled = false;
            this.btnSelectSeatColor.FlatAppearance.BorderSize = 0;
            this.btnSelectSeatColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectSeatColor.Location = new System.Drawing.Point(210, 7);
            this.btnSelectSeatColor.Name = "btnSelectSeatColor";
            this.btnSelectSeatColor.Size = new System.Drawing.Size(30, 30);
            this.btnSelectSeatColor.TabIndex = 8;
            this.btnSelectSeatColor.UseVisualStyleBackColor = false;
            // 
            // btnSeatColor
            // 
            this.btnSeatColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(125)))), ((int)(((byte)(168)))));
            this.btnSeatColor.Enabled = false;
            this.btnSeatColor.FlatAppearance.BorderSize = 0;
            this.btnSeatColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeatColor.Location = new System.Drawing.Point(4, 10);
            this.btnSeatColor.Name = "btnSeatColor";
            this.btnSeatColor.Size = new System.Drawing.Size(30, 30);
            this.btnSeatColor.TabIndex = 7;
            this.btnSeatColor.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ghế đã mua";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ghế đang chọn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ghế chưa mua";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.grpTicketType);
            this.panel2.Location = new System.Drawing.Point(3, 519);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 153);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCancel);
            this.panel4.Controls.Add(this.btnPay);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtAmount);
            this.panel4.Location = new System.Drawing.Point(819, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(341, 119);
            this.panel4.TabIndex = 17;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Location = new System.Drawing.Point(242, 65);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 45);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPay.Location = new System.Drawing.Point(105, 65);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(112, 45);
            this.btnPay.TabIndex = 2;
            this.btnPay.TabStop = false;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Thanh toán:";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(118, 12);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(208, 30);
            this.txtAmount.TabIndex = 16;
            this.txtAmount.TabStop = false;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpTicketType
            // 
            this.grpTicketType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpTicketType.Controls.Add(this.txtTicketPrice);
            this.grpTicketType.Controls.Add(this.label12);
            this.grpTicketType.Controls.Add(this.rdoStudent);
            this.grpTicketType.Controls.Add(this.rdoAdult);
            this.grpTicketType.Controls.Add(this.rdoChild);
            this.grpTicketType.Enabled = false;
            this.grpTicketType.Location = new System.Drawing.Point(3, 5);
            this.grpTicketType.Name = "grpTicketType";
            this.grpTicketType.Size = new System.Drawing.Size(361, 144);
            this.grpTicketType.TabIndex = 0;
            this.grpTicketType.TabStop = false;
            this.grpTicketType.Text = "Loại vé";
            // 
            // txtTicketPrice
            // 
            this.txtTicketPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketPrice.Location = new System.Drawing.Point(134, 89);
            this.txtTicketPrice.Name = "txtTicketPrice";
            this.txtTicketPrice.ReadOnly = true;
            this.txtTicketPrice.Size = new System.Drawing.Size(208, 30);
            this.txtTicketPrice.TabIndex = 16;
            this.txtTicketPrice.TabStop = false;
            this.txtTicketPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 23);
            this.label12.TabIndex = 15;
            this.label12.Text = "Giá vé:";
            // 
            // rdoStudent
            // 
            this.rdoStudent.AutoSize = true;
            this.rdoStudent.Location = new System.Drawing.Point(134, 29);
            this.rdoStudent.Name = "rdoStudent";
            this.rdoStudent.Size = new System.Drawing.Size(100, 27);
            this.rdoStudent.TabIndex = 13;
            this.rdoStudent.Text = "Sinh viên";
            this.rdoStudent.UseVisualStyleBackColor = true;
            this.rdoStudent.Click += new System.EventHandler(this.rdoStudent_Click);
            // 
            // rdoAdult
            // 
            this.rdoAdult.AutoSize = true;
            this.rdoAdult.Location = new System.Drawing.Point(6, 29);
            this.rdoAdult.Name = "rdoAdult";
            this.rdoAdult.Size = new System.Drawing.Size(107, 27);
            this.rdoAdult.TabIndex = 12;
            this.rdoAdult.Text = "Người lớn";
            this.rdoAdult.UseVisualStyleBackColor = true;
            this.rdoAdult.Click += new System.EventHandler(this.rdoAdult_Click);
            // 
            // rdoChild
            // 
            this.rdoChild.AutoSize = true;
            this.rdoChild.Location = new System.Drawing.Point(259, 29);
            this.rdoChild.Name = "rdoChild";
            this.rdoChild.Size = new System.Drawing.Size(83, 27);
            this.rdoChild.TabIndex = 11;
            this.rdoChild.Text = "Trẻ em";
            this.rdoChild.UseVisualStyleBackColor = true;
            this.rdoChild.Click += new System.EventHandler(this.rdoChild_Click);
            // 
            // flpSeat
            // 
            this.flpSeat.Location = new System.Drawing.Point(19, 56);
            this.flpSeat.Name = "flpSeat";
            this.flpSeat.Size = new System.Drawing.Size(800, 400);
            this.flpSeat.TabIndex = 2;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(15, 4);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(84, 23);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Thông tin";
            // 
            // SelectSeatUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SelectSeatUC";
            this.Size = new System.Drawing.Size(1182, 672);
            this.Load += new System.EventHandler(this.SelectSeatUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpClientInfo.ResumeLayout(false);
            this.grpClientInfo.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.grpTicketType.ResumeLayout(false);
            this.grpTicketType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flpSeat;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSelectSeatColor;
        private System.Windows.Forms.Button btnSeatColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpTicketType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rdoStudent;
        private System.Windows.Forms.RadioButton rdoAdult;
        private System.Windows.Forms.RadioButton rdoChild;
        private System.Windows.Forms.TextBox txtTicketPrice;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSoldSeatColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpClientInfo;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
    }
}
