var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();//Relier les vues au controleurs
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//Configurer les routes: le format des urls
app.MapControllerRoute(
 name: "default",
 pattern: "{controller=Welcome}/{action=WelcomeDefault}/{id?}"
);

app.MapControllerRoute(
    //le nom de la route est default et elle est utilisée par defaut si aucune route n'est trouvée. 
 name: "default",
 //la methode d'action et les parametres
 pattern: "/{nom?}/{prenom?}",
 //defaults: indiquer le controleur et la methode d'action par defaut
 defaults: new {controller="Welcome",action="WelcomeName"}
);

app.Run();
