






var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

// Add services to the container.

builder.Services.AddTransient<IProductsServices,ProductsServicesImp>();
builder.Services.AddTransient<ICategoriesServices, CategoryServicesImp>();
//builder.Services.AddTransient<IOrdersServices, OrdersServicesImp>();
//builder.Services.AddTransient<IRolesServices, RolesServicesImp>();
builder.Services.AddTransient<IProductsServices, ProductsServicesImp>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWorkImp>();
builder.Services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepositoryImp<>));



//End of services Configurations

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(c=>c.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseAuthorization();

app.MapControllers();

app.Run();
