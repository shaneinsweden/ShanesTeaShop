using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeaShop.Models;
using TeaShop.ViewModels;

namespace TeaShop.Controllers
{
    [Route("api/[controller]")]
    public class TeaApiController: Controller
    {
        private readonly ITeaRepository _teaRepository;

        public TeaApiController(ITeaRepository teaRepository)
        {
            _teaRepository = teaRepository;
        }

        [HttpGet]
        public IEnumerable<TeaViewModel> LoadMoreTeas()
        {
            IEnumerable<Tea> dbTeas = null;

            dbTeas = _teaRepository.Teas.OrderBy(p => p.TeaId).Take(10);

            List<TeaViewModel> teas = new List<TeaViewModel>();

            foreach (var dbTea in dbTeas)
            {
               teas.Add(MapDbTeaToTeaViewModel(dbTea));
            }
            return teas;
        }

        private TeaViewModel MapDbTeaToTeaViewModel(Tea dbTea)
        {
            return new TeaViewModel()
            {
                TeaId = dbTea.TeaId,
                Name = dbTea.Name,
                Price = dbTea.Price,
                ShortDescription = dbTea.ShortDescription,
                ImageThumbnailUrl = dbTea.ImageThumbnailUrl
            };
        }
    }
}
