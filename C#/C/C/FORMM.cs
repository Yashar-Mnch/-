using System;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Xml.Linq;


namespace C
{
    public partial class FORMM : Form
    {

        private void FORMM_Load(object sender, EventArgs e)
        {
            // تنظیم فوکوس اولیه روی تکست باکس نام کاربری
            txtUsername.Select();
        }

        public FORMM()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // رشته اتصال به دیتابیس Access
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:A.accdb";/* \Users\NITRO\Documents\*/

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // بررسی وجود کاربر با نام کاربری و رمز عبور وارد شده
                    string query = "SELECT * FROM [Users] WHERE [Username] = @Username AND [Password] = @Password";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", txtUsername.Text); // مقداردهی پارامتر نام کاربری
                    command.Parameters.AddWithValue("@Password", txtPassword.Text); // مقداردهی پارامتر رمز عبور

                    OleDbDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        // در صورت صحیح بودن اطلاعات، نمایش پیام موفقیت و باز کردن فرم اصلی
                        MessageBox.Show("Login successful!");
                        MainForm mainForm = new MainForm();  // ایجاد نمونه‌ای از فرم اصلی
                        mainForm.Show();  // نمایش فرم اصلی
                        this.Hide();  // مخفی کردن فرم ورود
                        connection.Close();
                    }
                    else
                    {
                        // نمایش پیام خطا در صورت اشتباه بودن اطلاعات
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            }
            catch (Exception ex)
            {
                // مدیریت خطاهای احتمالی و نمایش پیام خطا
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // باز کردن فرم ثبت‌نام
            FORm registerForm = new FORm();  // ایجاد نمونه‌ای از فرم ثبت‌نام
            registerForm.Show();  // نمایش فرم ثبت‌نام
            this.Hide();  // مخفی کردن فرم ورود
        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}



