using QuanLyRapPhim.Additional;
using QuanLyRapPhim.DAO;
using QuanLyRapPhim.DTO;
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
    public partial class SelectSeatUC : UserControl
    {
        public Client client;

        int SIZE = 30;//Size của ghế
        int GAP = 7;//Khoảng cách giữa các ghế

        List<MovieTicket> listSeat = new List<MovieTicket>();

        //dùng lưu vết các Ghế đang chọn
        List<Button> listSeatSelected = new List<Button>();

        float displayPrice = 0;//Hiện thị giá vé
        float ticketPrice = 0;//Lưu giá vé gốc
        float total = 0;//Tổng giá tiền
        float discount = 0;//Tiền được giảm
        float payment = 0;//Tiền phải trả

        Showtime Times;

        public SelectSeatUC(Showtime showtime)
        {
            InitializeComponent();
            
            Times = showtime;
            //Movie = movie;
        }

        private void LoadDataCinema(string CinemaRoomName)
        {
            CinemaRoom cinema = CinemaRoomDAO.GetCinemaRoomName(CinemaRoomName);
            int Row = cinema.SeatRows;
            int Column = cinema.SeatPerRow;
            flpSeat.Size = new Size((SIZE + 20 + GAP) * Column, (SIZE + GAP) * Row);
        }

        private void LoadBill()
        {
            txtTicketPrice.Text = displayPrice.ToString("#,#", CultureInfo.InvariantCulture) + " VNĐ";
            //txtTotal.Text = total.ToString("#,#", CultureInfo.InvariantCulture) + " VNĐ";
            //txtDiscount.Text = discount.ToString("#,#", CultureInfo.InvariantCulture) + " VNĐ";
            txtAmount.Text = payment.ToString("#,#", CultureInfo.InvariantCulture) + " VNĐ";
        }

        private void LoadSeats(List<MovieTicket> list)
        {
            flpSeat.Controls.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                Button btnSeat = new Button() { Width = SIZE + 20, Height = SIZE };

                btnSeat.FlatStyle = FlatStyle.Flat;
                btnSeat.FlatAppearance.BorderSize = 0;
                btnSeat.BackColor = Colors.SeatColor();
                btnSeat.ForeColor = Colors.TextColor();

                btnSeat.Text = list[i].SeatID;
                if (list[i].TicketStatus == 1)
                {
                    btnSeat.BackColor = Colors.SoldSeatColor();
                    btnSeat.Enabled = false;
                }
                else
                    btnSeat.BackColor = Colors.SeatColor();
                btnSeat.Click += BtnSeat_Click;
                flpSeat.Controls.Add(btnSeat);

                btnSeat.Tag = list[i];
            }
        }

        private void BtnSeat_Click(object sender, EventArgs e)
        {
            Button btnSeat = sender as Button;
            if (btnSeat.BackColor == Colors.SeatColor())
            {
                grpTicketType.Enabled = true;
                grpClientInfo.Enabled = true;
                rdoAdult.Checked = true;

                btnSeat.BackColor = Colors.SelectedSeatColor();
                MovieTicket ticket = btnSeat.Tag as MovieTicket;

                ticket.Price = ticketPrice;
                displayPrice = ticket.Price;
                total += ticketPrice;
                payment = total - discount;
                ticket.TicketType = 1;

                listSeatSelected.Add(btnSeat);
            }
            else if (btnSeat.BackColor == Colors.SelectedSeatColor()) 
            {
                btnSeat.BackColor = Colors.SeatColor();
                MovieTicket ticket = btnSeat.Tag as MovieTicket;

                total -= ticket.Price;
                payment = total - discount;
                ticket.Price = 0;
                displayPrice = ticket.Price;
                ticket.TicketType = 0;

                listSeatSelected.Remove(btnSeat);
            }

            if (listSeatSelected.Count == 0)
            {
                grpTicketType.Enabled = false;
                grpClientInfo.Enabled = false;
            }
            LoadBill();
        }

        private void RestoreDefault()
        {
            listSeatSelected.Clear();

            rdoAdult.Checked = true;
            grpTicketType.Enabled = false;

            total = 0;
            displayPrice = 0;
            discount = 0;
            payment = 0;

            LoadBill();
        }

        private void rdoStudent_Click(object sender, EventArgs e)
        {
            if (rdoStudent.Checked == true)
            {
                if (listSeatSelected.Count == 0) return;
                MovieTicket ticket = listSeatSelected[listSeatSelected.Count - 1].Tag as MovieTicket;
                ticket.TicketType = 2;

                float oldPrice = ticket.Price;
                ticket.Price = 0.8f * ticketPrice;
                displayPrice = ticket.Price;
                total = total + ticket.Price - oldPrice;
                payment = total - discount;

                LoadBill();
            }
        }

        private void rdoAdult_Click(object sender, EventArgs e)
        {
            if (rdoAdult.Checked == true)
            {
                if (listSeatSelected.Count == 0) return;
                MovieTicket ticket = listSeatSelected[listSeatSelected.Count - 1].Tag as MovieTicket;
                ticket.TicketType = 1;

                float oldPrice = ticket.Price;
                ticket.Price = ticketPrice;
                displayPrice = ticket.Price;
                total = total + ticket.Price - oldPrice;
                payment = total - discount;

                LoadBill();
            }
        }

        private void rdoChild_Click(object sender, EventArgs e)
        {
            if (rdoChild.Checked == true)
            {
                if (listSeatSelected.Count == 0) return;
                MovieTicket ticket = listSeatSelected[listSeatSelected.Count - 1].Tag as MovieTicket;
                ticket.TicketType = 3;

                float oldPrice = ticket.Price;
                ticket.Price = 0.7f * ticketPrice;
                displayPrice = ticket.Price;
                total = total + ticket.Price - oldPrice;
                payment = total - discount;

                LoadBill();
            }
        }

        private void SelectSeatUC_Load(object sender, EventArgs e)
        {
            ticketPrice = Times.TicketPrice;

            lblInfo.Text = Times.CinemaRoomName + " | " + Times.Title + " | " + Times.ShowDate.ToShortDateString() + " | " + Times.ShowDate.ToShortTimeString();

            rdoAdult.Checked = true;

            LoadDataCinema(Times.CinemaRoomName);

            listSeat = MovieTicketDAO.GetListTicketsByShowtime(Times.ShowtimeID);

            LoadSeats(listSeat);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận huỷ đặt vé ?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;
            foreach (Button btn in listSeatSelected)
            {
                btn.BackColor = Color.White;
            }
            RestoreDefault();
            this.OnLoad(new EventArgs());


            panel1.Controls.Clear();
            SelectShowtimeUC sellUC = new SelectShowtimeUC();
            sellUC.Dock = DockStyle.Fill;
            panel1.Controls.Add(sellUC);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (listSeatSelected.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn vé trước khi thanh toán!");
                return;
            }
            string message = "Xác nhận mua những vé: \n";
            foreach (Button btn in listSeatSelected)
            {
                message += btn.Text + " ";
            }
            DialogResult result = MessageBox.Show(message, "Xác nhận mua", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                string billID = DateTime.Now.Ticks.ToString();
                int ret = 0;

                foreach (Button btn in listSeatSelected)
                {
                    MovieTicket ticket = btn.Tag as MovieTicket;

                    ret += MovieTicketDAO.BuyTicket(ticket.TicketsID, ticket.TicketType, client.ClientID, ticket.Price);
                    BillDetailsDAO.CreateBillDetails(billID, ticket.SeatID, ticket.Price);
                }
                BillDAO.CreateBill(billID, total, DateTime.Now, client.ClientID, Times.ShowtimeID);
                if (ret == listSeatSelected.Count)
                {
                    MessageBox.Show("Bạn đã mua vé thành công!");
                }
            }
            RestoreDefault();
            this.OnLoad(new EventArgs());
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            txtClientName.Text = null;
            txtClientID.Text = null;
            DataTable data = ClientDAO.GetClient(txtPhoneNumber.Text);

            if (data.Rows.Count == 0)
            {
                return;
            }
            client = new Client(data.Rows[0]);

            txtClientID.Text = client.ClientID;
            txtClientName.Text = client.ClientName;
        }
    }
}