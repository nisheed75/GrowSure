using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowSure.Client.Common.Models
{
    public class UICategory
    {
        public const string TAG = "UICategory";

        public string Name { get; private set; }

        public string Id { get; private set; }

        public string Theme { get; private set; }

        public UICategory(string name, string id, string theme)
        {
            Name = name;
            Id = id;
            Theme = theme;

        }
    }
}
