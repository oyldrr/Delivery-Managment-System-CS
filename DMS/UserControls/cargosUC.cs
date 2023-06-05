using DMS.forms.addForms;
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
    public partial class cargosUC : UserControl
    {
        public cargosUC()
        {
            InitializeComponent();
        }

        private void addCargoButton_Click(object sender, EventArgs e)
        {
            addCargo form = new addCargo();
            form.ShowDialog();
        }


        private void searchBox_Enter(object sender, EventArgs e)
        {
            searchBox.Text = "";
        }
    }
}
