using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BulidCodeDB
{
    /// <summary>
    /// 数据表的列信息类
    /// </summary>
    public class ColumnContent
    {
        public ColumnContent() { }
        public ColumnContent(string key, int identity,string colName,string typeName,int _byte,
            int length,int xscale, int isnullable,string _default,string comment) {
            this.Key = key;
            this.Identity = identity;
            this.ColName = colName;
            this.TypeName = typeName;
            this.Byte = _byte;
            this.Length = length;
            this.Xscale = xscale;
            this.Isnullable = isnullable;
            this.Default = _default;
            this.Comment = comment;
        }
        public string Key { get; set; }
        public int Identity { get; set; }
        public string ColName { get; set; }
        public string TypeName { get; set; }
        public int Byte { get; set; }
        public int Length { get; set; }
        public int Xscale { get; set; }
        public int Isnullable { get; set; }
        public string Default { get; set; }
        public string Comment { get; set; }
    }

    /// <summary>
    /// 表信息
    /// </summary>
    public class TableList
    {
        public string tablename { get; set; }
        public string tabletitle { get; set; }
    }
}
