using aspnetcore_playground.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnetcore_playground.Repositories
{
    public class PieRepository : IPieRepository
    {
        private readonly BakeryDbContext _db;

        public PieRepository(BakeryDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _db.Pies.Include(x => x.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _db.Pies.Include(x => x.Category).Where(x => x.IsPieOfTheWeek);
            }
        }

        public Pie? GetPieById(int pieId)
        {
            return _db.Pies.FirstOrDefault(x => x.PieId == pieId);
        }

        public IEnumerable<Pie> SearchPies(string searchQuery)
        {
            throw new NotImplementedException();
        }
    }
}
