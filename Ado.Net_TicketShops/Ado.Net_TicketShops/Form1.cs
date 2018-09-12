using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Ado.Net_IceShops
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection = null;
        SqlCommandBuilder sqlCommandBuilder = null;
        SqlDataReader sqlDataReader = null;
        DataSet dataSet = null;
        public Form1()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
        }

        private void BuyBut_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            

        }
    }
}
