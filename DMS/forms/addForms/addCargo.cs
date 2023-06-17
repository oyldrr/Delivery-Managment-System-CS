using DMS.UserControls;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS.forms.addForms
{
    public partial class addCargo : Form
    {
        public addCargo()
        {
            InitializeComponent();
        }

        private void submitCargo_Click(object sender, EventArgs e)
        {
            int senderCustomer = int.Parse(senderCustomerCombo.SelectedValue.ToString());
            int receiverCustomer = int.Parse(receiverCustomerCombo.SelectedValue.ToString());
            int senderBranch = int.Parse(senderBranchCombo.SelectedValue.ToString());
            int recieverBranch = int.Parse(receiverBranchCombo.SelectedValue.ToString());
            DateTime entryDate = entryDatePicker.Value;
            DateTime estimatedDate = estimatedDatePicker.Value;
            string type = typeCombo.Text;
            float weight = float.Parse(weightTextBox.Text);
            string payer = payerCombo.Text;
            float price = float.Parse(priceTextBox.Text);
            string description = descriptionTextBox.Text;
            string barcode = (barcodeLabel.Text);


            if (senderCustomer < 0 || receiverCustomer < 0 || senderBranch < 0 || recieverBranch < 0 || entryDate == null || estimatedDate == null  || type == "" || weight < 0 || payer == "" || price < 0)
            {
                MessageBox.Show("Please fill the blanks.", "Error");
            }
            else
            {
                string connectionString = "server=localhost;port=3306;database=dms;user=root;password=password;";
                MySqlConnection connection = new MySqlConnection(connectionString);

                try
                {
                    connection.Open();
                    string query = "INSERT INTO cargos " +
                        "(senderCustomer, " +
                        "recieverCustomer, " +
                        "senderBranch, " +
                        "recieverBranch, " +
                        "entryDate, " +
                        "estimatedDate, " +
                        "barcode, " +
                        "type, " +
                        "weight, " +
                        "price, " +
                        "payer, " +
                        "description) " +
                        "VALUES " +
                        "(@val1, " +
                        "@val2, " +
                        "@val3, " +
                        "@val4, " +
                        "@val5, " +
                        "@val6, " +
                        "@val7, " +
                        "@val8, " +
                        "@val9, " +
                        "@val10, " +
                        "@val11, " +
                        "@val12)";
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
                    command.ExecuteNonQuery();

                    cargosUC obj = new cargosUC();
                    obj.retrieveData(1);

                    MessageBox.Show("New cargo record succesfully created!", "Done");
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

        private void addCargo_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=dms;user=root;password=password;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();


                // 
                string query = "SELECT id, fullname, state FROM dms.customers";
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
            string connectionString = "server=localhost;port=3306;database=dms;user=root;password=password;";
            MySqlConnection connection = new MySqlConnection(connectionString);

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
            string connectionString = "server=localhost;port=3306;database=dms;user=root;password=password;";
            MySqlConnection connection = new MySqlConnection(connectionString);

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
            pictureBox.Visible = true;
        }
    }
}
