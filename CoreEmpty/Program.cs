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
    Controller: MVC (Model-View-Controller) mimarisinde, gelen kullan�c� isteklerini i�leyen ve 
    uygun model veya view ile etkile�ime giren bir s�n�ft�r. Controller, uygulaman�n 
    "i� mant���n�" y�netir.

    Action: Controller i�inde tan�mlanan, belirli bir iste�i i�leyen ve sonu� d�nd�ren 
    y�ntemdir (method). �rne�in, bir sayfan�n y�klenmesi veya bir formun i�lenmesi i�in 
    action kullan�l�r.

    Model: Uygulaman�n verilerini ve i� mant���n� temsil eden s�n�flard�r. Model, veritaban� 
    gibi d�� kaynaklardan veri alabilir, bu verileri i�leyebilir ve controller'a geri d�nd�rebilir.

    View: Kullan�c�ya g�sterilecek olan UI (Kullan�c� Aray�z�) ��elerini i�eren dosyad�r. View, 
    genellikle HTML, CSS ve Razor gibi dillerle olu�turulur ve kullan�c�ya sunulacak veriyi 
    �ekillendirir.

    Razor: ASP.NET Core'da kullan�lan bir view engine'dir. Razor, HTML ile C# kodlar�n� bir arada 
    kullanmay� sa�lar. Bu sayede view i�inde dinamik i�erikler olu�turulabilir.

    RazorView: Razor taraf�ndan i�lenmi� ve kullan�c�ya sunulacak hale gelmi� view'dir. RazorView, 
    HTML sayfalar�n� olu�turmak i�in Razor syntax'�n� kullan�r.

    wwwroot: ASP.NET Core uygulamalar�nda statik dosyalar�n (CSS, JavaScript, resimler vb.) 
    bulundu�u klas�rd�r. Bu klas�rde yer alan dosyalar do�rudan kullan�c�ya sunulabilir.

    builder.Build(): Uygulaman�n HTTP pipeline'�n� (istek i�leme hatt�n�) ve di�er gerekli 
    yap�land�rmalar� olu�turur. `builder` nesnesi, uygulama yap�land�rmalar�n� toplar ve 
    `Build()` �a�r�ld���nda, bu yap�land�rmalar uygulanarak uygulama �al��maya haz�r hale gelir.

    app.Run(): Uygulaman�n �al��mas�n� ba�latan metottur. HTTP pipeline'daki middleware 
    bile�enlerini �al��t�rarak gelen istekleri i�lemeye ba�lar. Bu metot �a�r�ld���nda, 
    uygulama art�k gelen HTTP isteklerini dinlemeye ve yan�t vermeye haz�rd�r.
*/