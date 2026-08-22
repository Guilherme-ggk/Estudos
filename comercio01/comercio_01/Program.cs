
using comercio_01.Models;
using comercio_01.Repository;

namespace comercio_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<CategoriaRepository>();
            builder.Services.AddScoped<FornecedorRepository>();
            builder.Services.AddScoped<ProdutoRepository>();
            builder.Services.AddScoped<FuncionarioRepository>();
            builder.Services.AddScoped<ProdutoRepository>();
            builder.Services.AddScoped<VendaRepository>();
            builder.Services.AddScoped<Item_VendaRepository>();
            builder.Services.AddScoped<ClienteRepository>();
            

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}