using System;
using System.Collections.Generic;
using System.Text;

using Jst.Data.Attribute;

namespace Jst.Data.Test
{

    public class User
    {
        [Column(IsPk:true)]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Pwd { get; set; }

        [Column(columnName:"co_id")]
        public int CompanyId { get; set; }

        public int Creater { get; set; }

        public DateTime Created { get; set; }

        public int Modifyer { get; set; }

        public DateTime ModifyTime { get; set; }
    }
}
