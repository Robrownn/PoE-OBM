using System.Linq;
using Microsoft.EntityFrameworkCore;
using PoE_OBM.Data;
using PoE_OBM.Models;

namespace PoE_OBM.Services
{
    public class SQLBuildData : IBuildData
    {
        private BuildDbContext _context;

        public SQLBuildData(BuildDbContext context)
        {
            _context = context;
        }

        public ExileBuild Add(ExileBuild newBuild)
        {
            _context.Builds.Add(newBuild);
            _context.SaveChanges();

            return newBuild;
        }

        public ExileBuild Get(int id)
        {
            return _context.Builds.FirstOrDefault(b => b.id == id);
        }

        public IQueryable<ExileBuild> GetAll()
        {
            return _context.Builds.OrderBy(r => r.Name);
        }

        public ExileBuild Update(ExileBuild build)
        {
            _context.Attach(build).State = EntityState.Modified;
            _context.SaveChanges();

            return build;
        }
    }
}