using AutoMapper;
using Domain.GeradorContrato.Interface.Service;
using Domain.GeradorContrato.Mapper;
using Domain.GeradorContrato.Repository;
using Domain.GeradorContrato.Service;
using Infra.GeradorContrato.Data;
using Infra.GeradorContrato.Implemetations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.GeradorContrato
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSwaggerGen(config => {
                config.SwaggerDoc("v1", new OpenApiInfo { Title = "Gerador de Contrato", Version = "v1" });
            });

            services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
            );

            var config = new AutoMapper.MapperConfiguration(cfg => {
                cfg.AddProfile(new ModelToDTO());
            });

            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            services.AddTransient<ICamposModelosService, CamposModelosService>();
            services.AddTransient<ICamposModelosImplementation, CamposModelosImplementation>();

            services.AddTransient<IContratoGeradoService, ContratoGeradoService>();
            services.AddTransient<IContratoGeradoImplementation, ContratoGeradoImplementation>();

            services.AddTransient<IModeloContratoService, ModeloContratoService>();
            services.AddTransient<IModeloContratoImplementation, ModeloContratoImplementation>();

            services.AddTransient<IUsuarioService, UsuarioService>();
            services.AddTransient<IUsuarioImplementation, UsuarioImplementation>();

            services.AddTransient<IValoresCamposService, ValoresCamposService>();
            services.AddTransient<IValoresCamposImplementation, ValoresCamposImplementation>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger(config => {
                config.RouteTemplate = "geradorContrato/{documentName}/swagger.json";
            });

            app.UseSwaggerUI(config =>
            {
                config.SwaggerEndpoint("/geradorContrato/v1/swagger.json", "v1 docs");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
