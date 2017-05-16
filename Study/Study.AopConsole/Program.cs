using Study.Aop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.AopConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                User user = new User() { Name = "lu", PassWord = "123" };
                IUserProcessor userprocessor = new UserProcessorDecorator(new UserProcessor());
                userprocessor.RegUser(user);

                Console.ReadKey();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
