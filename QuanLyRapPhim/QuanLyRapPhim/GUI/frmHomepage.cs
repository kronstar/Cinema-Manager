using QuanLyRapPhim.DTO;
using QuanLyRapPhim.GUI.frmUserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace QuanLyRapPhim.GUI
{
    public partial class frmHomepage : KryptonForm
    {
        //public event successLogin successLogin;
        public frmHomepage()
        {
            InitializeComponent();
        }

        private void tsmiSell_Click(object sender, EventArgs e)
        {
            this.Text = "Đặt vé";
            pnlMain.Controls.Clear();
            SelectShowtimeUC sellUC = new SelectShowtimeUC();
            sellUC.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(sellUC);
        }

        private void tsmiMovie_Click(object sender, EventArgs e)
        {
            this.Text = "Quản lý rạp phim - Quản lý phim";
            pnlMain.Controls.Clear();
            MovieUC movieUC = new MovieUC();
            movieUC.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(movieUC);
        }

        private void tsmiMovieFormat_Click(object sender, EventArgs e)
        {
            this.Text = "Quản lý rạp phim - Quản lý dịnh dạng phim";
            pnlMain.Controls.Clear();
            MovieFormatUC movieFormatUC = new MovieFormatUC();
            movieFormatUC.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(movieFormatUC);
        }

        private void tsmiShowtime_Click(object sender, EventArgs e)
        {
            this.Text = "Quản lý rạp phim - Quản lý lịch chiếu";
            pnlMain.Controls.Clear();
            ShowtimeUC showtimeUC = new ShowtimeUC();
            showtimeUC.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(showtimeUC);
        }

        private void tsmiTicket_Click(object sender, EventArgs e)
        {
            this.Text = "Quản lý rạp phim - Quản lý vé";
            pnlMain.Controls.Clear();
            TicketUC ticketUC = new TicketUC();
            ticketUC.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(ticketUC);
        }

        private void tsmiScreenType_Click(object sender, EventArgs e)
        {
            this.Text = "Quản lý rạp phim - Quản lý loại màn hình";
            pnlMain.Controls.Clear();
            ScreenTypeUC screenTypeUC = new ScreenTypeUC();
            screenTypeUC.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(screenTypeUC);
        }

        private void tsmiCinemaRoom_Click(object sender, EventArgs e)
        {
            this.Text = "Quản lý rạp phim - Quản lý phòng chiếu";
            pnlMain.Controls.Clear();
            CinemaRoomUC cinemaRoomUC = new CinemaRoomUC();
            cinemaRoomUC.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(cinemaRoomUC);
        }

        private void tsmiGenre_Click(object sender, EventArgs e)
        {
            this.Text = "Quản lý rạp phim - Quản lý thể loại";
            pnlMain.Controls.Clear();
            GenreUC genreUC = new GenreUC();
            genreUC.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(genreUC);
        }

        private void tsmiStaff_Click(object sender, EventArgs e)
        {
            this.Text = "Quản lý rạp phim - Quản lý nhân viên";
            pnlMain.Controls.Clear();
            StaffUC staffUC = new StaffUC();
            staffUC.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(staffUC);
        }

        private void tsmiClient_Click(object sender, EventArgs e)
        {
            this.Text = "Quản lý rạp phim - Quản lý khách hàng";
            pnlMain.Controls.Clear();
            ClientUC clientUC = new ClientUC();
            clientUC.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(clientUC);
        }

        //private void tsmiAccount_Click(object sender, EventArgs e)
        //{
        //    this.Text = "Quản lý rạp phim - Quản lý tài khoản";
        //    pnlMain.Controls.Clear();
        //    AccountUC accountUC = new AccountUC();
        //    accountUC.Dock = DockStyle.Fill;
        //    pnlMain.Controls.Add(accountUC);
        //}

        private void tsmiStatistical_Click(object sender, EventArgs e)
        {
            this.Text = "Quản lý rạp phim - Thống kê";
            pnlMain.Controls.Clear();
            StatisticalUC statisticalUC = new StatisticalUC();
            statisticalUC.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(statisticalUC);
        }

        private void frmHomepage_Load(object sender, EventArgs e)
        {
            this.Text = "Đăng nhập hệ thống";
            pnlMain.Controls.Clear();
            frmLogin frmLogin = new frmLogin();

            frmLogin.TopLevel = false;
            frmLogin.AutoScroll = true;
            frmLogin.FormBorderStyle = FormBorderStyle.None;
            frmLogin.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(frmLogin);
            frmLogin.BringToFront();
            frmLogin.Show();

            mnsAdmin.Visible = false;
            frmLogin.adminLogin += frmAdminLogin_successLogin;
            frmLogin.userLogin += frmUserLogin_successLogin;
        }

        private void frmUserLogin_successLogin()
        {
            mnsAdmin.Visible = true;
            tsmiSell.Visible = true;
            tsmiManager.Visible = false;
            tsmiStatistical.Visible = true;
            tsmiStaff.Visible = false;
            //mnsAdmin.Visible = true;
            this.Text = "Đặt vé";
            pnlMain.Controls.Clear();
            SelectShowtimeUC sellUC = new SelectShowtimeUC();
            sellUC.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(sellUC);
        }

        private void frmAdminLogin_successLogin()
        {
            tsmiStaff.Visible = true;
            mnsAdmin.Visible = true;
            tsmiSell.Visible = false;
            tsmiManager.Visible = true;
            tsmiExplore.Visible = true;
            tsmiStatistical.Visible = true;
            this.Text = "Quản lý rạp phim - Chọn lịch chiếu";
            pnlMain.Controls.Clear();
            StatisticalUC statisticalUC = new StatisticalUC();
            statisticalUC.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(statisticalUC);
        }
    }
}
