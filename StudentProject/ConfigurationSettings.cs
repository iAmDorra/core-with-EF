using Microsoft.Extensions.Configuration;

namespace StudentProject
{
    public class ConfigurationSettings
    {
        public static string GetConnectionString()
        {
            // Enable to app to read json setting files
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            var configuration = builder.Build();

            // Get the connection string
            string connectionString = configuration.GetConnectionString("StudentDB");
            return connectionString;
        }
    }
}
