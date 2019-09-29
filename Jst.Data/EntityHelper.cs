using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

using Jst.Data.Attribute;

namespace Jst.Data
{
    public class EntityHelper<T> where T:class,new()
    {
        public static Entity Load()
        {
            var t = typeof(T);

            Entity entity = new Entity();
            entity.TableName = t.Name;

            var properties = t.GetProperties();
            foreach (var property in properties)
            {
                //这里只做一个stringlength的验证，这里如果要做很多验证，需要好好设计一下,千万不要用if elseif去链接
                //会非常难于维护，类似这样的开源项目很多，有兴趣可以去看源码。
                if (!property.IsDefined(typeof(ColumnAttribute), false)) continue;

                var attributes = property.GetCustomAttributes();
                foreach (var attribute in attributes)
                {
                    //这里的MaximumLength 最好用常量去做
                    var IsPk = (bool)attribute.GetType().GetProperty("IsPk").GetValue(attribute);
                    if(IsPk)
                    {
                        entity.PkField = property.Name;
                    }


                }
            }

            
            entity.PkField = "Id";
            return entity;
        }
    }
}
