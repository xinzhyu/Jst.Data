using System;
using System.Collections.Generic;
using System.Text;

namespace Jst.Data
{
    public class Entity
    {
        /// <summary>
        /// 表名
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// 主键字段
        /// </summary>
        public string PkField { get; set; }
    }
}
