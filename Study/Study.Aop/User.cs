using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Aop
{
    public class User
    {
        private string name;
        private string password;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string PassWord
        {
            get { return this.password; }
            set { this.password = value; }
        }
    }
}
