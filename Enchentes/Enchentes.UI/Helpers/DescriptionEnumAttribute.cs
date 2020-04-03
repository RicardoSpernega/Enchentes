using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Enchentes.UI.Helpers
{
    public class DescriptionEnumAttribute : Attribute
    {
        public string Description { get; private set; }

        public DescriptionEnumAttribute(string description)
        {
            this.Description = description;
        }
    }
}