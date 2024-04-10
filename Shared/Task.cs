namespace EMPTodoListFntnd.Shared
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public String Image { get; set; }
        public int StateId { get; set; }
        public int CategoryId { get; set; }
        public int ListId { get; set; }
        public DateTime EndDate{ get; set; } = DateTime.Now;
        public DateTime DateRegistered { get; set; }
    }
}