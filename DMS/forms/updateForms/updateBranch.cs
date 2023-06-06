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
    public partial class updateBranch : Form
    {
        public updateBranch()
        {
            InitializeComponent();
        }

        public int active;

        static string connectionString = "server=localhost;port=3306;database=dms;user=root;password=password;";
        MySqlConnection connection = new MySqlConnection(connectionString);

        public void fillCountryComboBox()
        {
            try
            {
                connection.Open();

                string query = "SELECT id, name FROM dms.countries";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connectionString);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                countryCombo.DataSource = dataSet.Tables[0];
                countryCombo.DisplayMember = "name";
                countryCombo.ValueMember = "id";

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

        private void updateBranch_Load(object sender, EventArgs e)
        {
            fillCountryComboBox();

            try
            {
                connection.Open();

                string query = "SELECT * FROM branches WHERE id = " + branchesUC.selectedId;
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader row = command.ExecuteReader();
                while (row.Read())
                {
                    managerTextBox.Text = row["manager"].ToString();
                    telNoTextBox.Text = row["telNo"].ToString();
                    countryCombo.Text = row["country"].ToString();
                    stateCombo.Text = row["state"].ToString();
                    cityCombo.Text = row["city"].ToString();
                    streetTextBox.Text = row["street"].ToString();
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

        private void countryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedId = countryCombo.SelectedIndex + 1;

            string connectionString = "server=localhost;port=3306;database=dms;user=root;password=password;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "SELECT id, name, fips_code FROM dms.states WHERE states.country_id = " + selectedId;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connectionString);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                stateCombo.DataSource = dataSet.Tables[0];
                stateCombo.DisplayMember = "name";
                stateCombo.ValueMember = "fips_code";

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

        private void stateCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCountry = countryCombo.SelectedIndex + 1;
            string selectedState = stateCombo.SelectedValue.ToString();

            string connectionString = "server=localhost;port=3306;database=dms;user=root;password=password;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "SELECT id, name FROM dms.cities WHERE country_id = " + selectedCountry + " AND state_code = '" + selectedState + "'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connectionString);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                cityCombo.DataSource = dataSet.Tables[0];
                cityCombo.DisplayMember = "name";
                cityCombo.ValueMember = "id";

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

        private void submitBranch_Click(object sender, EventArgs e)
        {
            string manager = managerTextBox.Text;
            string telephone = telNoTextBox.Text;
            string country = countryCombo.Text;
            string state = stateCombo.Text;
            string city = cityCombo.Text;
            string street = streetTextBox.Text;
            
            string status = statusCombo.Text;
            
            if (status == "Active")
            {
                active = 1;
            }
            else if (status == "Disactive")
            {
                active = 0;
            }

            if (manager == "" || telephone == "" || country == "" || state == "" || city == "" || street == "" || status == "")
            {
                MessageBox.Show("Please fill the blanks.", "Error");
            }
            else
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE `branches` SET `manager`=@val1,`telNo`=@val2,`country`=@val3,`state`=@val4,`city`=@val5,`street`=@val6,`active`=@val7 WHERE id = " + branchesUC.selectedId;
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@val1", manager);
                    command.Parameters.AddWithValue("@val2", telephone);
                    command.Parameters.AddWithValue("@val3", country);
                    command.Parameters.AddWithValue("@val4", state);
                    command.Parameters.AddWithValue("@val5", city);
                    command.Parameters.AddWithValue("@val6", street);
                    command.Parameters.AddWithValue("@val7", active);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Branch data successfully updated!", "Done");

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
