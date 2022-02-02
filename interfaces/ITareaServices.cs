using appTareas.Models;
using System.Linq;
using System.Threading.Tasks;

namespace appTareas.interfaces
{
    public interface ITareaServices
    {
        IQueryable<Tarea> getAll();

        void Create(Tarea tarea);
    }
}
