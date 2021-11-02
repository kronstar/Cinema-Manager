using QuanLyRapPhim.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim.GUI.frmUserControl
{
    public partial class StatisticalUC : UserControl
    {
        public StatisticalUC()
        {
            InitializeComponent();
            LoadRevenue();
        }
        void LoadRevenue()
        {
            LoadMovieIntoCombobox(cmbTitle);
            LoadDateTimePickerRevenue();//Set "Từ ngày" & "Đến ngày ngày" về đầu tháng & cuối tháng
            LoadRevenue(cmbTitle.SelectedValue.ToString(), dtpFromDate.Value, dtpToDay.Value);
        }
        void LoadMovieIntoCombobox(ComboBox cmb)
        {
            cmb.DataSource = MovieDAO.GetListMovie();
            cmb.DisplayMember = "Title";
            cmb.ValueMember = "MovieID";
        }
        void LoadDateTimePickerRevenue()
        {
            dtpFromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpToDay.Value = dtpFromDate.Value.AddMonths(1).AddDays(-1);
        }
        void LoadRevenue(string MovieID, DateTime FromDate, DateTime ToDate)
        {
            dgvStatistical.DataSource = StatisticalDAO.GetRevenueByMovieAndDate(MovieID, FromDate, ToDate);
            txtRevenue.Text = GetSumRevenue().ToString("#,#") + " VNĐ";
        }
        decimal GetSumRevenue()
        {
            decimal sum = 0;
            foreach (DataGridViewRow row in dgvStatistical.Rows)
            {
                sum += Convert.ToDecimal(row.Cells["Tiền vé"].Value);
            }
            return sum;
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            LoadRevenue(cmbTitle.SelectedValue.ToString(), dtpFromDate.Value, dtpToDay.Value);
        }
    }
}
