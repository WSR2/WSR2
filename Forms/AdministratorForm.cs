using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSR2.Forms
{
    public partial class AdministratorForm : Form
    {
        public AdministratorForm()
        {
            InitializeComponent();

            productsDataGridView.GridColor = Color.FromArgb(118, 227, 131);
            userLabel.Text = "Вы вошли как:";
            userLabel.Text = userLabel.Text + " " + Classes.Database.GetUserRoleName(Classes.Database.userId);
            //Classes.Database.GetProducts(productsDataGridView);
        }
    }
}
