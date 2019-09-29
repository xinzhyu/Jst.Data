using System;
using System.Collections.Generic;
using System.Text;

namespace Jst.Data
{
    public class DbSession
    {
        public static DbSession Default = new DbSession();

        public FromSection<T> From<T>() where T:class,new()
        {
            return new FromSection<T>();
        }
    }
}
