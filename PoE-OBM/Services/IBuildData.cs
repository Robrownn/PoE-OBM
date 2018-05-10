using System.Linq;
using PoE_OBM.Models;

namespace PoE_OBM.Services
{
    public interface IBuildData
    {
        IQueryable<ExileBuild> GetAll();
        ExileBuild Get(int id);
        ExileBuild Add(ExileBuild newBuild);
        ExileBuild Update(ExileBuild build);
    }
}