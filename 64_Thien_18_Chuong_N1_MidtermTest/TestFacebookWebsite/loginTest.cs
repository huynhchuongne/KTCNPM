using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _64_Thien_18_Chuong_N1_MidtermTest;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;


namespace TestFacebookWebsite
{
    [TestClass]
    public class loginTest
    {
        private IWebDriver driver_64_Thien_18_Chuong;
        //private Login l;
        [TestInitialize]
        public void Setup()
        {

            // Khởi tạo trình duyệt Chrome
            driver_64_Thien_18_Chuong = new ChromeDriver();

            //l = new Login();

            // Mở trang Facebook
            driver_64_Thien_18_Chuong.Navigate().GoToUrl("https://www.facebook.com/");

            //đăng nhập vào 
            IWebElement email_64_Thien_18_Chuong = driver_64_Thien_18_Chuong.FindElement(By.Id("email"));
            email_64_Thien_18_Chuong.SendKeys("thienha290303@gmail.com");

            IWebElement password_64_Thien_18_Chuong = driver_64_Thien_18_Chuong.FindElement(By.Id("pass"));
            password_64_Thien_18_Chuong.SendKeys("123admin@");

            // Click vào nút đăng nhập
            IWebElement loginButton_64_Thien_18_Chuong = driver_64_Thien_18_Chuong.FindElement(By.Name("login"));
            loginButton_64_Thien_18_Chuong.Click();
            System.Threading.Thread.Sleep(9000);

        }

        //[TestMethod]
        //public void SuccessLogin()
        //{
        //    // Nhập thông tin đăng nhập
        //    IWebElement email_64_Thien_18_Chuong = driver_64_Thien_18_Chuong.FindElement(By.Id("email"));
        //    email_64_Thien_18_Chuong.SendKeys("thienha290303@gmail.com");

        //    IWebElement password_64_Thien_18_Chuong = driver_64_Thien_18_Chuong.FindElement(By.Id("pass"));
        //    password_64_Thien_18_Chuong.SendKeys("123admin@");

        //    // Click vào nút đăng nhập
        //    IWebElement loginButton_64_Thien_18_Chuong = driver_64_Thien_18_Chuong.FindElement(By.Name("login"));
        //    loginButton_64_Thien_18_Chuong.Click();
        //}


        //public TestContext TestContext { get; set; }
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        //    @"D:\KTPM\64_Thien_18_Chuong_N1_MidtermTest\TestFacebookWebsite\Data\data.csv",
        //    "data#csv", DataAccessMethod.Sequential)]
        //[TestMethod]
        //public void FailLogin()
        //{
        //    // Nhập thông tin đăng nhập từ file
        //    IWebElement login_64_Thien_18_Chuong = driver_64_Thien_18_Chuong.FindElement(By.Id("email"));
        //    login_64_Thien_18_Chuong.SendKeys(TestContext.DataRow[0].ToString());

        //    // Nhập thông tin mật khẩu từ file
        //    IWebElement pass_64_Thien_18_Chuong = driver_64_Thien_18_Chuong.FindElement(By.Id("pass"));
        //    pass_64_Thien_18_Chuong.SendKeys(TestContext.DataRow[1].ToString());

        //    //Click vào nút đăng nhập
        //    //IWebElement loginButton_64_Thien_18_Chuong = driver_64_Thien_18_Chuong.FindElement(By.Name("login"));
        //    //loginButton_64_Thien_18_Chuong.Click();

        //    string actualurl = l.ActualUrl();
        //    string expectedurl = "https://www.facebook.com/?sk=welcome";
        //    Assert.AreEqual(expectedurl, actualurl);

        //}

        //[TestMethod]
        //public void TestAdvancedSearch()
        //{
        //    System.Threading.Thread.Sleep(9000);
        //    // Nhập từ khóa cần tìm kiếm vào ô tìm kiếm
        //    IWebElement searchBox_64_Thien_18_Chuong = driver_64_Thien_18_Chuong.FindElement(By.CssSelector("input[type='search']"));
        //    searchBox_64_Thien_18_Chuong.SendKeys("Long An");
        //    //searchBox_64_Thien_18_Chuong.SendKeys(Keys.Enter);

        //    //// Click vào nút tìm kiếm
        //    IWebElement enter_64_Thien_18_Chuong = driver_64_Thien_18_Chuong.FindElement(By.CssSelector("input[type='search']"));
        //    enter_64_Thien_18_Chuong.SendKeys(Keys.Enter);



        //    //// Sử dụng bộ lọc để chính xác hóa kết quả tìm kiếm


        //    //IWebElement last24HoursFilter_64_Thien_18_Chuong = driver_64_Thien_18_Chuong.FindElement(By.CssSelector("li[data-key='filter_date'] button[data-key='24h']"));
        //    //last24HoursFilter_64_Thien_18_Chuong.Click();

        //    //// Chờ kết quả tìm kiếm mới được tải lại với bộ lọc đã áp dụng
        //    //System.Threading.Thread.Sleep(2000);

        //}


                [TestMethod]
        public void TestCreateStatus()
        {

            Thread.Sleep(3000);
            IWebElement click_add_64_Thien_18_Chuong = driver_64_Thien_18_Chuong.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[2]/div[5]/div[1]/div[2]/div[2]/span/div"));
            click_add_64_Thien_18_Chuong.Submit();
            Thread.Sleep(5000);
            IWebElement click_ad_64_Thien_18_Chuong = driver_64_Thien_18_Chuong.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[2]/div[5]/div[2]/div/div/div[1]/div[1]/div/div/div/div/div/div/div/div[2]/div[1]/div/div[1]/div[2]/div"));
            click_ad_64_Thien_18_Chuong.Click();
            System.Threading.Thread.Sleep(4000);
            IWebElement put_64_Thien_18_Chuong = driver_64_Thien_18_Chuong.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[4]/div/div/div[1]/div/div[2]/div/div/div/form/div/div[1]/div/div/div/div[2]/div[1]/div[1]/div[1]/div/div/div[1]/p"));
            put_64_Thien_18_Chuong.SendKeys("tạo");
            System.Threading.Thread.Sleep(2000);
            IWebElement click_btn_64_Thien_18_Chuong = driver_64_Thien_18_Chuong.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[4]/div/div/div[1]/div/div[2]/div/div/div/form/div/div[1]/div/div/div/div[3]/div[2]/div/div"));
            click_btn_64_Thien_18_Chuong.Click();
            


        }

    }
}
