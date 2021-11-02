
namespace QuanLyRapPhim.GUI.frmUserControl
{
    partial class CinemaRoomUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbScreenType = new System.Windows.Forms.ComboBox();
            this.txtSeatPerRow = new System.Windows.Forms.TextBox();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtSeats = new System.Windows.Forms.TextBox();
            this.txtCinemaRoomName = new System.Windows.Forms.TextBox();
            this.txtCinemaRoomID = new System.Windows.Forms.TextBox();
            this.grpBtn = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCinemaRoom = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.grpBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCinemaRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbScreenType);
            this.panel2.Controls.Add(this.txtSeatPerRow);
            this.panel2.Controls.Add(this.txtRows);
            this.panel2.Controls.Add(this.txtStatus);
            this.panel2.Controls.Add(this.txtSeats);
            this.panel2.Controls.Add(this.txtCinemaRoomName);
            this.panel2.Controls.Add(this.txtCinemaRoomID);
            this.panel2.Controls.Add(this.grpBtn);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 672);
            this.panel2.TabIndex = 7;
            // 
            // cmbScreenType
            // 
            this.cmbScreenType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScreenType.FormattingEnabled = true;
            this.cmbScreenType.Location = new System.Drawing.Point(169, 109);
            this.cmbScreenType.Name = "cmbScreenType";
            this.cmbScreenType.Size = new System.Drawing.Size(165, 31);
            this.cmbScreenType.TabIndex = 13;
            this.cmbScreenType.TabStop = false;
            // 
            // txtSeatPerRow
            // 
            this.txtSeatPerRow.Location = new System.Drawing.Point(169, 243);
            this.txtSeatPerRow.Name = "txtSeatPerRow";
            this.txtSeatPerRow.Size = new System.Drawing.Size(165, 30);
            this.txtSeatPerRow.TabIndex = 12;
            this.txtSeatPerRow.TabStop = false;
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(169, 193);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(165, 30);
            this.txtRows.TabIndex = 12;
            this.txtRows.TabStop = false;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(169, 353);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(165, 30);
            this.txtStatus.TabIndex = 12;
            this.txtStatus.TabStop = false;
            // 
            // txtSeats
            // 
            this.txtSeats.Location = new System.Drawing.Point(169, 292);
            this.txtSeats.Name = "txtSeats";
            this.txtSeats.Size = new System.Drawing.Size(165, 30);
            this.txtSeats.TabIndex = 12;
            this.txtSeats.TabStop = false;
            // 
            // txtCinemaRoomName
            // 
            this.txtCinemaRoomName.Location = new System.Drawing.Point(169, 63);
            this.txtCinemaRoomName.Name = "txtCinemaRoomName";
            this.txtCinemaRoomName.Size = new System.Drawing.Size(165, 30);
            this.txtCinemaRoomName.TabIndex = 12;
            this.txtCinemaRoomName.TabStop = false;
            // 
            // txtCinemaRoomID
            // 
            this.txtCinemaRoomID.Location = new System.Drawing.Point(169, 14);
            this.txtCinemaRoomID.Name = "txtCinemaRoomID";
            this.txtCinemaRoomID.Size = new System.Drawing.Size(165, 30);
            this.txtCinemaRoomID.TabIndex = 12;
            this.txtCinemaRoomID.TabStop = false;
            // 
            // grpBtn
            // 
            this.grpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBtn.Controls.Add(this.btnEdit);
            this.grpBtn.Controls.Add(this.btnDelete);
            this.grpBtn.Controls.Add(this.btnAdd);
            this.grpBtn.Location = new System.Drawing.Point(22, 572);
            this.grpBtn.Name = "grpBtn";
            this.grpBtn.Size = new System.Drawing.Size(312, 79);
            this.grpBtn.TabIndex = 11;
            this.grpBtn.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.Location = new System.Drawing.Point(208, 20);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 45);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Location = new System.Drawing.Point(110, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 45);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Location = new System.Drawing.Point(12, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 45);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số ghế mỗi hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số hàng ghế:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tình trạng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số chỗ ngồi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Màn hình:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng:";
            // 
            // dgvCinemaRoom
            // 
            this.dgvCinemaRoom.AllowUserToAddRows = false;
            this.dgvCinemaRoom.AllowUserToDeleteRows = false;
            this.dgvCinemaRoom.AllowUserToOrderColumns = true;
            this.dgvCinemaRoom.AllowUserToResizeColumns = false;
            this.dgvCinemaRoom.AllowUserToResizeRows = false;
            this.dgvCinemaRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCinemaRoom.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCinemaRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCinemaRoom.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCinemaRoom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCinemaRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCinemaRoom.ColumnHeadersHeight = 40;
            this.dgvCinemaRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(219)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCinemaRoom.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCinemaRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCinemaRoom.EnableHeadersVisualStyles = false;
            this.dgvCinemaRoom.Location = new System.Drawing.Point(350, 0);
            this.dgvCinemaRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCinemaRoom.MultiSelect = false;
            this.dgvCinemaRoom.Name = "dgvCinemaRoom";
            this.dgvCinemaRoom.ReadOnly = true;
            this.dgvCinemaRoom.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCinemaRoom.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCinemaRoom.RowHeadersVisible = false;
            this.dgvCinemaRoom.RowHeadersWidth = 51;
            this.dgvCinemaRoom.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCinemaRoom.RowTemplate.Height = 40;
            this.dgvCinemaRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCinemaRoom.Size = new System.Drawing.Size(832, 672);
            this.dgvCinemaRoom.TabIndex = 5;
            this.dgvCinemaRoom.TabStop = false;
            // 
            // CinemaRoomUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCinemaRoom);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CinemaRoomUC";
            this.Size = new System.Drawing.Size(1182, 672);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCinemaRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbScreenType;
        private System.Windows.Forms.TextBox txtCinemaRoomID;
        private System.Windows.Forms.GroupBox grpBtn;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCinemaRoom;
        private System.Windows.Forms.TextBox txtCinemaRoomName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSeatPerRow;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtSeats;
    }
}
