using ToDoList.Models;

namespace ToDoList.ViewModel
{
    public class ThingsViewModel
    {
        public IEnumerable<DoThing> Things { get; set; }
        public IEnumerable<category> Categories { get; set; }
    }

    public class CreateThingViewModel
    {
        public string Thing { get; set; }
        public DateTime Due { get; set; }
        public bool IsDone { get; set; }
        public int IdCategory { get; set; }
    }


    public class DeleteThingViewModel
    {
        public int Id { get; set; }
    }
}
