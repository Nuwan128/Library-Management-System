using DataAccessLibrary.DataAccess;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace LibraryManagement.Desktop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new HostBuilder()
                .ConfigureAppConfiguration((config) =>
                {
                    config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                    config.AddUserSecrets(typeof(Program).Assembly);
                    
                    
                })
                .ConfigureServices((hostContext, services) =>
                {

                    var dbChoice = hostContext.Configuration.GetValue<string>("DbChoice");

                  
                    if (dbChoice == "MongoDb")
                    {
                        services.AddTransient<IMongoDBData, MongoDBDataAccess>();

                    }
                    else if (dbChoice == "MongoDbAtlas")
                    {
                        services.AddTransient<IMongoDBData, MongoDBDataAccess>();
                    }
                    else
                    {
                        services.AddTransient<IMongoDBData, MongoDBDataAccess>();
                    }

                    services.AddTransient<Splash>();
                    services.AddTransient<LogIn>();
                    services.AddTransient<Staff>();
                    services.AddTransient<Reader>();
                    services.AddTransient<VerifyUser>(); 
                    services.AddTransient<AddOrUpdateAuthor>();


                });

            var host = builder.Build();

            using var scope = host.Services.CreateScope();

            var services = scope.ServiceProvider;


            try
            {

                ApplicationConfiguration.Initialize();
                var frm = services.GetRequiredService<Splash>();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex}");
            }
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            
           
        }
    }
}