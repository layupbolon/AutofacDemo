﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.IService;

namespace Autofac.Service
{
    public class TestService : ITestService
    {

        public string GetId()
        {
            return "这是测试数据";
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}