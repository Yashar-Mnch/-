using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent(); // مقداردهی اولیه و آماده‌سازی فرم
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // بستن کل برنامه هنگام کلیک روی دکمه خروج
            Application.Exit();
        }

        private void btnRecipes_Click(object sender, EventArgs e)
        {
            // ایجاد و نمایش فرم دستور پخت‌ها هنگام کلیک روی دکمه مشاهده دستور پخت‌ها
            RecipeForm recipeForm = new RecipeForm(); // ایجاد فرم جدید برای نمایش دستور پخت‌ها
            recipeForm.Show(); // نمایش فرم دستور پخت‌ها
            this.Hide(); // مخفی کردن فرم اصلی برای جلوگیری از نمایش همزمان
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
















