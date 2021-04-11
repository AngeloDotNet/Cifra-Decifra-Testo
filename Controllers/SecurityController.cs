using System;
using Microsoft.AspNetCore.Mvc;
using Template_CifraDecifra_Testo.Models.InputModels;
using Template_CifraDecifra_Testo.Models.Services.Application;

namespace Template_CifraDecifra_Testo.Controllers
{
    public class SecurityController : Controller
    {
        private readonly ISecurityServices securityServices;
        public SecurityController(ISecurityServices securityServices)
        {
            this.securityServices = securityServices;
        }

        public IActionResult Index()
        {
            var inputModel = new SecurityInputModel();

            inputModel.TestoGuid = Guid.NewGuid().ToString();
            inputModel.TestoCifrato = securityServices.CifraTesto("Ciao !");
            inputModel.TestoDecifrato = securityServices.DecifraTesto(inputModel.TestoCifrato);

            return RedirectToAction(nameof(Detail), inputModel);
        }

        public IActionResult Detail(SecurityInputModel inputModel)
        {
            return View(inputModel);
        }
    }
}