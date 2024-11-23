using aspnetcore_playground.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore_playground.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(ICategoryRepository categoryRepository, IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            return View(_pieRepository.AllPies);
        }
    }
}
