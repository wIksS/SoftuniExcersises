using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtriticalMethods
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Class, AllowMultiple =true)]
    public class CriticalAttribute : Attribute
    {
        public CriticalAttribute(Severity severity)
        {
            Severity = severity;
        }
        public CriticalAttribute()
        {

        }
        public Severity Severity { get; set; }
        public string Message { get; set; }
    }
}

public enum Severity
{
    Low,
    Moderate,
    Critical
}