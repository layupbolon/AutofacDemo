using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.IService;

namespace Autofac.Service
{
    public class TestThreeService : ITestService
    {
        public string GetId()
        {
            return "这是第三个继承ITestService的类";
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
