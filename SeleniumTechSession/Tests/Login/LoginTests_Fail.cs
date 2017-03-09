using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SeleniumTechSession.Tests
{
    
    public class LoginTests_Fail : Test, IClassFixture<Setup>
    {
        public LoginTests_Fail(Setup setup) : base(setup) { }

        [Theory]
        [InlineData("mood.admin","banana123", "The username and/or password is incorrect.")]
        [InlineData("banana", "_Ts0rg123", "The username and/or password is incorrect.")]
        [InlineData("apples", "banana123", "The username and/or password is incorrect.")]
        public void Login_Fail(string userName, string password, string errorMessage)
        {
            login.LoginDetails(userName, password);

            Thread.Sleep(2000);

            Assert.True(login.ErrorMessage().Contains(errorMessage));

            login.ClearText();
        }
    }
}
