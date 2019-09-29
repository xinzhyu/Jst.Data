using System;
using System.Collections.Generic;
using System.Text;

namespace Jst.Data
{
    public class QuerySection<T> where T:class,new()
    {
        public string WhereClip { get; set; }

        Entity entity = new Entity();
        public QuerySection()
        {
            entity = EntityHelper<T>.Load();
        }

        public QuerySection(Entity entity)
        {
            this.entity = entity;
        }

        public List<T> ToList()
        {
            return new List<T>();
        }

        public string GetWhereClip()
        {
            if(!string.IsNullOrEmpty(this.WhereClip))
            {
                return $"where {WhereClip}";
            }

            return string.Empty;
        }

        public string ToSql()
        {
            return $"select * from {entity.TableName} {GetWhereClip()}";
        }
    }
}
