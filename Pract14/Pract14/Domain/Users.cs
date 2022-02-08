using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Pract14
{
    public static class Users
    {
        public static User StandardUser = new User { Username = "standard_user" };
        public static User LockedOutUser = new User { Username = "locked_out_user" };
        public static User ProblemUser = new User { Username = "problem_user" };
        public static User PerfomanceGlitchUser = new User { Username = "performance_glitch_user" };

        static Users()
        {
            StandardUser.Password = Configurator.Password;
            LockedOutUser.Password = Configurator.Password;
            ProblemUser.Password = Configurator.Password;
            PerfomanceGlitchUser.Password = Configurator.Password;
        }
    }
}
