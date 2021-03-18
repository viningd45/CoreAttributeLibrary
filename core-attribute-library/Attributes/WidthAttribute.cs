using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Attribute.Library.Attributes
{
    [System.AttributeUsage(System.AttributeTargets.Property)]
    public class WidthAttribute : System.Attribute, IAttribute
    {
        private readonly int width;

        public WidthAttribute(int width)
        {
            this.width = width;
        }

        public object GetAttributeValue()
        {
            return this.width;
        }
    }
}
