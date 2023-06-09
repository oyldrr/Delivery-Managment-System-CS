﻿using DMS.UserControls;
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

namespace DMS.forms.addForms
{
    public partial class addBranch : Form
    {
        public addBranch()
        {
            InitializeComponent();
        }

        private void submitBranch_Click(object sender, EventArgs e)
        {
            string manager = managerTextBox.Text;
            string telephone = telNoTextBox.Text;
            string country = countryCombo.Text;
            string state = stateCombo.Text;
            string city = cityCombo.Text;
            string street = streetTextBox.Text;

            if (manager == "" || telephone == "" || country == "" || state == "" || city == "" || street == "")
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
                    string query = "INSERT INTO branches (manager, telNo, country, state, city, street) VALUES (@val1, @val2, @val3, @val4, @val5, @val6)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@val1", manager);
                    command.Parameters.AddWithValue("@val2", telephone);
                    command.Parameters.AddWithValue("@val3", country);
                    command.Parameters.AddWithValue("@val4", state);
                    command.Parameters.AddWithValue("@val5", city);
                    command.Parameters.AddWithValue("@val6", street);
                    command.ExecuteNonQuery();

                    branchesUC obj = new branchesUC();
                    obj.retrieveData(1);

                    MessageBox.Show("New branch record succesfully created!", "Done");
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

        private void addBranch_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=dms;user=root;password=password;";
            MySqlConnection connection = new MySqlConnection(connectionString);

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
    }
}
