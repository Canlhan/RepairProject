using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;



namespace RepairFor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static IContainer Container;
        public static IConfiguration Configuration { get; }

        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Container = Configure();

            Application.Run(new Form1(Container.Resolve<ICustomerService>(), Container.Resolve<IProductService>()));
            //var services = new ServiceCollection();
            //new Form1(Container.Resolve<ICustomerService>(), Container.Resolve<IProductService>())
            //ConfigureServices(services);
            //using (var serviceProvider=services.BuildServiceProvider())
            //{
            //    var form1 = serviceProvider.GetRequiredService<form>();


            //}

        }

        private static void ConfigureServices(ServiceCollection services)
        {


            services.AddScoped<ICustomerService, CustomerManager>();
            services.AddScoped<ICustomerDal, EfCustomerDal>();

            services.AddScoped<IProductService,ProductManager>();
            services.AddScoped<IProductDal, EfProductDal>();
           
           
            services.AddScoped<Form1>();


        }

        static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<CustomerManager>().As<ICustomerService>();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>();

            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<EfProductDal>().As<IProductDal>();
            builder.RegisterType<Form1>();
            return builder.Build();
        }
    }
}
