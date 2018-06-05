using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowSure.Client.Common.Models
{
    public class TaskType
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public TaskType(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
