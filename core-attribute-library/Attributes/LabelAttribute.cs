using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Attribute.Library.Attributes
{
    [System.AttributeUsage(System.AttributeTargets.Property)]
    public class LabelAttribute : System.Attribute, IAttribute
    {
        private readonly string label;

        public LabelAttribute(string label)
        {
            this.label = label;
        }

        public object GetAttributeValue()
        {
            return this.label;
        }
    }
}
