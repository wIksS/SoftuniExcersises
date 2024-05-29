using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property)]
    public class DocumentationAttribute : Attribute
    {
        public DocumentationAttribute()
        {

        }
        public DocumentationAttribute(string moreInfo)
        {
            MoreInfo = moreInfo;
        }
        public string MoreInfo { get; set; }
    }
}
