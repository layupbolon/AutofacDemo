using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofac.Lib
{
    public interface ICacheProvider
    {
        void Get(string key);

        void Set(string key, string value);

        string ShowName();
    }
}
