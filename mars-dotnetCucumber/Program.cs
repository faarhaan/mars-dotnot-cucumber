using mars_dotnetCucumber.Pages;
using mars_dotnetCucumber.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class Program 
{
    public static void Main(string[] args)
    {
        //  Launch Mars Portal
        IWebDriver driver = new ChromeDriver();
        LoginPage loginPageObj = new LoginPage();
        loginPageObj.LoginActions(driver);

        // Verify user is loged in successfully
        HomePage homePageObj = new HomePage();
        homePageObj.userIsInHomePage(driver);

        // Add languages to the list
        LSPage lSObj = new LSPage();
        lSObj.languagePage(driver);

        // Add Skills to the List
        LSPage lSPageObj = new LSPage();
        lSPageObj.SkillPage(driver);

        /*// Update Last Language
        LSPage lSPageObj = new LSPage();
        lSPageObj.UpdateLastRecord(driver);*/
            
 
        

        
    }






}