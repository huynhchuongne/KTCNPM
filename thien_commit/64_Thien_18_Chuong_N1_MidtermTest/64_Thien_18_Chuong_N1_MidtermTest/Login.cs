using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace _64_Thien_18_Chuong_N1_MidtermTest
{
    public class Login
    {
        private IWebDriver driver_64_Thien_18_Chuong = new ChromeDriver();
        public Login()
        {

        }

        // Lấy URL hiện tại
        public string ActualUrl()
        {
            string url = driver_64_Thien_18_Chuong.Url;
            return url;
        }

        // Mở trang web facebook
        public void openUrl()
        {
            driver_64_Thien_18_Chuong.Navigate().GoToUrl("https://www.facebook.com");
        }

        // Nhập thông tin tài khoản và mật khẩu 
        public void loginW(string username, string password)
        {
            IWebElement login = driver_64_Thien_18_Chuong.FindElement(By.Id("email"));
            login.SendKeys(username);
            IWebElement pass = driver_64_Thien_18_Chuong.FindElement(By.Id("pass"));
            pass.SendKeys(password);
            Thread.Sleep(1000);
        }

        // Nhấn nút đăng nhập
        public void login_Btn()
        {
            driver_64_Thien_18_Chuong.FindElement(By.Name("login")).Click();
        }

        // Nhập thông tin tài khoản bằng đọc file data.csv
        public void inputUserValue(string i)
        {
            IWebElement login = driver_64_Thien_18_Chuong.FindElement(By.Id("email"));
            login.SendKeys(i);
        }

        //// Nhập thông tin mật khẩu bằng đọc file data.csv
        public void inputPassValue(string i)
        {
            IWebElement pass = driver_64_Thien_18_Chuong.FindElement(By.Id("pass"));
            pass.SendKeys(i);
        }

        // Nhập dữ liêu cần tìm kiếm
        public void enterKeywords(string i)
        {
            IWebElement searchBox_64_Thien = driver_64_Thien_18_Chuong.FindElement(By.CssSelector("input[type='search']"));
            searchBox_64_Thien.SendKeys(i);
            Thread.Sleep(3000);

        }

        // Nhấn enter
        public void enter()
        {
            IWebElement enter_64_Thien = driver_64_Thien_18_Chuong.FindElement(By.CssSelector("input[type='search']"));
            enter_64_Thien.SendKeys(Keys.Enter);
            Thread.Sleep(3000);
        }

        // Nhấn chọn op trong bộ lọc
        public void filter()
        {
            IWebElement chosse_place_64_Thien = driver_64_Thien_18_Chuong.FindElement(By.XPath("//span[text()='Địa điểm']"));
            chosse_place_64_Thien.Click();
        }

        // Nhấn vào avatar 
        public void avatar()
        {
            IWebElement avatar_64_Thien = driver_64_Thien_18_Chuong.FindElement(By.CssSelector("//*[@id=mount_0_0_hc]/div/div[1]/div/div[2]/div[5]/div[1]/span/div/div[1]/div/svg"));
            avatar_64_Thien.Click();
        }

        // Nhấn đăng xuất
        public void logout_btn()
        {
            IWebElement logoutButton = driver_64_Thien_18_Chuong.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[2]/div[5]/div[1]/span/div/div[1]/div/div"));
            logoutButton.Click();
        }



        // Đóng trình duyệt
        public void CloseChrome()
        {
            driver_64_Thien_18_Chuong.Close();
        }

        // Đóng trình duyệt
        public void QuitChrome()
        {
            driver_64_Thien_18_Chuong.Quit();
        }
    }
}
