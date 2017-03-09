using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SeleniumTechSession.Tests
{
    public class LoginTests_Success : Test, IClassFixture<Setup>
    {
        public LoginTests_Success(Setup setup) : base(setup) { }

        [Fact]
        public void Login_Success()
        {
            login.LoginDetails("mood.admin", "_Ts0rg123");

            Thread.Sleep(2000);

            Assert.True(driver.Title == "Business Landscape Explorer");
        }
    }
}
