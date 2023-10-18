using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Sistema_de_Cadastro_de_Fornecedor.Models;
using Sistema_de_Cadastro_de_Fornecedor.Context;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Sistema_de_Cadastro_de_Fornecedor.Controllers
{
    public class FornecedoresController : Controller
    {

        readonly private FornecedoresDdContext db;

        public FornecedoresController(FornecedoresDdContext _db)
        {
            db = _db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable < FornecedoresModel > fornecedores = db.Fornecedores;

            return View(fornecedores);
        }

        [HttpGet]
        public IActionResult Cadastrar() {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(FornecedoresModel fornecedor)
        {
            if (ModelState.IsValid)
            {
                db.Fornecedores.Add(fornecedor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Por favor, corrija os erros abaixo.");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Editar(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            FornecedoresModel fornecedor = db.Fornecedores.FirstOrDefault(x => x.Id == id);

            if (fornecedor == null)
            {
                return NotFound();
            }

            return View(fornecedor);
        }

        [HttpPost]
        public IActionResult Editar(FornecedoresModel fornecedor)
        {
            if(fornecedor == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                db.Fornecedores.Update(fornecedor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Por favor, corrija os erros abaixo.");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            FornecedoresModel fornecedor = db.Fornecedores.FirstOrDefault(x => x.Id == id);

            if (fornecedor == null)
            {
                return NotFound();
            }

            return View(fornecedor);
        }

        [HttpPost]
        public IActionResult Excluir(FornecedoresModel fornecedor)
        {
            if (fornecedor == null)
            {
                return NotFound();
            }
            db.Fornecedores.Remove(fornecedor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
