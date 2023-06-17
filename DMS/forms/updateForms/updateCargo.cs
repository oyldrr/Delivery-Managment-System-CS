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

        // Filling the Customer ComboBoxes
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

                senderCustomerCombo.Text = "";

                query = "SELECT id, fullname, state FROM dms.customers";
                adapter = new MySqlDataAdapter(query, connectionString);
                dataSet = new DataSet();
                adapter.Fill(dataSet);

                receiverCustomerCombo.DataSource = dataSet.Tables[0];
                receiverCustomerCombo.DisplayMember = "fullname";
                receiverCustomerCombo.ValueMember = "id";

                receiverCustomerCombo.Text = "";
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
        //

        // Filling the Branch ComboBoxes
        private void senderCustomerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedId = senderCustomerCombo.SelectedValue.ToString();

            string query = "SELECT branches.id, branches.city, branches.state, branches.manager FROM dms.branches INNER JOIN dms.customers ON branches.state = customers.state WHERE customers.id LIKE '" + selectedId + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connectionString);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            senderBranchCombo.DataSource = dataSet.Tables[0];
            senderBranchCombo.DisplayMember = "city";
            senderBranchCombo.ValueMember = "id";
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
                    
                    string senderCustomerId = row["senderCustomer"].ToString();
                    string receiverCustomerId = row["recieverCustomer"].ToString();


                    string senderBranchId = row["senderBranch"].ToString();
                    string receiverBranchId = row["recieverBranch"].ToString();

                    entryDatePicker.Text = row["entryDate"].ToString();
                    estimatedDatePicker.Text = row["estimatedDate"].ToString();
                    typeCombo.Text = row["type"].ToString();
                    weightTextBox.Text = row["weight"].ToString();
                    priceTextBox.Text = row["price"].ToString();
                    payerCombo.Text = row["payer"].ToString();
                    descriptionTextBox.Text = row["description"].ToString();

                    string barcodeData = row["barcode"].ToString();

                    int status = Convert.ToInt32(row["active"]);

                    row.Close();

                    query = "SELECT fullname, mobileNo FROM dms.customers WHERE id = " + senderCustomerId;
                    command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        senderCustomerCombo.Text =
                        reader["fullname"].ToString() + " - " +
                        reader["mobileNo"].ToString();
                    }
                    reader.Close();

                    query = "SELECT fullname, mobileNo FROM dms.customers WHERE id = " + receiverCustomerId;
                    command = new MySqlCommand(query, connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        receiverCustomerCombo.Text =
                        reader["fullname"].ToString() + " - " +
                        reader["mobileNo"].ToString();
                    }
                    reader.Close();

                    query = "SELECT city, state, country, manager FROM dms.branches WHERE id = " + senderBranchId;
                    command = new MySqlCommand(query, connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        senderBranchCombo.Text =
                        reader["city"].ToString() + " - " +
                        reader["state"].ToString() + "/" +
                        reader["country"].ToString() + " - " +
                        reader["manager"].ToString();
                    }
                    reader.Close();

                    query = "SELECT city, state, country, manager FROM dms.branches WHERE id = " + receiverBranchId;
                    command = new MySqlCommand(query, connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        receiverBranchCombo.Text =
                        reader["city"].ToString() + " - " +
                        reader["state"].ToString() + "/" +
                        reader["country"].ToString() + " - " +
                        reader["manager"].ToString();
                    }
                    reader.Close();

                    

                    
                    barcodeLabel.Text = barcodeData;
                    Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                    pictureBox.Image = barcode.Draw(barcodeData, 50);

                    

                    if (status == 1)
                    {
                        statusCombo.SelectedIndex = 0;
                    }
                    else if (status == 0)
                    {
                        statusCombo.SelectedIndex = 1;
                    }
                    break;
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

        private void submitCargo_Click(object sender, EventArgs e)
        {
            int senderCustomer = int.Parse(senderCustomerCombo.Text);
            int receiverCustomer = int.Parse(receiverCustomerCombo.Text);
            int senderBranch = int.Parse(senderBranchCombo.Text);
            int recieverBranch = int.Parse(receiverBranchCombo.Text);
            DateTime entryDate = entryDatePicker.Value;
            DateTime estimatedDate = estimatedDatePicker.Value;
            string type = typeCombo.Text;
            float weight = float.Parse(weightTextBox.Text);
            string payer = payerCombo.Text;
            float price = float.Parse(priceTextBox.Text);
            string description = descriptionTextBox.Text;
            string barcode = (barcodeLabel.Text);

            string status = statusCombo.Text;

            if (status == "Active")
            {
                active = 1;
            }
            else if (status == "Disactive")
            {
                active = 0;
            }

            if (senderCustomer < 0 || receiverCustomer < 0 || senderBranch < 0 || recieverBranch < 0 || entryDate == null || estimatedDate == null || type == "" || weight < 0 || payer == "" || price < 0)
            {
                MessageBox.Show("Please fill the blanks.", "Error");
            }
            else
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE `cargos` SET " +
                        "`senderCustomer`=@val1," +
                        "`receiverCustomer`=@val2," +
                        "`senderBranch`=@val3," +
                        "`recieverBranch`=@val4," +
                        "`entryDate`=@val5," +
                        "`estimatedDate`=@val6," +
                        "`barcode`=@val7," +
                        "`type`=@val8, " +
                        "`weight`=@val9, " +
                        "`price`=@val10, " +
                        "`payer`=@val11, " +
                        "`description`=@val12, " +
                        "`active`=@val13 " +
                        "WHERE id = " + cargosUC.selectedId;
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@val1", senderCustomer);
                    command.Parameters.AddWithValue("@val2", receiverCustomer);
                    command.Parameters.AddWithValue("@val3", senderBranch);
                    command.Parameters.AddWithValue("@val4", recieverBranch);
                    command.Parameters.AddWithValue("@val5", entryDate);
                    command.Parameters.AddWithValue("@val6", estimatedDate);
                    command.Parameters.AddWithValue("@val7", barcode);
                    command.Parameters.AddWithValue("@val8", type);
                    command.Parameters.AddWithValue("@val9", weight);
                    command.Parameters.AddWithValue("@val10", price);
                    command.Parameters.AddWithValue("@val11", payer);
                    command.Parameters.AddWithValue("@val12", description);
                    command.Parameters.AddWithValue("@val13", active);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cargo data successfully updated!", "Done");

                    branchesUC obj = new branchesUC();
                    obj.retrieveData(1);

                    this.Close();
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
}
