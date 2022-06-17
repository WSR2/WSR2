using System.Drawing;
using System.Windows.Forms;

namespace WSR2.Forms
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();

            productsDataGridView.GridColor = Color.FromArgb(118, 227, 131);
            userLabel.Text = "Вы вошли как:";
            userLabel.Text = userLabel.Text + " " + Classes.Database.GetUserRoleName(Classes.Database.userId.ToString());
            Classes.Database.GetProducts(productsDataGridView);
        }
    }
}
