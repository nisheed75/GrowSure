using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowSure.Client.Common.Models
{
    public class Inventory
    {
        public Guid Id { get; private set; }
        public string InventorySku { get; set; }
    }
}
