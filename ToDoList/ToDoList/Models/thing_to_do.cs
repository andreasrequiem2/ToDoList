namespace ToDoList.Models
{
    public class DoThing
    {
        public int Id { get; set; }
        public int IdCategory { get; set; }
        public string? Thing { get; set; }  
        public System.DateTime? Due { get; set; }
        public bool IsDone { get; set; }

    }
}
