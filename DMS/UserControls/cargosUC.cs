using ComponentFactory.Krypton.Toolkit;
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
using Zen.Barcode;

namespace DMS.UserControls
{
    public partial class cargosUC : UserControl
    {
        public cargosUC()
        {
            InitializeComponent();
        }

        public static int selectedId;

        static string connectionString = "server=localhost;port=3306;database=dms;user=root;password=password;";
        MySqlConnection connection = new MySqlConnection(connectionString);

        private void addCargoButton_Click(object sender, EventArgs e)
        {
            addCargo form = new addCargo();
            form.ShowDialog();
        }


        private void searchBox_Enter(object sender, EventArgs e)
        {
            searchBox.Text = "";
        }

        private void cargosUC_Load(object sender, EventArgs e)
        {
            retrieveData(1);
        }

        private void cargoCheckbox_CheckStateChanged(object sender, EventArgs e)
        {
            if (cargoCheckbox.CheckState == CheckState.Checked) {
                retrieveData(0);
            }
            else if (cargoCheckbox.CheckState == CheckState.Unchecked || cargoCheckbox.CheckState == CheckState.Indeterminate)
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

                string query = "SELECT * FROM cargos WHERE cargos.active = " + isActive + " ORDER BY updated_at DESC";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                int rowCount = 4;

                foreach (DataRow row in dataTable.Rows)
                {
                    // get sender customer data
                    query = "select * from customers WHERE id = " + row["senderCustomer"];
                    command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    string senderCustomer = "#" + reader["id"].ToString() + " " +
                            reader["fullname"].ToString();
                    reader.Close();
                    // 

                    // get reciever customer data
                    query = "select * from customers WHERE id = " + row["recieverCustomer"];
                    command = new MySqlCommand(query, connection);
                    reader = command.ExecuteReader();
                    reader.Read();
                    string recieverCustomer = "#" + reader["id"].ToString() + " " +
                            reader["fullname"].ToString();
                    reader.Close();
                    // 

                    // get sender branch data
                    query = "select * from branches WHERE id = " + row["senderBranch"];
                    command = new MySqlCommand(query, connection);
                    reader = command.ExecuteReader();
                    reader.Read();
                    string senderBranch = "#" + reader["id"].ToString() + " " +
                            reader["country"].ToString() + " " +
                            reader["state"].ToString() + " " +
                            reader["city"].ToString() + " " +
                            reader["manager"].ToString();
                    reader.Close();
                    // 

                    // get receiver branch data
                    query = "select * from branches WHERE id = " + row["recieverBranch"];
                    command = new MySqlCommand(query, connection);
                    reader = command.ExecuteReader();
                    reader.Read();
                    string recieverBranch = "#" + reader["id"].ToString() + " " +
                            reader["country"].ToString() + " " +
                            reader["state"].ToString() + " " +
                            reader["city"].ToString() + " " +
                            reader["manager"].ToString();
                    reader.Close();
                    //


                    // panel creating and styling
                    Panel panel = new Panel();
                    panel.BorderStyle = BorderStyle.None;
                    panel.BackColor = System.Drawing.Color.FromArgb(33, 42, 62);
                    panel.Size = new Size(345, 450);
                    panel.Location = new Point(x, y);
                    //

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
                    button.BackColor = System.Drawing.Color.FromArgb(57, 72, 103);
                    button.Cursor = Cursors.Hand;

                    button.MouseClick += (sender3, e3) =>
                    {
                        selectedId = int.Parse(row["id"].ToString());

                        updateCargo form = new updateCargo();
                        form.ShowDialog();
                    };

                    button.MouseEnter += (sender1, e1) =>
                    {
                        button.BackColor = System.Drawing.Color.FromArgb(155, 164, 181);
                    };

                    button.MouseLeave += (sender2, e2) =>
                    {
                        button.BackColor = System.Drawing.Color.FromArgb(57, 72, 103);
                    };

                    panel.Controls.Add(button);
                    //

                    // Barcode creating and displaying
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Location = new Point((panel.Width - pictureBox.Width) / 2, button.Height + 10);
                    pictureBox.BorderStyle = BorderStyle.None;

                    Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                    pictureBox.Image = barcode.Draw(row["barcode"].ToString(), 50);

                    panel.Controls.Add(pictureBox);

                    /*
                    Label barcodeLabel = new Label();
                    barcodeLabel.ForeColor = Color.White;
                    barcodeLabel.Font = new Font("Montserrat Light", 10);
                    barcodeLabel.TextAlign = ContentAlignment.MiddleCenter;
                    barcodeLabel.Location = new Point(25, pictureBox.Location.Y + 15);
                    barcodeLabel.Size = new Size((int)panel.Width, 10);
                    panel.Controls.Add(barcodeLabel);
                    */

                    //

                    // Label creating and adding to panel control
                    Label label = new Label();
                    label.ForeColor = Color.White;
                    label.Font = new Font("Montserrat Light", 10);
                    label.Size = new Size((int)panel.Width, panel.Height + pictureBox.Height);
                    label.Padding = new Padding(3, pictureBox.Height + 30, 0, 0);
                    label.Text = "Id: #" + row["id"].ToString() + "\n" +
                                 "Sender Customer: " + senderCustomer + "\n" +
                                 "Receiver Customer: " + recieverCustomer + "\n" +
                                 "Sender Branch: " + senderBranch + "\n" +
                                 "Receiver Branch: " + recieverBranch + "\n" +
                                 "Entry Date: " + row["entryDate"].ToString() + "\n" +
                                 "Estimated Date: " + row["estimatedDate"].ToString() + "\n" +
                                 "Barcode: " + row["barcode"].ToString() + "\n" +
                                 "Type: " + row["type"].ToString() + "\n" +
                                 "Weight: " + row["weight"].ToString() + "\n" +
                                 "Price: " + row["price"].ToString() + "\n" +
                                 "Payer: " + row["payer"].ToString() + "\n" +
                                 "Description: " + row["description"].ToString() + "\n" +
                                 "Recent: " + row["recent"].ToString() + "\n" +
                                 "Created at: " + row["created_at"].ToString() + "\n" +
                                 "Updated at: " + row["updated_at"].ToString();

                    panel.Controls.Add(label);
                    //

                    // Setting the replacement and view
                    if (rowCount % 3 == 0)
                    {
                        y = panel.Height + 25;
                        x = 10;
                    }
                    else
                    {
                        x += panel.Width + 25;
                    }
                    //

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
