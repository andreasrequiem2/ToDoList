
using ToDoList.Models;

namespace CURDWithDapperCore6MVC_Demo.Repositories
{
    public interface IToDoRepository
    {
        IEnumerable<DoThing> GetЕThings();
        void CreateThing(DoThing thing);
        void DeleteThing(int Id);
    }
}
