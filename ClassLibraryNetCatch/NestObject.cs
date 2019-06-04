using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryNetCatch
{
    public class NestObject
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string No { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 子集
        /// </summary>
        public IList<NestObject> Children { get; set; }
    }
}

