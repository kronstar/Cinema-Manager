
namespace QuanLyRapPhim.GUI
{
    partial class frmHomepage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomepage));
            this.mnsAdmin = new System.Windows.Forms.MenuStrip();
            this.tsmiSell = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManager = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMovieFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowtime = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTicket = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiScreenType = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCinemaRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGenre = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExplore = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClient = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStatistical = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.mnsAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsAdmin
            // 
            this.mnsAdmin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnsAdmin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSell,
            this.tsmiManager,
            this.tsmiExplore,
            this.tsmiStatistical,
            this.tsmiLogout});
            this.mnsAdmin.Location = new System.Drawing.Point(0, 0);
            this.mnsAdmin.Name = "mnsAdmin";
            this.mnsAdmin.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnsAdmin.Size = new System.Drawing.Size(1182, 30);
            this.mnsAdmin.TabIndex = 0;
            this.mnsAdmin.Text = "menuStrip1";
            // 
            // tsmiSell
            // 
            this.tsmiSell.Name = "tsmiSell";
            this.tsmiSell.Size = new System.Drawing.Size(66, 26);
            this.tsmiSell.Text = "Đặt vé";
            this.tsmiSell.Click += new System.EventHandler(this.tsmiSell_Click);
            // 
            // tsmiManager
            // 
            this.tsmiManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMovie,
            this.tsmiMovieFormat,
            this.tsmiShowtime,
            this.tsmiTicket,
            this.toolStripSeparator1,
            this.tsmiScreenType,
            this.tsmiCinemaRoom,
            this.tsmiGenre});
            this.tsmiManager.Name = "tsmiManager";
            this.tsmiManager.Size = new System.Drawing.Size(73, 26);
            this.tsmiManager.Text = "Quản lý";
            // 
            // tsmiMovie
            // 
            this.tsmiMovie.Name = "tsmiMovie";
            this.tsmiMovie.Size = new System.Drawing.Size(185, 26);
            this.tsmiMovie.Text = "Phim";
            this.tsmiMovie.Click += new System.EventHandler(this.tsmiMovie_Click);
            // 
            // tsmiMovieFormat
            // 
            this.tsmiMovieFormat.Name = "tsmiMovieFormat";
            this.tsmiMovieFormat.Size = new System.Drawing.Size(185, 26);
            this.tsmiMovieFormat.Text = "Định dạng";
            this.tsmiMovieFormat.Click += new System.EventHandler(this.tsmiMovieFormat_Click);
            // 
            // tsmiShowtime
            // 
            this.tsmiShowtime.Name = "tsmiShowtime";
            this.tsmiShowtime.Size = new System.Drawing.Size(185, 26);
            this.tsmiShowtime.Text = "Lịch chiếu";
            this.tsmiShowtime.Click += new System.EventHandler(this.tsmiShowtime_Click);
            // 
            // tsmiTicket
            // 
            this.tsmiTicket.Name = "tsmiTicket";
            this.tsmiTicket.Size = new System.Drawing.Size(185, 26);
            this.tsmiTicket.Text = "Vé";
            this.tsmiTicket.Click += new System.EventHandler(this.tsmiTicket_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // tsmiScreenType
            // 
            this.tsmiScreenType.Name = "tsmiScreenType";
            this.tsmiScreenType.Size = new System.Drawing.Size(185, 26);
            this.tsmiScreenType.Text = "Loại màn hình";
            this.tsmiScreenType.Click += new System.EventHandler(this.tsmiScreenType_Click);
            // 
            // tsmiCinemaRoom
            // 
            this.tsmiCinemaRoom.Name = "tsmiCinemaRoom";
            this.tsmiCinemaRoom.Size = new System.Drawing.Size(185, 26);
            this.tsmiCinemaRoom.Text = "Phòng chiếu";
            this.tsmiCinemaRoom.Click += new System.EventHandler(this.tsmiCinemaRoom_Click);
            // 
            // tsmiGenre
            // 
            this.tsmiGenre.Name = "tsmiGenre";
            this.tsmiGenre.Size = new System.Drawing.Size(185, 26);
            this.tsmiGenre.Text = "Thể loại";
            this.tsmiGenre.Click += new System.EventHandler(this.tsmiGenre_Click);
            // 
            // tsmiExplore
            // 
            this.tsmiExplore.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStaff,
            this.tsmiClient});
            this.tsmiExplore.Name = "tsmiExplore";
            this.tsmiExplore.Size = new System.Drawing.Size(80, 26);
            this.tsmiExplore.Text = "Mở rộng";
            // 
            // tsmiStaff
            // 
            this.tsmiStaff.Name = "tsmiStaff";
            this.tsmiStaff.Size = new System.Drawing.Size(169, 26);
            this.tsmiStaff.Text = "Nhân viên";
            this.tsmiStaff.Click += new System.EventHandler(this.tsmiStaff_Click);
            // 
            // tsmiClient
            // 
            this.tsmiClient.Name = "tsmiClient";
            this.tsmiClient.Size = new System.Drawing.Size(169, 26);
            this.tsmiClient.Text = "Khách hàng";
            this.tsmiClient.Click += new System.EventHandler(this.tsmiClient_Click);
            // 
            // tsmiStatistical
            // 
            this.tsmiStatistical.Name = "tsmiStatistical";
            this.tsmiStatistical.Size = new System.Drawing.Size(84, 26);
            this.tsmiStatistical.Text = "Thống kê";
            this.tsmiStatistical.Click += new System.EventHandler(this.tsmiStatistical_Click);
            // 
            // tsmiLogout
            // 
            this.tsmiLogout.Name = "tsmiLogout";
            this.tsmiLogout.Size = new System.Drawing.Size(91, 26);
            this.tsmiLogout.Text = "Đăng xuất";
            this.tsmiLogout.Click += new System.EventHandler(this.frmHomepage_Load);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 30);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1182, 673);
            this.pnlMain.TabIndex = 1;
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.SystemColors.Control;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Color2 = System.Drawing.SystemColors.Control;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.SystemColors.Control;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Color2 = System.Drawing.SystemColors.Control;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Back.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Back.Color2 = System.Drawing.SystemColors.Control;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Border.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Border.Color2 = System.Drawing.SystemColors.Control;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.Color2 = System.Drawing.SystemColors.Control;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Border.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Border.Color2 = System.Drawing.SystemColors.Control;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.SystemColors.Control;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.SystemColors.Control;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.SystemColors.Control;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = System.Drawing.SystemColors.Control;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(2);
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None;
            // 
            // frmHomepage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.mnsAdmin);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsAdmin;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1200, 750);
            this.Name = "frmHomepage";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý rạp phim";
            this.Load += new System.EventHandler(this.frmHomepage_Load);
            this.mnsAdmin.ResumeLayout(false);
            this.mnsAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsAdmin;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiStatistical;
        private System.Windows.Forms.ToolStripMenuItem tsmiManager;
        private System.Windows.Forms.ToolStripMenuItem tsmiMovie;
        private System.Windows.Forms.ToolStripMenuItem tsmiMovieFormat;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowtime;
        private System.Windows.Forms.ToolStripMenuItem tsmiExplore;
        private System.Windows.Forms.ToolStripMenuItem tsmiTicket;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiScreenType;
        private System.Windows.Forms.ToolStripMenuItem tsmiCinemaRoom;
        private System.Windows.Forms.ToolStripMenuItem tsmiGenre;
        private System.Windows.Forms.ToolStripMenuItem tsmiStaff;
        private System.Windows.Forms.ToolStripMenuItem tsmiClient;
        private System.Windows.Forms.ToolStripMenuItem tsmiSell;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogout;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
    }
}