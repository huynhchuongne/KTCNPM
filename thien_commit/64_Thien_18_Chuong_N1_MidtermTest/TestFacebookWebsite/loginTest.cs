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
        private Login login_64_thien_18_Chuong = new Login();
        [TestInitialize]
        public void Setup()
        {

            login_64_thien_18_Chuong.openUrl();
        }

        //[TestMethod]
        //public void SuccessLogin_64_Thien()
        //{
        //    string username = "thienha290303@gmail.com";
        //    string password = "123admin@";
        //    // Nhập thông tin đăng nhập
        //    login_64_thien_18_Chuong.loginW(username, password);

        //    // Click vào nút đăng nhập
        //    login_64_thien_18_Chuong.login_Btn();

        //    string actual = login_64_thien_18_Chuong.ActualUrl();
        //    string expected = "https://www.facebook.com/?sk=welcome";
        //    Assert.AreEqual(expected, actual);
        //    Thread.Sleep(7000);
        //    login_64_thien_18_Chuong.QuitChrome();
        //}



        //public TestContext TestContext { get; set; }
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        //    @"D:\KTPM\64_Thien_18_Chuong_N1_MidtermTest\TestFacebookWebsite\Data\data.csv",
        //    "data#csv", DataAccessMethod.Sequential)]
        //[TestMethod]
        //public void FailLogin_64_Thien()
        //{
        //    string username = Convert.ToString(TestContext.DataRow[0]);
        //    string password = Convert.ToString(TestContext.DataRow[1]);
        //    // Nhập thông tin đăng nhập từ file
        //    login_64_thien_18_Chuong.inputUserValue(username);

        //    // Nhập thông tin mật khẩu từ file
        //    login_64_thien_18_Chuong.inputPassValue(password);

        //    //Click vào nút đăng nhập
        //    login_64_thien_18_Chuong.login_Btn();

        //    string actual = login_64_thien_18_Chuong.ActualUrl();
        //    string expected = "https://www.facebook.com/?sk=welcome";
        //    Assert.AreEqual(expected, actual);

        //}



        //[TestMethod]
        //public void TestAdvancedSearch_64_Thien()
        //{
        //    //Đăng nhập trước khi tìm kiếm 
        //    string username = "thienha290303@gmail.com";
        //    string password = "123admin@";
        //    login_64_thien_18_Chuong.loginW(username, password);
        //    login_64_thien_18_Chuong.login_Btn();

        //    // Nhập từ khóa cần tìm kiếm vào ô tìm kiếm
        //    login_64_thien_18_Chuong.enterKeywords("Long An");

        //    // Click vào nút tìm kiếm và enter
        //    login_64_thien_18_Chuong.enter();

        //    // Sử dụng bộ lọc để chính xác hóa kết quả tìm kiếm
        //    login_64_thien_18_Chuong.filter();
        //}

    }
}
