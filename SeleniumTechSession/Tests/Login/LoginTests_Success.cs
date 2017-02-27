using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SeleniumTechSession.Tests
{
    public class LoginTests_Success : Test, IClassFixture<Setup>
    {
        public LoginTests_Success(Setup setup) : base(setup) { }
    }
}
