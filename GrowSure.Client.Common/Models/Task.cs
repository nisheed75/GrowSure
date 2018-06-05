using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace GrowSure.Client.Common.Models
{
    public class Task
    {
        [JsonProperty]
        public Guid Id { get;  set; }
        [JsonProperty]
        public TaskType Type { get;  set; }
        [JsonProperty] public string TaskName { get; set; }
        public TeamMember Assignee { get; set; }
        [JsonProperty]
        public DateTime CreateDate { get;  set; }
        [JsonProperty]
        public DateTime DueOn { get; private set; }
        [JsonProperty]
        public string AssigneeStatus { get; set; }
        [JsonProperty]
        public bool Completed { get;  set; }
        [JsonProperty]
        public DateTime CompletedDate { get;  set; }
        [JsonProperty]
        public List<TaskTag> Tags { get;  set; }
        [JsonProperty]
        public string Location { get;  set; }
        [JsonProperty]
        public string QuantityUnit { get; set; }
        [JsonProperty]
        public int Quantity { get; set; }


        public Task(TaskType type, string taskName, TeamMember assignee, DateTime dueOn, List<TaskTag> tags, string location, string  qtyUnit, int qty)
        {
            Id = Guid.NewGuid();
            CreateDate = DateTime.UtcNow;
            Type = type;
            TaskName = taskName;
            Assignee = assignee;
            DueOn = dueOn;
            Tags = tags;
            Location = location;
            AssigneeStatus = "NotAccepted";
            Completed = false;
            QuantityUnit = qtyUnit;
            Quantity = qty;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.None);
        }
    }
}
