using System;

namespace Jst.Data
{
    public class FromSection<T> where T:class,new()
    {
        public QuerySection<T> Where()
        {
            return new QuerySection<T>();
        }

        public QuerySection<T> Where(object v)
        {
            Entity entity = EntityHelper<T>.Load();
            var query = new QuerySection<T>();
            query.WhereClip = $"{entity.PkField}={v}";

            return query;
        }
    }
}