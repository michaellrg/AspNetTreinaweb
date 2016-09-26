using Gama.TesteASPNETMVC.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gama.TesteASPNETMVC.WEB.Controllers
{
    public class TesteController : Controller
    {
        // GET: Teste
        public ActionResult Index()
        {
            return View();
        }
        //Valida o token transmitido
        [ValidateAntiForgeryToken]
        //Referencia o tipo de retorno (Get ou Post)
        [HttpPost]
        //ActionResult retorna uma view
        
            /*Bind permite o Include e exclude. 
             * Exclude para que não seja possível o ataque de parâmetros mesmo que forçados por hackers*/
        public ActionResult Index([Bind(Exclude ="Ativo")]Pessoa pessoa) {
            /*ModelState é utilizado para caso não haja um javascript e mesmo assim seja validado os campos*/
            if (ModelState.IsValid)
            {
                
                pessoa.Ativo = true;
                //Retornando a View Saudação com o objeto pessoa
                return View("Saudacao", pessoa);

            }
            else {
                //Retornando a View Index com o objeto pessoa e os erros
                return View(pessoa);
            }
        }

        
    }
}