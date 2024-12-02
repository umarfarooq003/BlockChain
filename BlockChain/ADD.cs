using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockChain
{
    public partial class ADD : Form
    {
        private const string ConnectionString = "Data Source=UMARFAROOQ\\SQLEXPRESS;Initial Catalog=Blockchain;Integrated Security=True;Encrypt=False";
        int index = 0;
        private string previousHash = null;
        private Blockchain blockchain;
        public ADD()
        {
            InitializeComponent();
            txtIndexNo.ReadOnly = true;
        }


        public class Block
        {
            public int Index { get; set; }
            public DateTime TimeStamp { get; set; }
            public string PreviousHash { get; set; }
            public string Hash { get; set; }
            public string Data { get; set; }
            public Block(DateTime timeStamp, string previousHash, string data)
            {
                TimeStamp = timeStamp;
                PreviousHash = previousHash;
                Data = data;
                Hash = CalculateHash();
            }

            public string CalculateHash()
            {
                SHA256 sha256 = SHA256.Create();

                byte[] inputBytes = Encoding.ASCII.GetBytes($"{TimeStamp}-{PreviousHash ?? ""}-{Data}");
                byte[] outputBytes = sha256.ComputeHash(inputBytes);
                return Convert.ToBase64String(outputBytes);
            }

        }



        public class Blockchain
        {
            public IList<Block> Chain { set; get; }
            public Blockchain()
            {
                InitializeChain();
                AddGenesisBlock();
            }
            public void InitializeChain()
            {
                Chain = new List<Block>();
            }
            public Block CreateGenesisBlock()
            {
                return new Block(DateTime.Now, null, "{}");
            }
            public void AddGenesisBlock()
            {
                Chain.Add(CreateGenesisBlock());
            }
            public Block GetLatestBlock()
            {
                return Chain[Chain.Count - 1];
            }
            public void AddBlock(Block block)
            {
                Block latestBlock = GetLatestBlock();
                block.PreviousHash = latestBlock.Hash;
                block.Hash = block.CalculateHash();
                Chain.Add(block);
            }
        }

        private void ADD_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset the table and restart the primary key?", "Reset Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                ResetPrimaryKey();
                MessageBox.Show("Table reset successfully. The primary key has been restarted to 0.", "Reset Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResetPrimaryKey()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("TRUNCATE TABLE BlockChain; DBCC CHECKIDENT ('BlockChain', RESEED, 0);", connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            if (isDataValid())
            {
                DateTime Timestamp = DateTime.Now;
                string data = txtData.Text.ToString();
                txtIndexNo.Text = index.ToString();
                Block block = new Block(Timestamp, previousHash, data);
                Timestamp = DateTime.Now;
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();

                        string query = "INSERT INTO BlockChain ([Hash], [Previous Hash], [DateTime], [Data]) " +
                      "VALUES ('" + block.Hash + "', '" + block.PreviousHash + "', '" +
                      block.TimeStamp.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + block.Data + "')";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                previousHash = block.Hash;
                index++;
                JsonConvert.SerializeObject(block, Formatting.Indented);
                MessageBox.Show("Block Added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtData.Clear();
                txtIndexNo.Clear();
            }
        }

        private bool isDataValid()
        {
            if (string.IsNullOrWhiteSpace(txtData.Text))

            {
                MessageBox.Show("Please Enter the data .");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void txtIndexNo_TextChanged(object sender, EventArgs e)
        {
            int index;
            int.TryParse(txtIndexNo.Text, out index);
        }
    }
}
