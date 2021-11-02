
namespace QuanLyRapPhim.GUI.frmUserControl
{
    partial class SelectShowtimeUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lvwShowtime = new System.Windows.Forms.ListView();
            this.colCinemaRoom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 37;
            this.label1.Text = "Thời gian:";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.lvwShowtime);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1182, 672);
            this.pnlMain.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpDate);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 50);
            this.panel2.TabIndex = 47;
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(577, 17);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(132, 30);
            this.dtpDate.TabIndex = 45;
            this.dtpDate.TabStop = false;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // lvwShowtime
            // 
            this.lvwShowtime.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwShowtime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwShowtime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwShowtime.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCinemaRoom,
            this.colTitle,
            this.colTime,
            this.colStatus});
            this.lvwShowtime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwShowtime.FullRowSelect = true;
            this.lvwShowtime.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwShowtime.HideSelection = false;
            this.lvwShowtime.HoverSelection = true;
            this.lvwShowtime.LabelWrap = false;
            this.lvwShowtime.Location = new System.Drawing.Point(212, 91);
            this.lvwShowtime.MultiSelect = false;
            this.lvwShowtime.Name = "lvwShowtime";
            this.lvwShowtime.ShowItemToolTips = true;
            this.lvwShowtime.Size = new System.Drawing.Size(769, 528);
            this.lvwShowtime.TabIndex = 43;
            this.lvwShowtime.TabStop = false;
            this.lvwShowtime.UseCompatibleStateImageBehavior = false;
            this.lvwShowtime.View = System.Windows.Forms.View.Details;
            this.lvwShowtime.DoubleClick += new System.EventHandler(this.lvwShowtime_Click);
            // 
            // colCinemaRoom
            // 
            this.colCinemaRoom.Text = "Phòng chiếu";
            this.colCinemaRoom.Width = 150;
            // 
            // colTitle
            // 
            this.colTitle.Text = "Tên phim";
            this.colTitle.Width = 300;
            // 
            // colTime
            // 
            this.colTime.Text = "Thời gian chiếu";
            this.colTime.Width = 160;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Số vé";
            this.colStatus.Width = 160;
            // 
            // SelectShowtimeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SelectShowtimeUC";
            this.Size = new System.Drawing.Size(1182, 672);
            this.pnlMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ListView lvwShowtime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColumnHeader colCinemaRoom;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colTime;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.Panel panel2;
    }
}
