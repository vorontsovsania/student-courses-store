using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Tests.Common
{
	public class DbRepositoryTestBase<TDbContext, TRepository> where TDbContext : DbContext
	{
		protected TDbContext _dbContext;
		protected TRepository _repository;

		protected virtual TDbContext CreateDbContext()
		{
			var configuration = ConfigurationHelper.GetConfiguration();
			var builder = new DbContextOptionsBuilder<TDbContext>();
			//todo how to get rid of strict "StudentCourseStoreDb" definition
			builder.UseSqlServer(configuration.GetConnectionString("StudentCourseStoreDb"));
			_dbContext = (TDbContext)Activator.CreateInstance(typeof(TDbContext), builder.Options);
			return _dbContext;
		}

		protected virtual TRepository CreateRepository()
		{
			if (_dbContext == null)
			{
				_dbContext = CreateDbContext();
			}
			_repository = (TRepository)Activator.CreateInstance(typeof(TRepository), _dbContext);
			return _repository;
		}

		protected virtual void DisposeDbContext()
		{
			_dbContext?.Dispose();
		}
	}
}
