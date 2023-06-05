using DMS.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void cargosButton_Click(object sender, EventArgs e)
        {
            cargosUC cargosUC = new cargosUC();
            addUserControl(cargosUC);
        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            customersUC customersUC = new customersUC();
            addUserControl(customersUC);
        }

        private void branchesButton_Click(object sender, EventArgs e)
        {
            branchesUC branchesUC = new branchesUC();
            addUserControl(branchesUC);
        }

        private void main_Load(object sender, EventArgs e)
        {
            cargosUC cargosUC = new cargosUC();
            addUserControl(cargosUC);
        }
    }
}
