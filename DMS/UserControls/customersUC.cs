using DMS.forms.addForms;
using DMS.forms.updateForms;
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

namespace DMS.UserControls
{
    public partial class customersUC : UserControl
    {
        public customersUC()
        {
            InitializeComponent();
        }

        public static int selectedId;

        static string connectionString = "server=localhost;port=3306;database=dms;user=root;password=password;";
        MySqlConnection connection = new MySqlConnection(connectionString);

        private void searchBox_Enter(object sender, EventArgs e)
        {
            searchBox.Text = "";
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            addCustomer form = new addCustomer();
            form.ShowDialog();
        }

        private void customersUC_Load(object sender, EventArgs e)
        {
            retrieveData(1);
        }

        private void customerCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (customerCheckBox.CheckState == CheckState.Checked)
            {
                retrieveData(0);
            }
            else if (customerCheckBox.CheckState == CheckState.Unchecked || customerCheckBox.CheckState == CheckState.Indeterminate)
            {
                retrieveData(1);
            }
        }

        public void retrieveData(int isActive)
        {

            int x = 10;
            int y = 10;

            cardViewPanel.Controls.Clear();
            try
            {
                connection.Open();

                string query = "SELECT * FROM customers WHERE active = " + isActive + " ORDER BY updated_at DESC";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                int rowCount = 4;

                foreach (DataRow row in dataTable.Rows)
                {

                    // panel creating and styling
                    Panel panel = new Panel();
                    panel.BorderStyle = BorderStyle.None;
                    panel.BackColor = System.Drawing.Color.FromArgb(48, 162, 255);
                    panel.Size = new Size(345, 225);
                    panel.Location = new Point(x, y);

                    // Panel border radius
                    System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                    int arcSize = 10;
                    Rectangle rect = new Rectangle(panel.ClientRectangle.Location.X, panel.ClientRectangle.Location.Y, panel.ClientRectangle.Width, panel.ClientRectangle.Height);
                    path.AddArc(rect.X, rect.Y, arcSize, arcSize, 180, 90);
                    path.AddArc(rect.X + rect.Width - arcSize, rect.Y, arcSize, arcSize, 270, 90);
                    path.AddArc(rect.X + rect.Width - arcSize, rect.Y + rect.Height - arcSize, arcSize, arcSize, 0, 90);
                    path.AddArc(rect.X, rect.Y + rect.Height - arcSize, arcSize, arcSize, 90, 90);
                    path.CloseAllFigures();
                    panel.Region = new System.Drawing.Region(path);
                    //

                    // Update button creating and settings
                    Button button = new Button();
                    button.Size = new Size((int)panel.Width, 30);
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.Text = "Update";
                    button.ForeColor = System.Drawing.Color.FromArgb(241, 246, 249);
                    button.BackColor = System.Drawing.Color.FromArgb(0, 196, 255);
                    button.Cursor = Cursors.Hand;

                    button.MouseClick += (sender3, e3) =>
                    {
                        selectedId = int.Parse(row["id"].ToString());

                        updateCustomer form = new updateCustomer();
                        form.ShowDialog();
                    };

                    button.MouseEnter += (sender1, e1) =>
                    {
                        button.BackColor = System.Drawing.Color.FromArgb(255, 231, 160);
                    };

                    button.MouseLeave += (sender2, e2) =>
                    {
                        button.BackColor = System.Drawing.Color.FromArgb(0, 196, 255);
                    };

                    panel.Controls.Add(button);
                    //


                    // Label creating and adding to panel control
                    Label label = new Label();
                    label.ForeColor = Color.White;
                    label.Font = new Font("Montserrat Light", 10);
                    label.Size = new Size((int)panel.Width, panel.Height);
                    label.Padding = new Padding(3, button.Height + 10, 0, 0);
                    label.Text =
                        "Id: #" + row["id"].ToString() + "\n" +
                        "Fullname: " + row["fullname"].ToString() + "\n" +
                        "Citizenship No: " + row["citizenshipNo"].ToString() + "\n" +
                        "Mobile No: " + row["mobileNo"].ToString() + "\n" +
                        "Country: " + row["country"].ToString() + "\n" +
                        "State: " + row["state"].ToString() + "\n" +
                        "City: " + row["city"].ToString() + "\n" +
                        "Street: " + row["street"].ToString() + "\n" +
                        "Updated at: " + row["updated_at"].ToString() + "\n" +
                        "Created at: " + row["created_at"].ToString();

                    panel.Controls.Add(label);
                    //


                    if (rowCount % 3 == 0)
                    {
                        y = panel.Height + 25;
                        x = 10;
                    }
                    else
                    {
                        x += panel.Width + 25;
                    }


                    cardViewPanel.Controls.Add(panel);

                    rowCount++;
                }
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
