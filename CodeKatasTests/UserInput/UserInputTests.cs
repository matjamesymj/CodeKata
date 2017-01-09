using System;
using CodeKatas.UserInput;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKatasTests.UserInput
{
    [TestClass()]
    public class UserInputTests
    {
        [TestMethod()]
        public void AddTestIgnoreNonNumeric()
        {
            TextInput input = new NumericInput();

            input.Add('1');
            input.Add('m');
            input.Add('0');
            Assert.AreEqual("10", input.GetValue());

        }

        [TestMethod()]
        public void AddTestTextInput()
        {
            TextInput input = new TextInput();

            input.Add('1');
            input.Add('m');
            input.Add('0');
            input.Add('!');
            Assert.AreEqual("1m0!", input.GetValue());

        }
    }
}