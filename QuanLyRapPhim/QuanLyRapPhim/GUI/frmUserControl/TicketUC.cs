using QuanLyRapPhim.DAO;
using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim.GUI.frmUserControl
{
    public partial class TicketUC : UserControl
    {
        public TicketUC()
        {
            InitializeComponent();
            LoadAllListShowtime();
        }
        void LoadAllListShowtime()
        {
            lvwShowtimeList.Items.Clear();

            List<Showtime> allShowtimeList = ShowtimeDAO.GetAllListShowtime();
            foreach (Showtime showtime in allShowtimeList)
            {
                ListViewItem lvw = new ListViewItem(showtime.CinemaRoomName);
                lvw.SubItems.Add(showtime.Title);
                lvw.SubItems.Add(showtime.ShowDate.ToString("HH:mm:ss dd/MM/yyyy"));
                lvw.Tag = showtime;

                if (showtime.ShowtimeStatus == 1)
                {
                    lvw.SubItems.Add("Đã tạo");
                }
                else
                {
                    lvw.SubItems.Add("Chưa Tạo");
                }
                lvwShowtimeList.Items.Add(lvw);
            }
        }

        void LoadMovieTicketsByShowtime(string ShowtimeID)
        {
            List<MovieTicket> listTicket = MovieTicketDAO.GetListTicketsByShowtime(ShowtimeID);
            dgvTicket.DataSource = listTicket;
        }
        void LoadMovieTicketsSoldByShowtime(string ShowtimeID)
        {
            List<MovieTicket> listTicket = MovieTicketDAO.GetListTicketsSoldByShowtime(ShowtimeID);
            dgvTicket.DataSource = listTicket;
        }

        void AutoCreateTicketsByShowTimes(Showtime showtime)
        {
            int result = 0;
            CinemaRoom cinema = CinemaRoomDAO.GetCinemaRoomName(showtime.CinemaRoomName);
            int Row = cinema.SeatRows;
            int Column = cinema.SeatPerRow;
            for (int i = 0; i < Row; i++)
            {
                int temp = i + 65;
                char nameRow = (char)(temp);
                for (int j = 1; j <= Column; j++)
                {
                    string SeatID = nameRow.ToString() + j;
                    result += MovieTicketDAO.CreateMovieTicketByShowtime(showtime.ShowtimeID, SeatID);
                }
            }
            if (result == Row * Column)
            {
                int ret = ShowtimeDAO.EditShowtimeStatus(showtime.ShowtimeID, 1);
                if (ret > 0)
                    MessageBox.Show("Tạo vé thành công!");
            }
            else
                MessageBox.Show("Không thể tạo vé!");
        }

        //private void lsvAllListShowTimes_Click(object sender, EventArgs e)
        //{
        //    if (lsvAllListShowTimes.SelectedItems.Count > 0)
        //    {
        //        ShowTimes showTimes = lsvAllListShowTimes.SelectedItems[0].Tag as ShowTimes;
        //        LoadTicketsByShowTimes(showTimes.ID);
        //    }
        //}

        private void DeleteTicketsByShowTimes(Showtime showtime)
        {
            CinemaRoom cinema = CinemaRoomDAO.GetCinemaRoomName(showtime.CinemaRoomName);
            int Row = cinema.SeatRows;
            int Column = cinema.SeatPerRow;
            int result = MovieTicketDAO.DeleteMovieTicketByShowtime(showtime.ShowtimeID);
            if (result == Row * Column)
            {
                int ret = ShowtimeDAO.EditShowtimeStatus(showtime.ShowtimeID, 0);
                if (ret > 0)
                    MessageBox.Show("Đã xoá tất cả vé của lịch chiếu" + showtime.ShowtimeID);
            }
            else
                MessageBox.Show("Không thể xoá tất cả vé của lịch chiếu" + showtime.ShowtimeID);
        }

        private void LoadListShowTimesNotCreateTickets()
        {
            lvwShowtimeList.Items.Clear();

            List<Showtime> allListShowTime = ShowtimeDAO.GetListShowtimeNotCreateMovieTicket();
            foreach (Showtime showtime in allListShowTime)
            {
                ListViewItem lvi = new ListViewItem(showtime.CinemaRoomName);
                lvi.SubItems.Add(showtime.Title);
                lvi.SubItems.Add(showtime.ShowDate.ToString("HH:mm:ss dd/MM/yyyy"));
                lvi.Tag = showtime;

                if (showtime.ShowtimeStatus == 1)
                {
                    lvi.SubItems.Add("Đã tạo");
                }
                else
                {
                    lvi.SubItems.Add("Chưa Tạo");
                }
                lvwShowtimeList.Items.Add(lvi);
            }
        }

        private void btnAllShowtime_Click(object sender, EventArgs e)
        {
            LoadAllListShowtime();
        }

        private void btnSoldTicket_Click(object sender, EventArgs e)
        {
            if (lvwShowtimeList.SelectedItems.Count > 0)
            {
                Showtime showtime = lvwShowtimeList.SelectedItems[0].Tag as Showtime;
                LoadMovieTicketsSoldByShowtime(showtime.ShowtimeID);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lịch chiếu trước!");
            }
        }

        private void tsmiCreateTicket_Click(object sender, EventArgs e)
        {
            if (lvwShowtimeList.SelectedItems.Count > 0)
            {
                Showtime showtime = lvwShowtimeList.SelectedItems[0].Tag as Showtime;
                if (showtime.ShowtimeStatus == 1)
                {
                    MessageBox.Show("Lịch chiếu này đã được tạo vé");
                    return;
                }
                AutoCreateTicketsByShowTimes(showtime);
                LoadAllListShowtime();
                LoadMovieTicketsByShowtime(showtime.ShowtimeID);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lịch chiếu trước!");
            }
        }

        private void tsmiDeleteTicket_Click(object sender, EventArgs e)
        {
            if (lvwShowtimeList.SelectedItems.Count > 0)
            {
                Showtime showTimes = lvwShowtimeList.SelectedItems[0].Tag as Showtime;
                if (showTimes.ShowtimeStatus == 0)
                {
                    MessageBox.Show("Lịch chiếu này đã được tạo vé");
                    return;
                }
                DeleteTicketsByShowTimes(showTimes);
                LoadAllListShowtime();
                LoadMovieTicketsByShowtime(showTimes.ShowtimeID);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lịch chiếu trước!");
            }
        }

        private void tsmiShowSoldTicket_Click(object sender, EventArgs e)
        {
            if (lvwShowtimeList.SelectedItems.Count > 0)
            {
                Showtime showtime = lvwShowtimeList.SelectedItems[0].Tag as Showtime;
                LoadMovieTicketsSoldByShowtime(showtime.ShowtimeID);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lịch chiếu trước!");
            }
        }

        private void tsmiShowAllTicket_Click(object sender, EventArgs e)
        {
            if (lvwShowtimeList.SelectedItems.Count > 0)
            {
                Showtime showTimes = lvwShowtimeList.SelectedItems[0].Tag as Showtime;
                LoadMovieTicketsByShowtime(showTimes.ShowtimeID);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lịch chiếu trước!");
            }
        }

        private void tsmiShowtimeNotCreate_Click(object sender, EventArgs e)
        {
            LoadListShowTimesNotCreateTickets();
        }

        private void tsmiAllShowtime_Click(object sender, EventArgs e)
        {
            LoadAllListShowtime();
        }
    }
}
