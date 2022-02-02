using appTareas.Context;
using appTareas.interfaces;
using appTareas.Models;
using System.Linq;
using System.Threading.Tasks;

namespace appTareas.services
{
    public class TareaServices : ITareaServices
    {
        public readonly DatabaseContext _dbContext;

        public TareaServices(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Tarea tarea)
        {
            _dbContext.AddRange(tarea);
            _dbContext.SaveChanges();
        }

        public IQueryable<Tarea> getAll()
        {
            return _dbContext.Tareas.AsQueryable();
        }
    }
}
