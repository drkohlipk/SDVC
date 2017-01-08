using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using sdvcWebapp.Factory;
using React.AspNet;
using sdvcWebapp.Repository;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MySQL.Data.EntityFrameworkCore.Extensions;
using sdvcWebapp.Infrastructure;

namespace sdvcWebapp
{
    public class Startup
    {
        public IConfiguration Configuration { get; private set; }
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(env.ContentRootPath)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddEnvironmentVariables();
            Configuration = builder.Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<IKeywordRepository,KeywordRepository>();
            services.AddReact();
            services.AddMvc();
            services.AddSession();
            // services.AddScoped<UserFactory>();
            services.Configure<MySqlOptions>(Configuration.GetSection("DBInfo"));
            string connection = Configuration.GetConnectionString("sdvcWebapp");
services.AddDbContext<SDVCContext>(options => options.UseMySQL(connection));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();
            app.UseDeveloperExceptionPage();
            app.UseReact(config =>
            {
            // If you want to use server-side rendering of React components,
            // add all the necessary JavaScript files here. This includes
            // your components as well as all of their dependencies.
            // See http://reactjs.net/ for more information. Example:
            // config
            //  .AddScript("~/Scripts/app.jsx");
            //  .AddScript("~/Scripts/Second.jsx");

            // If you use an external build too (for example, Babel, Webpack,
            // Browserify or Gulp), you can improve performance by disabling
            // ReactJS.NET's version of Babel and loading the pre-transpiled
            // scripts. Example:
            config
             .SetLoadBabel(false);
            //  .AddScriptWithoutTransform("~/js/tutorial.js");
            });
            app.UseStaticFiles();
            app.UseSession();
            app.UseMvcWithDefaultRoute();
        }
    }
}
