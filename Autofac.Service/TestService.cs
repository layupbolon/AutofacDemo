using System;
using Autofac.IService;

namespace Autofac.Service
{
    public class TestService : ITestService
    {

        public string GetId()
        {
            return "这是第一个继承ITestService的类";
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
