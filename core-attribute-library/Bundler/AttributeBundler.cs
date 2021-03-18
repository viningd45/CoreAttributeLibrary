using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Core.Attribute.Library.Attributes;

namespace Core.Attribute.Library.Bundler
{
    public class AttributeBundler
    {
        public AttributeBundler(Type type)
        {
            this.type = type;
        }

        private readonly Type type;

        public Dictionary<string, Dictionary<string, object>> GetAttributes()
        {
            Dictionary<string, Dictionary<string, object>> _dict = new Dictionary<string, Dictionary<string, object>>();

            PropertyInfo[] props = type.GetProperties();
            foreach (PropertyInfo prop in props)
            {
                object[] attrs = prop.GetCustomAttributes(true);

                Dictionary<string, object> _nameValDict = new Dictionary<string, object>();

                foreach (object attr in attrs)
                {
                    string attrName = attr.GetType().Name.Replace("Attribute", string.Empty);
                    IAttribute iAttr = attr as IAttribute;

                    if (iAttr != null)
                    {
                        object val = iAttr.GetAttributeValue();
                        _nameValDict.Add(attrName, val);
                    }
                }

                string propName = prop.Name;
                _dict.Add(propName, _nameValDict);
            }

            return _dict;
        }
    }
}
