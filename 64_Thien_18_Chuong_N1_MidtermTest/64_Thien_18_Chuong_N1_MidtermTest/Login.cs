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
        public string ActualUrl()
        {
            string url = driver_64_Thien_18_Chuong.Url;
            return url;
        }

        public void openUrl()
        {
            driver_64_Thien_18_Chuong.Navigate().GoToUrl("https://www.facebook.com");
        }

        public void loginW(string username, string password)
        {
            IWebElement login = driver_64_Thien_18_Chuong.FindElement(By.Name("email"));
            login.SendKeys(username);
            IWebElement pass = driver_64_Thien_18_Chuong.FindElement(By.Id("pass"));
            pass.SendKeys(password);
            Thread.Sleep(1000);
        }

        public void login_Btn()
        {
            driver_64_Thien_18_Chuong.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div/div/div[2]/div/div[1]/form/div[2]/button")).Click();
        }

        public void inputUserValue(string i)
        {
            IWebElement login = driver_64_Thien_18_Chuong.FindElement(By.Name("email"));
            login.SendKeys(i);
        }

        public void inputPassValue(string i)
        {
            IWebElement pass = driver_64_Thien_18_Chuong.FindElement(By.Name("pass"));
            pass.SendKeys(i);
        }

        public void CloseChrome()
        {
            driver_64_Thien_18_Chuong.Close();
        }
        public void QuitChrome()
        {
            driver_64_Thien_18_Chuong.Quit();
        }
    }
}
