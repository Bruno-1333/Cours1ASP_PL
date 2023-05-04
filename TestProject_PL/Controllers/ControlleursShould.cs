using Microsoft.AspNetCore.Mvc;
using PremierProjet.Controllers;
using PremierProjet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_PL.Controllers
{
    public class ControlleursShould
    {
        [Fact]
        public void WelcomeDefaultShowTest()
        {
            var welcomeController = new WelcomeController();
            var resultat = welcomeController.WelcomeDefault();
            var textResultat = Assert.IsType<ContentResult>(resultat);
            
        }

        [Fact]
        public void WelcomeNameShowTest()
        {
            var welcomeController = new WelcomeController();
            var resultat = welcomeController.WelcomeName("Pouliot","Jean");
            var textResultat = Assert.IsType<ViewResult>(resultat);
            Assert.Equal("Welcome", textResultat.ViewName);
        }
        [Fact]
        public void BienvenuShowTest()
        {
            var welcomeController = new WelcomeController();
            var resultat = welcomeController.Bienvenu();
            var textResultat = Assert.IsType<string>(resultat);
            Assert.Equal("<h2>Bienvenu dans mon site web</h2>", textResultat);
        }
        [Fact]
        public void ContentResultShowTest()
        {
            var welcomeController = new WelcomeController();
            var resultat = welcomeController.ContentResult();
            var textResultat = Assert.IsType<ContentResult>(resultat);
            Assert.Equal("<h2>Bienvenu dans mon site web</h2>", textResultat.Content);
        }
        [Fact]
        public void AboutShowTest()
        {
            var welcomeController = new WelcomeController();
            var resultat = welcomeController.About();
            var textResultat = Assert.IsType<ViewResult>(resultat);
            
        }
        [Fact]
        public void PDFShowTest()
        {
            var welcomeController = new WelcomeController();
            var resultat = welcomeController.PDF();
            var textResultat = Assert.IsType<VirtualFileResult>(resultat);
            
        }
        [Fact]
        public void GenererListeClientsShowTestJson()
        {
            var welcomeController = new WelcomeController();
            var resultat = welcomeController.GenererListeClients();
            Assert.IsType<JsonResult>(resultat);
            dynamic valueJson = resultat.Value;


            Client expectedClient1 = new Client(1, "Pouliot", "Paul", "JP@courriel.com");
            Client expectedClient2 = new Client(2, "Girard ", "Jean", "GJ@courriel.com");

            var jsonElement1 = valueJson[0];
            var jsonElement2 = valueJson[1];

            Assert.IsType<Client>(jsonElement1);
            Assert.IsType<Client>(jsonElement2);

            Assert.Equal<int>(jsonElement1.Numero, expectedClient1.Numero);
            Assert.Equal(jsonElement1.Nom, expectedClient1.Nom);
            Assert.Equal(jsonElement1.Prenom, expectedClient1.Prenom);
            Assert.Equal(jsonElement1.Courriel, expectedClient1.Courriel);

            Assert.Equal<int>(expectedClient2.Numero, jsonElement2.Numero);
            Assert.Equal(expectedClient2.Nom, jsonElement2.Nom);
            Assert.Equal(expectedClient2.Prenom, jsonElement2.Prenom);
            Assert.Equal(expectedClient2.Courriel, jsonElement2.Courriel);

        }
      
    }
}
