using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeaShop.Models
{
    public class TeaRepository : ITeaRepository
    {
        private readonly AppDbContext _appDbContext;

        public TeaRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Tea> Teas {
            get
            {
                var teas = _appDbContext.Teas.Include(c => c.Category);
                var teasWithCategory = teas.Include("Category").ToList();
                foreach (Tea t in teas)
                {
                    var cat = _appDbContext.Categories.FirstOrDefault(c => c.CategoryId == t.CategoryId);
                    t.Category = cat;
                }
                return teasWithCategory;
             }
        }

        public IEnumerable<Tea> TeasOfTheWeek
        {
            get
            {
                return _appDbContext.Teas.Include(c => c.Category).Where(p => p.IsTeaOfTheWeek==true);
            }
        }


        public Tea GetTeaById(int teaId)
        {
            return _appDbContext.Teas.FirstOrDefault(t => t.TeaId == teaId);
        }
    }
}
