using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Extensions.Configuration;
using SolutionTraining.Domain.Interfaces.v1.Connection;

namespace SolutionTraining.CrossCutting.Configuration.Sql
{
    public class SqlDataBaseConfiguration : IDataBaseConfiguration
    {
        public IConfigurationRoot Configuration { get; set; }

        public string Get()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("AppSettingsSql.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();
            string _con = Configuration["ConnectionStrings:DefaultConnection"];
            return _con;
        }
    }
}
