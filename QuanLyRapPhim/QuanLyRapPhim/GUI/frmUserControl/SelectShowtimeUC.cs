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
    public partial class SelectShowtimeUC : UserControl
    {
        public SelectShowtimeUC()
        {
            InitializeComponent();
            dtpDate.Value = DateTime.Now;
            dtpDate.MinDate = DateTime.Now;
            dtpDate.MaxDate = DateTime.Now.AddDays(7);
            LoadMovie();
        }

        private void frmSeller_Load(object sender, EventArgs e)
        {
            LoadMovie();
            timer1.Start();
        }

        private void LoadMovie()
        {
            lvwShowtime.Items.Clear();
            LoadListShowTimeByFilm();
        }

        private void LoadListShowTimeByFilm()
        {
            DataTable data = ShowtimeDAO.GetListShowtime(dtpDate.Value);
            foreach (DataRow row in data.Rows)
            {
                Showtime showtime = new Showtime(row);

                ListViewItem lvw = new ListViewItem(showtime.CinemaRoomName);
                lvw.SubItems.Add(showtime.Title);
                lvw.SubItems.Add(showtime.ShowDate.ToShortTimeString());
                lvw.Tag = showtime;

                string statusShowTimes = MovieTicketDAO.CountTheNumberOfTicketsSoldByShowtime(showtime.ShowtimeID)
                    + "/" + MovieTicketDAO.CountToltalTicketByShowtime(showtime.ShowtimeID);

                lvw.SubItems.Add(statusShowTimes);

                float status = (float)MovieTicketDAO.CountTheNumberOfTicketsSoldByShowtime(showtime.ShowtimeID)
                    / MovieTicketDAO.CountToltalTicketByShowtime(showtime.ShowtimeID);
                lvwShowtime.Items.Add(lvw);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Load lại form để cập nhật cơ sở dữ liệu
            this.OnLoad(null);
        }

        private void lvwShowtime_Click(object sender, EventArgs e)
        {
            if (lvwShowtime.SelectedItems.Count > 0)
            {
                timer1.Stop();
                Showtime showtime = lvwShowtime.SelectedItems[0].Tag as Showtime;

                pnlMain.Controls.Clear();
                SelectSeatUC selectSeatUC = new SelectSeatUC(showtime);
                selectSeatUC.Dock = DockStyle.Fill;
                pnlMain.Controls.Add(selectSeatUC);
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            LoadMovie();            
        }
    }
}