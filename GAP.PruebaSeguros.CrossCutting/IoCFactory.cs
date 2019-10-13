using GAP.PruebaSeguros.Data.Repositories;
using GAP.PruebaSeguros.Domain.Services.CoveringTypes;
using GAP.PruebaSeguros.Domain.Services.InsurancePolicies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;

namespace GAP.PruebaSeguros.CrossCutting
{
    public static class IoCFactory
    {
        /// <summary>
        /// Container relationships dictionary.
        /// </summary>
        private static IDictionary<string, IUnityContainer> containersDictionary;

        /// <summary>
        /// Static constructor that loads the dictionary of relationships.
        /// </summary>               
        static IoCFactory()
        {
            InitContainers();
        }

        /// <summary>
        /// Return a requested instance according to the interfaces dictionary.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Resolve<T>()
        {
            string containerName = "RealAppContext";

            if (string.IsNullOrEmpty(containerName) || string.IsNullOrWhiteSpace(containerName))
            {
                throw new ArgumentNullException("Default Container not found.");
            }

            return Resolve<T>(containerName);
        }

        /// <summary>
        /// Returns the implementation for the required interface.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="containerName"></param>
        /// <returns></returns>
        public static T Resolve<T>(string containerName)
        {
            if (string.IsNullOrEmpty(containerName) || string.IsNullOrWhiteSpace(containerName))
            {
                throw new ArgumentNullException("Default Container not found.");
            }

            if (!containersDictionary.ContainsKey(containerName))
            {
                throw new InvalidOperationException("Container Not Found");
            }

            IUnityContainer container = containersDictionary[containerName];
            return container.Resolve<T>();
        }

        /// <summary>
        /// Method that initializes the dictionary, to wire relationships.
        /// </summary>
        private static void InitContainers()
        {
            containersDictionary = new Dictionary<string, IUnityContainer>();

            // Creates the root container.
            IUnityContainer rootContainer = new UnityContainer();
            containersDictionary.Add("RootContext", rootContainer);

            // Creates a real container only if its necessary to do tests with another container.
            IUnityContainer realAppContainer = rootContainer.CreateChildContainer();
            containersDictionary.Add("RealAppContext", realAppContainer);

            ConfigureRootContainer(rootContainer);
            ConfigureRealContainer(realAppContainer);
        }

        /// <summary>
        /// Configure the root container and register the data types.
        /// </summary>
        /// <param name="container"></param>
        private static void ConfigureRootContainer(IUnityContainer container)
        {
            RegisterRepositories(container);
            RegisterServices(container);
        }

        /// <summary>
        /// Register data types related with services.
        /// </summary>
        /// <param name="container"></param>
        private static void RegisterServices(IUnityContainer container)
        {
            container.RegisterType<IInsurancePolicyServices, InsurancePolicyServices>(new TransientLifetimeManager());
            container.RegisterType<ICoveringTypeServices, CoveringTypeServices>(new TransientLifetimeManager());
        }

        /// <summary>
        /// Registers data types related with repositories.
        /// </summary>
        /// <param name="container"></param>
        private static void RegisterRepositories(IUnityContainer container)
        {
            container.RegisterType<IInsurancePolicyRepository, InsurancePolicyRepository>(new TransientLifetimeManager());
            container.RegisterType<ICoveringTypeRepository, CoveringTypeRepository>(new TransientLifetimeManager());
        }

        /// <summary>
        /// Configures a Real Container.
        /// </summary>
        /// <param name="container"></param>
        private static void ConfigureRealContainer(IUnityContainer container)
        {
            container.RegisterType<Context>();
        }
    }
}
