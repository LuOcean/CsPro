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
            #region 方法一：装饰模式
            //try
            //{
            //    User user = new User() { Name = "lu", PassWord = "123" };
            //    IUserProcessor userprocessor = new UserProcessorDecorator(new UserProcessor());
            //    userprocessor.RegUser(user);
            //}
            //catch (Exception)
            //{

            //    throw;
            //} 
            #endregion

            #region 方法二：代理模式
            try
            {
                User user = new User() { Name = "li", PassWord = "123123123" };
                UserProcessor userprocessor = TransparentProxy.Create<UserProcessor>();
                userprocessor.RegUser(user);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            #endregion

            Console.ReadKey();


        }
    }
}
