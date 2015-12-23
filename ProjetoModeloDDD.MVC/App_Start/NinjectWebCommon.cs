using TurismoDDD.Application;
using TurismoDDD.Application.Interface;
using TurismoDDD.Domain.Interfaces.Repositories;
using TurismoDDD.Domain.Interfaces.Services;
using TurismoDDD.Domain.Services;
using TurismoDDD.Infra.Data.Repositories;


[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(TurismoDDD.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(TurismoDDD.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace TurismoDDD.MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<IPessoaAppService>().To<PessoaAppService>();
            kernel.Bind<IEstabelecimentoAppService>().To<EstabelecimentoAppService>();
            kernel.Bind<ITipoPessoaAppService>().To<TipoPessoaAppService>();

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<IPessoaService>().To<PessoaService>();
            kernel.Bind<IEstabelecimentoService>().To<EstabelecimentoService>();
            kernel.Bind<ITipoPessoaService>().To<TipoPessoaService>();


            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<IPessoaRepository>().To<PessoaRepository>();
            kernel.Bind<IEstabelecimentoRepository>().To<EstabelecimentoRepository>();
            kernel.Bind<ITipoPessoaRepository>().To<TipoPessoaRepository>();
        }        
    }
}
