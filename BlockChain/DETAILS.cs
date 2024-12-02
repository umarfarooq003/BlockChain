using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using static BlockChain.ADD;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace BlockChain
{
    public partial class DETAILS : Form
    {

        public IList<Block> Chain { set; get; }
        Blockchain blockchain = new Blockchain();
        int index;
        private const string ConnectionString = "Data Source=UMARFAROOQ\\SQLEXPRESS;Initial Catalog=Blockchain;Integrated Security=True;Encrypt=False";
        public DETAILS()
        {
            InitializeComponent();
            blockchain = new Blockchain();
        }


        private bool IsindexValid()
        {

            if (string.IsNullOrEmpty(txtIndexBox.Text))
            {
                MessageBox.Show("Please Enter the Index No.");
                return false;
            }
            else if (Regex.IsMatch(txtIndexBox.Text, @"^\D*$"))
            {

                MessageBox.Show("Index Number  must contain only numbers.");
                txtIndexBox.Clear();
                return false;
            }
            else
            {
                index = Int32.Parse(txtIndexBox.Text);
                return true;
            }
        }

        private void DETAILS_Load(object sender, EventArgs e)
        {

        }

        private void btnFindDataByIndex_Click(object sender, EventArgs e)
        {

            if (IsindexValid())
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {

                    string query = "SELECT * FROM BlockChain WHERE [ID]='" + txtIndexBox.Text + "'";


                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
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
                            MessageBox.Show("The requested Data could not be loaded into the form.");
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
