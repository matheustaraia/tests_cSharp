using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVericode.Support
{
    public class Reports
    {
        //Alterando o path para a adição dos screenshot's do teste
        public static String dir = AppDomain.CurrentDomain.BaseDirectory;        
        public static String testResultpath = dir.Replace("bin\\Debug\\net6.0" , "TestResults");
        //método de adição de screenshot criado para utilização no projeto 
        public string addScreenShot(IWebDriver driver, String pathtitle)
        {
            
            ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
            Screenshot screenshot = takesScreenshot.GetScreenshot();
            string screenshotpath =  Path.Combine(testResultpath, pathtitle + ".png");
            screenshot.SaveAsFile(screenshotpath);
            
            return screenshotpath;
        }
    }
}

