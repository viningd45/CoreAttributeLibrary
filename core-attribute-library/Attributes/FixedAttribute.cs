using Core.Attribute.Library.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Attribute.Library.Attributes
{
    [System.AttributeUsage(System.AttributeTargets.Property)]
    public class FixedAttribute : System.Attribute, IAttribute
    {
        private readonly bool @fixed;

        public FixedAttribute(bool @fixed)
        {
            this.@fixed = @fixed;
        }

        public object GetAttributeValue()
        {
            return this.@fixed;
        }
    }
}
