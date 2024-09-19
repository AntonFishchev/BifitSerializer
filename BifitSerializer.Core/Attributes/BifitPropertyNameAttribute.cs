using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BifitSerialiser.Core.Attributes
{
    public class BifitPropertyNameAttribute : Attribute
    {
        public string PropertyName { get; set; }

        public BifitPropertyNameAttribute(string propertyName)
        {
            PropertyName = propertyName;
        }
    }
}
