using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using PremierProjet.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTests.Controllers
{

    public class ControllerShould
    {
        [Fact]
        public void IndexHomeShowText()
        {
            var controller = new HomeController();//creer le controller
            var result = controller.Index(1);//Appeler la methode d<action a tester
            var viewResult = Assert.IsType<ViewResult>(result);//Verifier le type du resultat
        }
    }
}
