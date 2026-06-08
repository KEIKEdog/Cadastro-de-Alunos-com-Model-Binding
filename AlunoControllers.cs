namespace Aluno.Controllers

{
    public class AlunoController : Controller
    {
        
        [HttpGet]
        public IActionResult Cadastrar()
        {
            
            return View();
        }

        
        [HttpPost]
        public IActionResult Cadastrar(Aluno aluno)
        {
            
            if (ModelState.IsValid)
            {
                

                TempData["Mensagem"] = "Aluno cadastrado";
                return RedirectToAction("Cadastrar");
            
            }

           
            return View(aluno);
        }
    }
}