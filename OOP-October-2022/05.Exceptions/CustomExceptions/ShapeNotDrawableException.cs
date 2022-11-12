using System;
using System.Collections.Generic;
using System.Text;

namespace CustomExceptions
{
    internal class ShapeNotDrawableException : Exception
    {
        public ShapeNotDrawableException(string message, string shapeType) : base(message)
        {
            ShapeType = shapeType;            
        }

        public ShapeNotDrawableException(string message, Exception ex):base(message, ex)
        {

        }

        public string ShapeType { get; set; }
    }
}
