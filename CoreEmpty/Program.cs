var builder = WebApplication.CreateBuilder(args);
//Add Mvc
builder.Services.AddControllersWithViews();
var app = builder.Build();

//Http => Https
app.UseHttpsRedirection();

//This middleware allows the application to serve static files (e.g. CSS, JavaScript, images).
//This allows the browser to send static files directly.
app.UseStaticFiles();

//This middleware allows the application to map URLs to specific routes.
//That is, it determines which URL will be directed to which controller and action.
app.UseRouting();


//This middleware performs authorization operations for the application.
//It controls the permission of users to access certain pages or operations.
app.UseAuthorization();


/*
 app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
 */
app.MapGet("/", () => "Hello World!");

app.Run();

/*
    Controller: MVC (Model-View-Controller) mimarisinde, gelen kullanýcý isteklerini iþleyen ve 
    uygun model veya view ile etkileþime giren bir sýnýftýr. Controller, uygulamanýn 
    "iþ mantýðýný" yönetir.

    Action: Controller içinde tanýmlanan, belirli bir isteði iþleyen ve sonuç döndüren 
    yöntemdir (method). Örneðin, bir sayfanýn yüklenmesi veya bir formun iþlenmesi için 
    action kullanýlýr.

    Model: Uygulamanýn verilerini ve iþ mantýðýný temsil eden sýnýflardýr. Model, veritabaný 
    gibi dýþ kaynaklardan veri alabilir, bu verileri iþleyebilir ve controller'a geri döndürebilir.

    View: Kullanýcýya gösterilecek olan UI (Kullanýcý Arayüzü) öðelerini içeren dosyadýr. View, 
    genellikle HTML, CSS ve Razor gibi dillerle oluþturulur ve kullanýcýya sunulacak veriyi 
    þekillendirir.

    Razor: ASP.NET Core'da kullanýlan bir view engine'dir. Razor, HTML ile C# kodlarýný bir arada 
    kullanmayý saðlar. Bu sayede view içinde dinamik içerikler oluþturulabilir.

    RazorView: Razor tarafýndan iþlenmiþ ve kullanýcýya sunulacak hale gelmiþ view'dir. RazorView, 
    HTML sayfalarýný oluþturmak için Razor syntax'ýný kullanýr.

    wwwroot: ASP.NET Core uygulamalarýnda statik dosyalarýn (CSS, JavaScript, resimler vb.) 
    bulunduðu klasördür. Bu klasörde yer alan dosyalar doðrudan kullanýcýya sunulabilir.

    builder.Build(): Uygulamanýn HTTP pipeline'ýný (istek iþleme hattýný) ve diðer gerekli 
    yapýlandýrmalarý oluþturur. `builder` nesnesi, uygulama yapýlandýrmalarýný toplar ve 
    `Build()` çaðrýldýðýnda, bu yapýlandýrmalar uygulanarak uygulama çalýþmaya hazýr hale gelir.

    app.Run(): Uygulamanýn çalýþmasýný baþlatan metottur. HTTP pipeline'daki middleware 
    bileþenlerini çalýþtýrarak gelen istekleri iþlemeye baþlar. Bu metot çaðrýldýðýnda, 
    uygulama artýk gelen HTTP isteklerini dinlemeye ve yanýt vermeye hazýrdýr.
*/