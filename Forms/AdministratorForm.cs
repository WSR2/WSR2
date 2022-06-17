using System.Drawing;
using System.Windows.Forms;

namespace WSR2.Forms
{
    public partial class AdministratorForm : Form
    {
        public AdministratorForm()
        {
            InitializeComponent();

            productsDataGridView.GridColor = Color.FromArgb(118, 227, 131);
            deleteButton.BackColor = Color.FromArgb(73, 140, 81);
            changeButton.BackColor = Color.FromArgb(73, 140, 81);
            userLabel.Text = "Вы вошли как:";
            userLabel.Text = userLabel.Text + " " + Classes.Database.GetUserRoleName(Classes.Database.userId.ToString());
            Classes.Database.GetProducts(productsDataGridView);
        }

        private void ChangeButton_Click(object sender, System.EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, System.EventArgs e)
        {
            
        }
    }
}
