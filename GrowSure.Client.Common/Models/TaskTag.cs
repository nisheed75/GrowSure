namespace GrowSure.Client.Common.Models
{
    public class TaskTag
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public TaskTag(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
