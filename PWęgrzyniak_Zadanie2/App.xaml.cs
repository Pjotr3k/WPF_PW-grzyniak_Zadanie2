using PWęgrzyniak_Zadanie2.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PWęgrzyniak_Zadanie2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        [STAThread]
        public static void Main()
        {
            var application = new App();

            AppDbContext context = new AppDbContext();
            //context.Database.EnsureCreated();

            Seed seed = new Seed(context);


            seed.ExecuteSeed();

            application.InitializeComponent();
            application.Run();
        }
    }
}
