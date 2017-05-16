using System;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;

namespace Study.Aop
{
    public class MyRealProxy<T> : RealProxy
    {
        private T _target;

        public MyRealProxy(T target) : base(typeof(T))
        {
            _target = target;
        }
        public override IMessage Invoke(IMessage msg)
        {
            PreProceed(msg);
            IMethodCallMessage callMessage = (IMethodCallMessage)msg;
            object returnValue = callMessage.MethodBase.Invoke(_target, callMessage.Args);
            PostProceed(msg);
            return new ReturnMessage(returnValue, new object[0], 0, null, callMessage);
        }
        public void PreProceed(IMessage msg)
        {
            Console.WriteLine("方法执行前");
        }
        public void PostProceed(IMessage msg)
        {
            Console.WriteLine("方法执行后");
        }
    }
}
