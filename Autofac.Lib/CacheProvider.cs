using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofac.Lib
{
    public class CacheProvider : ICacheProvider
    {
        private string _name;
        public CacheProvider(string name)
        {
            _name = name;
        }

        public void Get(string key)
        {
            throw new NotImplementedException();
        }

        public void Set(string key, string value)
        {
            throw new NotImplementedException();
        }

        public string ShowName()
        {
            return _name;
        }
    }
}
