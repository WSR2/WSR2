using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSR2
{
    public partial class AuthorizationForm : Form
    {
        private string _captchaCode = string.Empty;

        public AuthorizationForm()
        {
            InitializeComponent();

            captchaPictureBox.Image = GenerateCaptcha(captchaPictureBox.Width, captchaPictureBox.Height);
            
            loginButton.BackColor = Color.FromArgb(73, 140, 81); //Покрас кнопок
            refreshButton.BackColor = Color.FromArgb(118, 227, 131);
            guestButton.BackColor = Color.FromArgb(73, 140, 81);
        }

        public Bitmap GenerateCaptcha(int Width, int Height) //Создание графической капчи
        {
            Random random = new Random();
            string alphabet = "0123456789QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
            int xPos = (Width - 110);
            int yPos = (Height - 50);
            Bitmap captchaImage = new Bitmap(Width, Height);
            Graphics graphics = Graphics.FromImage(captchaImage);
            Brush[] colors = { Brushes.Yellow, Brushes.Wheat, Brushes.Red, Brushes.Orange, Brushes.Cyan };

            graphics.Clear(Color.Gray);
            _captchaCode = string.Empty;
            
            for (int i = 0; i < 6; i++) //Генерация кода
            {
                _captchaCode += alphabet[random.Next(alphabet.Length)];
            }

            graphics.DrawString(_captchaCode, new Font("Arial", 26, FontStyle.Strikeout), colors[random.Next(colors.Length)], new Point(xPos - random.Next(0, 150), yPos - random.Next(0, 50))); //Рисование букв
            graphics.DrawLine(Pens.Red, new Point(0, 0), new Point(Width, Height)); //Рисование линий
            
            for (int i = 0; i < Width; i++) //Решётка на капче
            {
                for (int j = 0; j < Height; j++)
                {
                    if (i % 10 == 2 || j % 20 == 2)
                    {
                        captchaImage.SetPixel(i, j, Color.White);
                    }
                }
            }

            return captchaImage;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            captchaPictureBox.Image = GenerateCaptcha(captchaPictureBox.Width, captchaPictureBox.Height);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (captchaTextBox.Text != _captchaCode) //Проверка капчи на правильность
            {
                MessageBox.Show("Вы ввели неправильную капчу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                captchaPictureBox.Image = GenerateCaptcha(captchaPictureBox.Width, captchaPictureBox.Height);
                captchaTextBox.Text = "";
                return;
            }
            if (Classes.Database.LoginConfirmation(loginTextBox.Text.ToString(), passwordTextBox.Text.ToString()) == true) //Проверка сущесвующего логина и пароля в БД
            {
                if (Classes.Database.userId == 1)
                {
                    Forms.AdministratorForm administratorForm = new Forms.AdministratorForm();
                    administratorForm.Show();
                    this.Hide();
                }
                if (Classes.Database.userId == 2 || Classes.Database.userId == 3)
                {
                    Forms.ClientForm clientForm = new Forms.ClientForm();
                    clientForm.Show();
                    this.Hide();
                }
                if (Classes.Database.userId == -1)
                {
                    MessageBox.Show("Непредвиденная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Вы ввели неправильный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginTextBox.Text = "";
                passwordTextBox.Text = "";
                captchaPictureBox.Image = GenerateCaptcha(captchaPictureBox.Width, captchaPictureBox.Height);
                captchaTextBox.Text = "";
            }
        }
    }
}
