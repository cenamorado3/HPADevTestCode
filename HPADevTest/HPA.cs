using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace HPADevTest
{
    class HPA
    {
        FirefoxDriver driver = new FirefoxDriver();

        public void stepOne()
        {
            driver.Url = "http://hpa.services/automation-challenge/";
            driver.FindElementById("BoxParagraph1").Click();
            driver.SwitchTo().Alert().Dismiss();
            System.Threading.Thread.Sleep(1000);
        }

        public void stepTwo()
        {
            driver.FindElementById("Box3").SendKeys(Keys.Tab);
            driver.SwitchTo().Alert().Accept();
            System.Threading.Thread.Sleep(1000);
        }

        public void stepThree()
        {
            IWebElement optionVal = driver.FindElementById("optionVal");
            string optionValInnerText = optionVal.Text;
            Console.WriteLine(optionValInnerText);


            if (optionValInnerText == "1")
            {
                IWebElement optionOne = driver.FindElementByXPath("//input[@type='radio'][@value='1']");
                optionOne.Click();
                System.Threading.Thread.Sleep(1000);
                driver.SwitchTo().Alert().Accept();
                System.Threading.Thread.Sleep(1000);
            }

            else if (optionValInnerText == "2")
            {
                IWebElement optionTwo = driver.FindElementByXPath("//input[@type='radio'][@value='2']");
                optionTwo.Click();
                System.Threading.Thread.Sleep(1000);
                driver.SwitchTo().Alert().Accept();
                System.Threading.Thread.Sleep(1000);
            }
        }

        public void stepFour()
        {
            driver.FindElementByXPath("//select").Click();
            IWebElement selection = driver.FindElementByXPath("//span[@id='selectionVal']");
            string selectionVal = selection.Text;

            if (selectionVal == "Robots")
            {
                driver.FindElementById("selectionOption1").Click();
                System.Threading.Thread.Sleep(1000);
                driver.SwitchTo().Alert().Accept();
            }

            else if (selectionVal == "can")
            {
                driver.FindElementById("selectionOption2").Click();
                System.Threading.Thread.Sleep(1000);
                driver.SwitchTo().Alert().Accept();
            }

            else if (selectionVal == "do")
            {
                driver.FindElementById("selectionOption3").Click();
                System.Threading.Thread.Sleep(1000);
                driver.SwitchTo().Alert().Accept();
            }

            else if (selectionVal == "anything")
            {
                driver.FindElementById("selectionOption4").Click();
                System.Threading.Thread.Sleep(1000);
                driver.SwitchTo().Alert().Accept();
            }

        }

        public string stepFive()
        {
            driver.FindElementByXPath("//input[@id='formDate'][@placeholder='2017-05-04']").SendKeys("2017-05-04");
            driver.FindElementByXPath("//input[@id='formCity'][@placeholder='Nashville']").SendKeys("Nashville");
            driver.FindElementByXPath("//input[@id='formState'][@placeholder='Tennessee']").SendKeys("Tennessee");
            driver.FindElementByXPath("//input[@id='formCountry'][@placeholder='USA']").SendKeys("USA");
            driver.FindElementByXPath("//input[@id='formDate'][@placeholder='2009-08-26']").SendKeys("2009-08-26");
            driver.FindElementByXPath("//input[@id='formCity'][@placeholder='Seattle']").SendKeys("Seattle");
            driver.FindElementByXPath("//input[@id='formState'][@placeholder='Washington']").SendKeys("Washington");
            driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);
            driver.SwitchTo().ActiveElement().SendKeys("USA");
            driver.FindElementByXPath("//input[@id='formDate'][@placeholder='2007-10-10']").SendKeys("2007-10-10");
            driver.FindElementByXPath("//button").SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(1000);
            driver.SwitchTo().Alert().Accept();
            IWebElement result = driver.FindElementById("formResult");
            string formResult = result.Text;
            return formResult;
        }

        public void stepSix()
        {

            string formResult = stepFive();
            IWebElement line = driver.FindElementById("lineNum");
            string lineNum = line.Text;
            string lineSelect = "//tbody/tr[" + lineNum + "]/td[2]/input";
            IWebElement inputLine = driver.FindElementByXPath(lineSelect);
            inputLine.Clear();
            System.Threading.Thread.Sleep(1000);
            inputLine.SendKeys(formResult);
            System.Threading.Thread.Sleep(1000);
            inputLine.SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(1000);

        }


        public void OverloadStep(int step)
        {
            try
            {
                string stepNum = "Box" + Convert.ToString(step);

                IWebElement box = driver.FindElementById(stepNum);
                box.Click();
                System.Threading.Thread.Sleep(3000);
            }

            catch(UnhandledAlertException)
            {
                string stepNum = "Box" + Convert.ToString(step);
                IWebElement box = driver.FindElementById(stepNum);
                box.Click();
                System.Threading.Thread.Sleep(5000);
                driver.SwitchTo().Alert().Dismiss();
                System.Threading.Thread.Sleep(3000);
            }
        }

    }
}

