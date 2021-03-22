using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Attribute.Library.Attributes
{
    [System.AttributeUsage(System.AttributeTargets.Property)]
    public class VisibleAttribute : System.Attribute, IAttribute
    {
        private readonly bool visible;

        public VisibleAttribute(bool visible)
        {
            this.visible = visible;
        }

        public object GetAttributeValue()
        {
            return this.visible;
        }
    }
}
