using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Repositories;
using DataAccessLayer.Abstract;




var builder = WebApplication.CreateBuilder(args);
var MyAllowReactOrigins = "myAllowReactOrigins";




// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IUserService, UserManager>();
builder.Services.AddSingleton<IUserDal, UserRepository>();
/*builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowReactOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:3000");
                      });
   
});*/
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
    builder =>
    {
        builder.WithOrigins("http://localhost:3000")
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowCredentials();
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();









