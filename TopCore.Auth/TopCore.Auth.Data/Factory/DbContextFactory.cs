﻿#region	License

//------------------------------------------------------------------------------------------------
// <Auto-generated>
//     <Author> Top Nguyen (http://topnguyen.net) </Author>
//     <Project> TopCore.Auth.Data </Project>
//     <File> 
//         <Name> DbContextFactory.cs </Name>
//         <Created> 28 03 2017 05:50:31 PM </Created>
//         <Key> 0679F181-B40B-49BF-A6A6-1AFA54A83376 </Key>
//     </File>
//     <Summary>
//         DbContextFactory
//     </Summary>
// </Auto-generated>
//------------------------------------------------------------------------------------------------

#endregion License

using System.Reflection;
using IdentityServer4.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using TopCore.Framework.Core;

namespace TopCore.Auth.Data.Factory
{
    public class DbContextFactory : IDbContextFactory<DbContext>
    {
        public DbContext Create(DbContextFactoryOptions options)
        {
            var connectionString = GetConnectionString(options);
            return CreateCoreContext(connectionString);
        }

        /// <summary>
        /// Get connection from DbContextFactoryOptions Environment
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private string GetConnectionString(DbContextFactoryOptions options)
        {
            IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json", false, true).Build();
            var connectionString = config.GetSection($"ConnectionStrings:{options.EnvironmentName}").Value;
            return connectionString;
        }

        private static DbContext CreateCoreContext(string connectionString)
        {
            var builder = new DbContextOptionsBuilder<DbContext>();
            builder.UseSqlServer(connectionString, optionsBuilder => optionsBuilder.MigrationsAssembly(typeof(IDataModule).GetTypeInfo().Assembly.GetName().Name));
            return new DbContext(builder.Options, new ConfigurationStoreOptions { DefaultSchema = "dbo" }, new OperationalStoreOptions { DefaultSchema = "dbo" });
        }
    }
}