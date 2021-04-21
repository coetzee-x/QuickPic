using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace QuickPic.Web.Controllers
{
    public class ResultController : Controller
    {
        private readonly IResultRepository _resultRepository;

        public ResultController(IResultRepository resultRepository)
        {
            _resultRepository = resultRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            _resultRepository.Get();

            return View();
        }
    }
}
