using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Autofac.Lib
{
    public class Ioc
    {
        public static T GetService<T>()
        {
            T ret = default(T);
            try
            {
                ret = DependencyResolver.Current.GetService<T>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret;
        }
    }
}
