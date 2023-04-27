using Microsoft.AspNetCore.Mvc;
using PremierProjet.Models;
using System;
using System.Text.Json;

namespace PremierProjet.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult WelcomeDefault()
        {
            return Content("Bienvenu dans ma nouvelle application!");
        }
        public IActionResult WelcomeName(string nom,string prenom)
        {
            //return Content(@$"Salut {prenom} {nom} ! Bienvenu dans ma nouvelle application");
            if(nom == null || prenom == null)
            {
                return View("Erreur");
            }
            ViewData["nom"] = nom;
            ViewData["prenom"] = prenom;
            return View("Welcome");
        }
        public string Bienvenu()
        {
            return "<h2>Bienvenu dans mon site web</h2>";
        }

        
        public ContentResult ContentResult()
        {
            return Content("<h2>Bienvenu dans mon site web</h2>", "text/html");
        }

        //3.	Créez une méthode d’action qui renvoi la méthode View(). Cela ne devrait pas fonctionner, lisez bien l’erreur et dites ce qui manque. Corriger le problème.
        public ActionResult About()
        {
            return View();
        }
        //4.	Créez une méthode d’action qui retourne un fichier pdf.
        public ActionResult PDF()
        {
            //return pdf from wwwroot folder of the project
            return File("~/cheatsheet-a5.pdf", "application/pdf");
            
        }
        public ActionResult GenererListeClients()
        {
            //create a list of clients with 5 mock clients

            Client client1 = new Client(1, "Pouliot", "Paul", "JP@courriel.com");
            Client client2 = new Client(2, "Girard ", "Jean", "GJ@courriel.com");
            Client client3 = new Client(3, "Tremblay", "Marie", "MT@courriel.com");
            Client client4 = new Client(4, "Lavoie", "Pierre ", "PL@courriel.com");

            List<Client> clients = new List<Client>();
            clients.Add(client1);
            clients.Add(client2);
            clients.Add(client3);
            clients.Add(client4);

            //serialize in json
            string json = JsonSerializer.Serialize(clients);
            return Content(json, "application/json");
        }
       
    }
}
