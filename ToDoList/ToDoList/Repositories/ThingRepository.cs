using Dapper;
using System.Data;
using ToDoList.DBContext;
using ToDoList.Models;

namespace ToDoList.Repositories
{
    public class ThingRepository
    {
        private readonly DapperContext context;
        public ThingRepository(DapperContext context)
        {
            this.context = context;
        }
        public IEnumerable<DoThing> GetThings()
        {
            var query = "SELECT * FROM thing_to_do";

            using (var connection = context.CreateConnection())
            {
                var Thing = connection.Query<DoThing>(query);
                return Thing.ToList();
            }
        }
        public void CreateThing(DoThing thing)
        {
            var query = "INSERT INTO thing_to_do (thing, due, is_done, id_category) VALUES (@Thing, @Due, @IsDone, @IdCategory)";

            var parameters = new DynamicParameters();
            parameters.Add("thing", thing.Thing, DbType.String);
            parameters.Add("deadline", thing.Due, DbType.DateTime);
            parameters.Add("status", thing.IsDone, DbType.Boolean);
            parameters.Add("category id", thing.IdCategory, DbType.Int32);

            using (var connection = context.CreateConnection())
            {
                connection.Execute(query, parameters);
            }
        }
        public void DeleteThing(int Id)
        {
            var query = "DELETE FROM thing_to_do WHERE Id = @Id";
            using (var connection = context.CreateConnection())
            {
                connection.Execute(query, new { Id });
            }
        }
        public IEnumerable<category> GetCategories()
        {
            var query = "SELECT * FROM category";

            using (var connection = context.CreateConnection())
            {
                var category = connection.Query<category>(query);
                return category.ToList();
            }
        }
    }
}
