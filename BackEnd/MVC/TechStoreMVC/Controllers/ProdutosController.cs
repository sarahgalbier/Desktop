using Microsoft.AspNetCore.Mvc;

namespace TechStoreMVC.Controllers
{
    public class ProdutosController : Controller // o ":" significa Herança
    // Herança = herdas as caracteristicas de um Controller. :)
    {
        // GET: ProdutosController
        // Passo 02 - criar a açao
        // uma view depende de uma açao e vice-vers

        public ActionResult Index()
        {
            return View();
        }

    }
}
