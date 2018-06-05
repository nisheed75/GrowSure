using System;
using System.Collections.Generic;
using GrowSure.Client.Common.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace GrowSure.Client.Common.Test
{
    [TestClass]
    public class CreateTasksTests
    {
        [TestMethod]
        public void TestTaskJsonSerialization()
        {
            TaskType type = new TaskType(1, "Seed");
            List<TaskTag> tags = new List<TaskTag>();
            tags.Add(new TaskTag(1, "Seeding"));
            TeamMember teamMem = new TeamMember("Nisheed", "Rama", "nisheed","password", "avatar_1");
            

            Task task = new Task(type, "Seed Mint", teamMem, DateTime.UtcNow, tags, "Building 28", "Trays", 5);
            List<Task> tasks = new List<Task>();
            tasks.Add(task);
            task = new Task(type, "Seed Oregano", null, DateTime.UtcNow, tags, "Building 28", "Trays", 3);
            tasks.Add(task);
            task = new Task(type, "Seed Basil", null, DateTime.UtcNow, tags, "Building 28", "Trays", 4);
            tasks.Add(task);
            task = new Task(type, "Seed Parsley", null, DateTime.UtcNow, tags, "Building 28", "Trays", 8);
            tasks.Add(task);
            task = new Task(type, "Seed Thyme", null, DateTime.UtcNow, tags, "Building 28", "Trays", 2);
            tasks.Add(task);

            JsonConvert.SerializeObject(tasks, Formatting.Indented);

            //TODO: write test case.
        }
    }
}
