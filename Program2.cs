var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();
//SDFDSFDSF  1111111111111111
//SDFDSFDSF  1111111111111113
//SDFDSFDSF  1111111111111114
//SDFDSFDSF  11111111111111155
//SDFDSFDSF  11111111111111155
//SDFDSFDSF  11111111111111155
//SDFDSFDSF  11111111111111155
//SDFDSFDSF  11111111111111155
//SDFDSFDSF  11111111111111155
//SDFDSFDSF  11111111111111155
//SDFDSFDSF  11111111111111155
//SDFDSFDSF  11111111111111155
//SDFDSFDSF  11111111111111155
//SDFDSFDSF  1111111111111112
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
