using System.Reflection;
using Application.Extentions;
using Infrastructure.Extentions;
using Microsoft.Extensions.DependencyInjection;

namespace Config_API_S
{
    public class Startup
    {
        public IConfiguration Configuration { get; }


        //To retrieve the Configuration settings 
        public Startup(IConfiguration configuration)
        {
            //to inject configuration into the class
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            //registers a single instance of the service for the entire lifetime of the application
            services.AddSingleton(Configuration);
            services.AddAutoMapper(typeof(Program));
            services.AddControllers();
            //dds Swagger generation services
            services.AddSwaggerGen();

            services.AddMvc();

            //services.AddMediatR(Assembly.GetExecutingAssembly());
            //services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
            //services.AddMediatR(typeof(MyHandler));
          
            //services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
           // services.AddMediatR(typeof(MyHandler));
            //infrastrucure interface injection 
           // services.AddInfrastructureConfiguration();
            //Application interfaces injections : 
            //services.AddApplicationConfiguration();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //it enables the developer exception page and configures Swagger.
            if (env.IsDevelopment())//if it runs
            {
                app.UseDeveloperExceptionPage();

            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();//it maps controllers to handle incoming requests.
            });

            app.UseSwagger();
            app.UseSwaggerUI();//for exploring the API documentation
        }
    }
}
