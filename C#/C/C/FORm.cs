using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Xml.Linq;


namespace C
{
    public partial class FORm : Form
    {
       

        public FORm()
        {
            InitializeComponent();
            
        }

        private void buttonn_Click(object sender, EventArgs e)
        {
            // دریافت نام کاربری و رمز عبور از تکست‌باکس‌ها
            string Username = textBox.Text;
            string Password = textBoxx.Text;

            // اعتبارسنجی اینکه هیچ فیلدی خالی نباشد
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // اتصال به دیتابیس و درج اطلاعات ثبت‌نام
            try
            {
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:A.accdb"; /*\Users\NITRO\Documents\*/

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    // تعریف کوئری برای درج نام کاربری و رمز عبور در جدول
                    string query = "INSERT INTO [Users] ([Username], [Password]) VALUES (?, ?)";

                    OleDbCommand command = new OleDbCommand(query, connection);

                    // اضافه کردن مقادیر به پارامترهای کوئری
                    command.Parameters.AddWithValue("?", Username);
                    command.Parameters.AddWithValue("?", Password);

                    // باز کردن اتصال به دیتابیس
                    connection.Open();

                    // اجرای دستور درج
                    command.ExecuteNonQuery();

                    // نمایش پیام موفقیت ثبت‌نام
                    MessageBox.Show("Registration successful!");

                    // باز کردن فرم ورود پس از ثبت‌نام
                    FORMM fORMM = new FORMM();
                    fORMM.Show();

                    // بستن اتصال به دیتابیس
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // نمایش پیام خطا در صورت بروز مشکل
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // باز کردن فرم ورود به سیستم
            FORMM loginForm = new FORMM();
            loginForm.Show();

            // مخفی کردن فرم ثبت‌نام برای جلوگیری از تداخل
            this.Hide();
        }

        private void FORm_Load(object sender, EventArgs e)
        {

        }
    }
}



