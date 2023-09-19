using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DentalClinicManagementWinForm
{
    class ConnectionString
    {
        public SqlConnection GetCon()
        {
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gülcan\source\repos\DentalClinicManagementWinForm\DentalDb.mdf;Integrated Security=True;Connect Timeout=30";
            return Con;
        }
    }
}
