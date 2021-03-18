using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Attribute.Library.Attributes
{
    internal interface IAttribute
    {
        object GetAttributeValue();
    }
}
