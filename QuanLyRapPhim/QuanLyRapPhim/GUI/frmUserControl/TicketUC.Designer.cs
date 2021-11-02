
namespace QuanLyRapPhim.GUI.frmUserControl
{
    partial class TicketUC
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvwShowtimeList = new System.Windows.Forms.ListView();
            this.colCinemaRoom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colShowDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCreateTicket = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteTicket = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowSoldTicket = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowAllTicket = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowtimeNotCreateTicket = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAllShowtime = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTicket = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.cmsClick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvwShowtimeList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 672);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // lvwShowtimeList
            // 
            this.lvwShowtimeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwShowtimeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCinemaRoom,
            this.colTitle,
            this.colShowDate,
            this.colStatus});
            this.lvwShowtimeList.ContextMenuStrip = this.cmsClick;
            this.lvwShowtimeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwShowtimeList.FullRowSelect = true;
            this.lvwShowtimeList.GridLines = true;
            this.lvwShowtimeList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwShowtimeList.HideSelection = false;
            this.lvwShowtimeList.Location = new System.Drawing.Point(0, 0);
            this.lvwShowtimeList.Name = "lvwShowtimeList";
            this.lvwShowtimeList.Size = new System.Drawing.Size(642, 672);
            this.lvwShowtimeList.TabIndex = 1;
            this.lvwShowtimeList.TabStop = false;
            this.lvwShowtimeList.UseCompatibleStateImageBehavior = false;
            this.lvwShowtimeList.View = System.Windows.Forms.View.Details;
            // 
            // colCinemaRoom
            // 
            this.colCinemaRoom.Text = "Phòng chiếu";
            this.colCinemaRoom.Width = 110;
            // 
            // colTitle
            // 
            this.colTitle.Text = "Tên phim";
            this.colTitle.Width = 250;
            // 
            // colShowDate
            // 
            this.colShowDate.Text = "Thời gian chiếu";
            this.colShowDate.Width = 180;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Trạng thái";
            this.colStatus.Width = 100;
            // 
            // cmsClick
            // 
            this.cmsClick.DropShadowEnabled = false;
            this.cmsClick.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsClick.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreateTicket,
            this.tsmiDeleteTicket,
            this.tsmiShowSoldTicket,
            this.tsmiShowAllTicket,
            this.tsmiShowtimeNotCreateTicket,
            this.tsmiAllShowtime});
            this.cmsClick.Name = "cmsShowMenu";
            this.cmsClick.Size = new System.Drawing.Size(205, 172);
            this.cmsClick.Text = "Công cụ";
            // 
            // tsmiCreateTicket
            // 
            this.tsmiCreateTicket.Name = "tsmiCreateTicket";
            this.tsmiCreateTicket.Size = new System.Drawing.Size(204, 28);
            this.tsmiCreateTicket.Text = "Tạo vé";
            this.tsmiCreateTicket.Click += new System.EventHandler(this.tsmiCreateTicket_Click);
            // 
            // tsmiDeleteTicket
            // 
            this.tsmiDeleteTicket.Name = "tsmiDeleteTicket";
            this.tsmiDeleteTicket.Size = new System.Drawing.Size(204, 28);
            this.tsmiDeleteTicket.Text = "Xoá vé";
            this.tsmiDeleteTicket.Click += new System.EventHandler(this.tsmiDeleteTicket_Click);
            // 
            // tsmiShowSoldTicket
            // 
            this.tsmiShowSoldTicket.Name = "tsmiShowSoldTicket";
            this.tsmiShowSoldTicket.Size = new System.Drawing.Size(204, 28);
            this.tsmiShowSoldTicket.Text = "Xem vé đã bán";
            this.tsmiShowSoldTicket.Click += new System.EventHandler(this.tsmiShowSoldTicket_Click);
            // 
            // tsmiShowAllTicket
            // 
            this.tsmiShowAllTicket.Name = "tsmiShowAllTicket";
            this.tsmiShowAllTicket.Size = new System.Drawing.Size(204, 28);
            this.tsmiShowAllTicket.Text = "Xem tất cả vé";
            this.tsmiShowAllTicket.Click += new System.EventHandler(this.tsmiShowAllTicket_Click);
            // 
            // tsmiShowtimeNotCreateTicket
            // 
            this.tsmiShowtimeNotCreateTicket.Name = "tsmiShowtimeNotCreateTicket";
            this.tsmiShowtimeNotCreateTicket.Size = new System.Drawing.Size(204, 28);
            this.tsmiShowtimeNotCreateTicket.Text = "Lịch chưa tạo vé";
            this.tsmiShowtimeNotCreateTicket.Click += new System.EventHandler(this.tsmiShowtimeNotCreate_Click);
            // 
            // tsmiAllShowtime
            // 
            this.tsmiAllShowtime.Name = "tsmiAllShowtime";
            this.tsmiAllShowtime.Size = new System.Drawing.Size(204, 28);
            this.tsmiAllShowtime.Text = "Tất cả lịch chiếu";
            this.tsmiAllShowtime.Click += new System.EventHandler(this.tsmiAllShowtime_Click);
            // 
            // dgvTicket
            // 
            this.dgvTicket.AllowUserToAddRows = false;
            this.dgvTicket.AllowUserToDeleteRows = false;
            this.dgvTicket.AllowUserToOrderColumns = true;
            this.dgvTicket.AllowUserToResizeColumns = false;
            this.dgvTicket.AllowUserToResizeRows = false;
            this.dgvTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTicket.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTicket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTicket.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTicket.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTicket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTicket.ColumnHeadersHeight = 40;
            this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(219)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTicket.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTicket.EnableHeadersVisualStyles = false;
            this.dgvTicket.Location = new System.Drawing.Point(642, 0);
            this.dgvTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTicket.MultiSelect = false;
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.ReadOnly = true;
            this.dgvTicket.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTicket.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTicket.RowHeadersVisible = false;
            this.dgvTicket.RowHeadersWidth = 51;
            this.dgvTicket.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTicket.RowTemplate.Height = 40;
            this.dgvTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTicket.Size = new System.Drawing.Size(540, 672);
            this.dgvTicket.TabIndex = 42;
            this.dgvTicket.TabStop = false;
            // 
            // TicketUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTicket);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TicketUC";
            this.Size = new System.Drawing.Size(1182, 672);
            this.panel1.ResumeLayout(false);
            this.cmsClick.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTicket;
        private System.Windows.Forms.ListView lvwShowtimeList;
        private System.Windows.Forms.ColumnHeader colCinemaRoom;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colShowDate;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreateTicket;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteTicket;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowSoldTicket;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowAllTicket;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowtimeNotCreateTicket;
        private System.Windows.Forms.ToolStripMenuItem tsmiAllShowtime;
        private System.Windows.Forms.ContextMenuStrip cmsClick;
    }
}
