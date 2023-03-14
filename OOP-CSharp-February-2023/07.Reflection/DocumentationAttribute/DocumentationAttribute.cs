using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentationAttributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple =true)]
    public class DocumentationAttribute : Attribute
    {
        public DocumentationAttribute(string documentation)
        {
            Documentation = documentation;
        }
        public DocumentationAttribute()
        {

        }

        public string Documentation { get; set; }
    }
}
