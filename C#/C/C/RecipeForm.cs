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
    public partial class RecipeForm : Form
    {
        public RecipeForm()
        {
            InitializeComponent();
        }

        private void RecipeForm_Load(object sender, EventArgs e)
        {
            // لیست غذاها
            string[] recipes = { "ماکارونی", "قورمه سبزی", "زرشک پلو", "کوکو سبزی", "کوکو سیب زمینی",
                         "آبگوشت", "آش رشته", "کتلت", "قیمه", "استانبولی" };

            lstRecipes.Items.AddRange(recipes); // اضافه کردن غذاها به لیست‌باکس
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // دریافت متن وارد شده در جعبه جستجو و حذف فاصله‌های اضافی
            string searchQuery = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchQuery)) // بررسی اینکه متن جستجو خالی نباشد
            {
                foreach (var item in lstRecipes.Items) // پیمایش آیتم‌های لیست‌باکس
                {
                    if (item.ToString().Contains(searchQuery)) // بررسی مطابقت متن جستجو با آیتم‌ها
                    {
                        OpenRecipeForm(item.ToString()); // باز کردن فرم دستور پخت با آیتم مورد نظر
                        return; // خروج از حلقه پس از یافتن نتیجه
                    }
                }

                MessageBox.Show("غذا یافت نشد!"); // نمایش پیام در صورت عدم یافتن غذا
            }
            else
            {
                MessageBox.Show("لطفاً نام غذا را وارد کنید."); // نمایش پیام در صورت خالی بودن جعبه جستجو
            }
        }

        private void lstRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // بررسی اینکه آیتمی از لیست‌باکس انتخاب شده است
            if (lstRecipes.SelectedItem != null)
            {
                // دریافت آیتم انتخاب‌شده
                string selectedRecipe = lstRecipes.SelectedItem.ToString();
                OpenRecipeForm(selectedRecipe); // باز کردن فرم دستور پخت برای آیتم انتخاب‌شده
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // ایجاد نمونه‌ای از فرم اصلی
            MainForm mainForm = new MainForm();
            mainForm.Show(); // نمایش فرم اصلی
            this.Close(); // بستن فرم فعلی
        }

        private void OpenRecipeForm(string recipeName)
        {
            // ایجاد و نمایش فرم دستور پخت با ارسال نام غذا
            RecipeDetailsForm recipeDetailsForm = new RecipeDetailsForm(recipeName);
            recipeDetailsForm.Show(); // نمایش فرم دستور پخت
            this.Hide(); // مخفی کردن فرم فعلی
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}

