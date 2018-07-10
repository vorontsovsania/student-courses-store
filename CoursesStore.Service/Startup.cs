using CoursesStore.Data.Interfaces;
using CoursesStore.Data.SqlServer.DataContexts;
using CoursesStore.Data.SqlServer.Repositories;
using CoursesStore.Logic.Interfaces;
using CoursesStore.Logic.Managers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CoursesStore.Service
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			ConfigureRepositories(services);

			ConfigureManagers(services);

			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
			services.Configure<ApiBehaviorOptions>(options =>
				{
					options.SuppressModelStateInvalidFilter = true;
				}
			);
		}

		#region configuration of logic models, db repositories

		private void ConfigureRepositories(IServiceCollection services)
		{
			services.AddDbContext<CoursesDataContext>(options =>
				options.UseSqlServer(Configuration.GetConnectionString("CourseStoreDb")));

			services.AddTransient<IStudentRepository, StudentRepository>();
		}

		private void ConfigureManagers(IServiceCollection services)
		{
			services.AddTransient<IStudentManager, StudentManager>();
		}

		#endregion

		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			//if (env.IsDevelopment())
			//{
			//    app.UseDeveloperExceptionPage();
			//}
			//else
			//{
			//    app.UseHsts();
			//}

			//app.UseHttpsRedirection();
			app.UseCors();
			app.UseMvc();
		}
	}
}
