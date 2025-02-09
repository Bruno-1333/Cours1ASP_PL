﻿using Microsoft.AspNetCore.Mvc;
using PremierProjet.Models;
using System;
using System.Globalization;
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
        public JsonResult GenererListeClients()
        {
            //create a list of clients with 5 mock clients

            Client client1 = new Client(1, "Pouliot", "Paul", "JP@courriel.com");
            Client client2 = new Client(2, "Girard ", "Jean", "GJ@courriel.com");
            

            List<Client> listeClients = new List<Client>();
            listeClients.Add(client1);
            listeClients.Add(client2);
            

            //serialize in json
            var options = new JsonSerializerOptions { WriteIndented = true };
            JsonResult listeClientsJson = Json(listeClients, options);
            return listeClientsJson;
           // string json = JsonSerializer.Serialize(clients);
           // return Json(json, "application/json");
        }
       
    }
}
