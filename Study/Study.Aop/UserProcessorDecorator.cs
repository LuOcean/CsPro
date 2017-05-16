using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Aop
{
    public class UserProcessorDecorator : IUserProcessor
    {
        public IUserProcessor UserProcessor { get; set; }

        public UserProcessorDecorator(IUserProcessor userprocessor)
        {
            UserProcessor = userprocessor;
        }
        public void RegUser(User user)
        {
            PreProceed(user);
            UserProcessor.RegUser(user);
            PostProceed(user);
        }

        public void PreProceed(User user)
        {
            Console.WriteLine("方法执行前");
        }
        public void PostProceed(User user)
        {
            Console.WriteLine("方法执行后");
        }
    }
}
