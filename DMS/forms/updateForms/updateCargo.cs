using DMS.UserControls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS.forms.updateForms
{
    public partial class updateCargo : Form
    {
        public updateCargo()
        {
            InitializeComponent();
        }

        public int active;

        static string connectionString = "server=localhost;port=3306;database=dms;user=root;password=password;";
        MySqlConnection connection = new MySqlConnection(connectionString);

        public void getCustomerData()
        {
            try
            {
                connection.Open();


                //
                string query = "select id, fullname, state from customers";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connectionString);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                senderCustomerCombo.DataSource = dataSet.Tables[0];
                senderCustomerCombo.DisplayMember = "fullname";
                senderCustomerCombo.ValueMember = "id";

                senderCustomerCombo.Text = "Unselected...";

                query = "SELECT id, fullname, state FROM dms.customers";
                adapter = new MySqlDataAdapter(query, connectionString);
                dataSet = new DataSet();
                adapter.Fill(dataSet);

                receiverCustomerCombo.DataSource = dataSet.Tables[0];
                receiverCustomerCombo.DisplayMember = "fullname";
                receiverCustomerCombo.ValueMember = "id";

                receiverCustomerCombo.Text = "Unselected...";
                // 

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Something went wrong!" + ex, "Error");
            }
            finally
            {
                connection.Close();
            }
        }

        private void senderCustomerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedId = senderCustomerCombo.SelectedValue.ToString();

            string query = "SELECT branches.id, branches.city FROM dms.branches INNER JOIN dms.customers ON branches.state = customers.state WHERE customers.id LIKE '" + selectedId + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connectionString);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            senderBranchCombo.DataSource = dataSet.Tables[0];
            senderBranchCombo.DisplayMember = "city";
            senderBranchCombo.ValueMember = "id";
            senderBranchCombo.Text = "Unselected...";
        }

        private void receiverCustomerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedId = receiverCustomerCombo.SelectedValue.ToString();

            string query = "SELECT branches.id, branches.city FROM dms.branches INNER JOIN dms.customers ON branches.state LIKE  customers.state WHERE customers.id LIKE '" + selectedId + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connectionString);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            receiverBranchCombo.DataSource = dataSet.Tables[0];
            receiverBranchCombo.DisplayMember = "city";
            receiverBranchCombo.ValueMember = "id";

            receiverBranchCombo.Text = "Unselected...";
        }

        private void barcodeGenerateButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string barcodeData = "";
            for (int i = 1; i <= 11; i++)
            {
                barcodeData = random.Next(0, 9) + barcodeData;
            }

            barcodeLabel.Text = barcodeData;

            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox.Image = barcode.Draw(barcodeData, 50);
            barcodeGenerateButton.Visible = false;
            pictureBox.Visible = true;
        }

        private void updateCargo_Load(object sender, EventArgs e)
        {
            getCustomerData();

            try
            {
                connection.Open();

                string query = "SELECT * FROM cargos WHERE id = " + cargosUC.selectedId;
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader row = command.ExecuteReader();
                while (row.Read())
                {
                    
                    string senderCustomer = row["senderCustomer"].ToString();
                    senderCustomerCombo.Text = senderCustomer;
                    

                    string receiverCustomer = row["recieverCustomer"].ToString();
                    receiverCustomerCombo.Text = receiverCustomer;

                    string senderBranch = row["senderBranch"].ToString();
                    senderBranchCombo.Text = senderBranch;

                    string receiverBranch = row["recieverBranch"].ToString();
                    receiverBranchCombo.Text = receiverBranch;


                    entryDatePicker.Text = row["entryDate"].ToString();
                    estimatedDatePicker.Text = row["estimatedDate"].ToString();
                    barcodeLabel.Text = row["barcode"].ToString();
                    typeCombo.Text = row["type"].ToString();
                    weightTextBox.Text = row["weight"].ToString();
                    priceTextBox.Text = row["price"].ToString();
                    payerCombo.Text = row["payer"].ToString();
                    descriptionTextBox.Text = row["description"].ToString();

                    int status = Convert.ToInt32(row["active"]);

                    if (status == 1)
                    {
                        statusCombo.SelectedIndex = 0;
                    }
                    else if (status == 0)
                    {
                        statusCombo.SelectedIndex = 1;
                    }
                }

                row.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Something went wrong!" + ex, "Error");
            }
            finally
            {
                connection.Close();
            }
        }

        
    }
}
