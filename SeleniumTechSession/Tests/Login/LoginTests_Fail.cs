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
    }
}
