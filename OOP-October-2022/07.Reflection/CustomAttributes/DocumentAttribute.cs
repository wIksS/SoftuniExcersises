using System;
using System.Collections.Generic;
using System.Text;

namespace CustomAttributes
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class DocumentAttribute : Attribute
    {
        public DocumentAttribute(string documenterName)
        {
            DocumenterName = documenterName;
        }
        public DocumentAttribute()
        {

        }

        public string DocumenterName { get; set; }

        public int Criticality { get; set; }
    }
}
