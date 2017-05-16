using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Aop
{
    public class UserProcessor : MarshalByRefObject, IUserProcessor
    {
        public void RegUser(User user)
        {
            Console.WriteLine("用户已注册! Name:{0},PassWord:{1}", user.Name, user.PassWord);
        }
    }
}
