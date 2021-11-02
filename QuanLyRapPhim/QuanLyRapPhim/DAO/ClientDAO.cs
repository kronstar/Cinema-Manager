using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class ClientDAO
    {
        public static DataTable GetClient(string PhoneNumber)
        {
            string query = "Select * from Client where PhoneNumber = '" + PhoneNumber + "'";
            return DataDAO.ExecuteQuery(query);
        }

        public static DataTable GetClient()
        {
            return DataDAO.ExecuteQuery("EXEC GetClient");
        }

        public static bool CreateClient(string ClientID, string ClientName, DateTime Birthday, string ClientAddress, string PhoneNumber, int IDNumber)
        {
            int result = DataDAO.ExecuteNonQuery("EXEC CreateClient @ClientID , @ClientName , @Birthday , @ClientAddress , @PhoneNumber , @IDNumber ", new object[] { ClientID, ClientName, Birthday, ClientAddress, PhoneNumber, IDNumber });
            return result > 0;
        }

        public static bool EditClient(string ClientID, string ClientName, DateTime Birthday, string ClientAddress, string PhoneNumber, int IDNumber)
        {
            string command = string.Format("UPDATE dbo.Client SET ClientName = N'{0}', Birthday = '{1}', ClientAddress = N'{2}', PhoneNumber = '{3}', IDNumber = {4} WHERE id = '{5}'", ClientName, Birthday, ClientAddress, PhoneNumber, IDNumber, ClientID);
            int result = DataDAO.ExecuteNonQuery(command);
            return result > 0;
        }

        public static bool DeleteClient(string ClientID)
        {
            int result = DataDAO.ExecuteNonQuery("DELETE dbo.Client WHERE ClientID = '" + ClientID + "'");
            return result > 0;
        }

        public static DataTable SearchClientByName(string ClientName)
        {
            return DataDAO.ExecuteQuery("EXEC SearchClient @ClientName", new object[] { ClientName });
        }
    }
}