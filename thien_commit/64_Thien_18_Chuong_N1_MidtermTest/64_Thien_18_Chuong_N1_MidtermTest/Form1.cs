using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace _64_Thien_18_Chuong_N1_MidtermTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_64_Thien_18_Chuong_Click(object sender, EventArgs e)
        {
            // Đóng màn hình đen
            //ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            //chrome.HideCommandPromptWindow = true;
            // Mở trình duyệt
            //IWebDriver driver_64_Thien_18_Chuong = new ChromeDriver(chrome);
            //driver_64_Thien_18_Chuong.Navigate().GoToUrl("https://www.facebook.com");

            ////// click nút đăng ký 
            //driver_64_Thien_18_Chuong.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div/div/div[2]/div/div[1]/form/div[5]/a")).Click();

            //// Đăng ký tài khoản
            //IWebElement firstname_64_Thien_18_Chuong = driver_64_Thien_18_Chuong.FindElement(By.Name("firstname"));
            //firstname_64_Thien_18_Chuong.SendKeys("Ha");

            //IWebElement lastname_64_Thien_18_Chuong = driver_64_Thien_18_Chuong.FindElement(By.Name("lastname"));
            //lastname_64_Thien_18_Chuong.SendKeys("Thien");

            //IWebElement email_64_Thien_18_Chuong = driver_64_Thien_18_Chuong.FindElement(By.Name("reg_email__"));
            //email_64_Thien_18_Chuong.SendKeys("Thien@gmail.com");

            //IWebElement passw_64_Thien_18_Chuong = driver_64_Thien_18_Chuong.FindElement(By.Name("reg_passwd__"));
            //passw_64_Thien_18_Chuong.SendKeys("Thien12345");

            //IWebElement day_64_Thien_18_Chuong = driver_64_Thien_18_Chuong.FindElement(By.Name("birthday_day"));
            //day_64_Thien_18_Chuong.;




            // Đăng nhập tài khoản
            //IWebElement login_64_Thien_18_Chuong = driver_64_Thien_18_Chuong.FindElement(By.Name("email"));
            //login_64_Thien_18_Chuong.SendKeys("thienha290303@gmail.com");

            //IWebElement pass_64_Thien_18_Chuong = driver_64_Thien_18_Chuong.FindElement(By.Id("pass"));
            //pass_64_Thien_18_Chuong.SendKeys("123admin@");

            //driver_64_Thien_18_Chuong.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div/div/div[2]/div/div[1]/form/div[2]/button")).Click();




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
