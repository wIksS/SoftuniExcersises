using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributes
{
    
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Constructor)]
    public class DocumentAttribute : Attribute
    {
        public DocumentAttribute()
        {
            Color = ConsoleColor.DarkCyan;
        }
        public DocumentAttribute(bool isCritical)
        {
            IsCritical = isCritical;
            Color = ConsoleColor.DarkCyan;

        }

        public bool IsCritical { get; set; }

        public ConsoleColor Color { get; set; }
    }
}
