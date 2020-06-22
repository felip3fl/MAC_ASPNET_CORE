using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AspnCore2Empty.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AspnCore2Empty
{
    public class Startup
    {
        public IConfiguration _config { get; set; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            _config = builder.Build();

            if (env.IsDevelopment())
            {
                //builder.AddApplicationInsightsSettings(developerMode: true);
            }
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddSingleton<IMensagemService, TextoMensagemService>();
            services.AddSingleton(provider => _config);
            services.AddSingleton<IMensagemService, ConfigurationMensagemService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IMensagemService msg)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler();
            }

            app.UseStaticFiles();

            app.Run(async (context) =>
            {
                //var mensagem = _config["Mensagem"];
                //var conexao = _config["ConnectionStrings:DefaultConnection"];
                //await context.Response.WriteAsync(mensagem);
                await context.Response.WriteAsync(msg.GetMensagem());
            });
        }
    }
}
