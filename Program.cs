
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Middleware to serve default files like index.html
app.UseDefaultFiles();

// Middleware to serve static files (CSS, JS, images, HTML)
app.UseStaticFiles();

app.Run();

