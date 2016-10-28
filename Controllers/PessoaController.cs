using _0001_DemonstracaoMVC.Filters;
using _0001_DemonstracaoMVC.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace _0001_DemonstracaoMVC.Controllers
{
    public class PessoaController : Controller
    {
        //
        // GET: /Pessoa/
        private Repository rp = new Repository();
      
        public ActionResult Index()
        {
            ////provisorio
            //var pessoa = rp.GetByName("Osmar Jr");
            //var pessoa2 = rp.GetByName2("Osmar");


            var model = rp.GetAll();

            return View(model);
        }

        public ActionResult DetailsByName(string nome) {
            var model = rp.GetByName(nome);
            return View("Details", model);
        }

        public ActionResult DetailsByNameAndEmail(string nome, string email)
        {
            var model = rp.GetByName(nome);
            return View("Details", model);
        }

        //[Authorize]
        //[OutputCache(Duration=60)]
        //[Logger]
        public ActionResult Details(int id)
        {
            //System.Threading.Thread.Sleep(10000);
            ViewBag.DataHoraAtual = string.Format("A Data de Hoje é {0} e a hora agora é {1}", DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString());

            ViewBag.nomes = new string[] { "OJ", "13", "Rocky" };

            ViewBag.cidades = new Dictionary<int, string>
            {
            {1 , "São Paulo"},
            {2 , "Embu"},
            {3 , "Taboão da Serra"},
            {4 , "Itapecirica da Serra"},
            {5 , "Osasco"}
            };

            var model = rp.Get(id);

            return View("Details2",model);
        }

        public ActionResult Create()
        {
            return View("Create2");
        }
        
        [HttpPost]
        public ActionResult Create(Pessoa pessoa)
        {
           
            if (ModelState.IsValid)
            {
                try
                {
                    rp.Create(pessoa);
                    return RedirectToAction("Index");
                }
                catch (System.Exception)
                {

                    throw;
                }
            }
            return View(pessoa);
        }

        public ActionResult Edit(int id)
        {
            var model = rp.Get(id);
            return View("Edit2",model);
        }

        [HttpPost]
        public ActionResult Edit(Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    rp.Edit(pessoa); 
                    return RedirectToAction("Index");
                }
                catch (Exception)
                {                    
                    throw;
                }
                   
            }            

            return View();
        }

        public ActionResult Delete(int id) {
            var model = rp.Get(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Pessoa pessoa) {
            rp.Delete(pessoa.Id);

            return RedirectToAction("Index");
        }

        public string Mensagem()
        {
            return "Teste mensagem pela Action";
        }

        public PartialViewResult Quadrado()
        {
            return PartialView();
        }
    }
}
