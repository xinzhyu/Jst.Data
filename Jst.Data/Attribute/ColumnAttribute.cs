using System;
using System.Collections.Generic;
using System.Text;

namespace Jst.Data.Attribute
{
    public class ColumnAttribute: System.Attribute
    {
        public bool IsPk { get; set; }
        public ColumnAttribute(bool IsPk=false,string columnName="")
        {
            this.IsPk = IsPk;
        }
    }
}
