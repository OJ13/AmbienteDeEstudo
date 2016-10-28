using _0002_RotasMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _0002_RotasMVC.Controllers
{
    public class ProdutoController : Controller
    {
        //
        // GET: /Produto/

        public ActionResult Index()
        {
            return View(GetAll());
        }
        public ActionResult Details(int id)
        {
            var model = Get(id);

            if (model == null)
            {
                return HttpNotFound();
            }

            return View(model);
        }

        public ActionResult Filtro(string cor, string categoria)
        {
            var model = Filter(cor, categoria);

            if (model.Count() == 0)
            {
                return HttpNotFound();
            }
            return View("Index", model);
        }

        #region Produtos
        private IEnumerable<Produto> Filter(string cor, string categoria)
        {
            return GetAll().Where(x => x.Categoria.Equals(categoria, StringComparison.InvariantCultureIgnoreCase) && 
                                    x.Cor.Equals(cor, StringComparison.InvariantCultureIgnoreCase));
        }
        private IEnumerable<Produto> GetAll(){
            yield return new Produto { Id = 1, Nome = "Sabonete",QtdEstoque = 100, Cor = "Azul", Categoria = "Higiene" ,Valor = 2.50};
            yield return new Produto { Id = 2, Nome = "Shampoo", QtdEstoque = 500, Cor = "Varmelho", Categoria = "Higiene", Valor = 12.50 };
            yield return new Produto { Id = 3, Nome = "Caneta", QtdEstoque = 20, Cor = "Preta", Categoria = "Escritorio", Valor = 8.75 };
        }
        private Produto Get(int id)
        {
            return GetAll().FirstOrDefault(x => x.Id == id);
        }
        #endregion
    }
}
