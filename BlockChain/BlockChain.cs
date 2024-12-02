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

namespace BlockChain
{
    public partial class BlockChain : Form
    {
        private const string ConnectionString = "Data Source=UMARFAROOQ\\SQLEXPRESS;Initial Catalog=Blockchain;Integrated Security=True;Encrypt=False";
        public BlockChain()
        {
            InitializeComponent();
        }

        private void btnShowBlockChain_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM BlockChain";

                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                        {
                            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                            DataTable dt = new DataTable();
                            dt.Load(sqlDataReader);
                            this.dataGridView1.DataSource = dt;
                            sqlDataReader.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("The requested data could not be loaded into the form.");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}
