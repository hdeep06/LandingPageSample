using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SampleDAL;
using Microsoft.AspNetCore.Cors;

namespace SignupApi
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();                                                                                         //Enable Cross-Origin Resource Sharing
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddDbContext<SampleDbContext>();
            services.AddSwaggerDocument();                                                                              //To view the API controller and its operation in browser, url/swagger
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseCors(options => options.WithOrigins("http://localhost:59693").AllowAnyMethod().AllowAnyHeader());    //Allow CORS for the specified client only
            app.UseMvc();
            app.UseOpenApi();
            app.UseSwaggerUi3();
        }
    }
}
