using GAP.PruebaSeguros.Data.Mappings;
using GAP.PruebaSeguros.Domain.Default;
using GAP.PruebaSeguros.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP.PruebaSeguros.Data
{
    public class Context : DbContext, IContext
    {
        /// <summary>
        /// Static Constructor.
        /// </summary>
        static Context()
        {
            Database.SetInitializer<Context>(null);
        }

        /// <summary>
        /// Class constructor connected to the default connection string.
        /// </summary>
        public Context()
            : base("GAPSeguros")
        {

        }

        #region DbSet

        /// <summary>
        /// gets or sets data on the InsurancePolicy Table.
        /// </summary>
        public DbSet<InsurancePolicy> InsurancePolicy { get; set; }

        #endregion DbSet

        /// <summary>
        /// Commits this instance.
        /// </summary>
        public void Commit()
        {
            try
            {
                var cx = ((IObjectContextAdapter)this).ObjectContext;
                this.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Commits the and refresh changes.
        /// </summary>
        public void CommitAndRefreshChanges()
        {
            try
            {
                this.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// This method is called when the model for a derived context has been initialized, but
        /// before the model has been locked down and used to initialize the context.  The default
        /// implementation of this method does nothing, but it can be overridden in a derived class
        /// such that the model can be further configured before it is locked down.
        /// </summary>
        /// <param name="modelBuilder">The builder that defines the model for the context being created.</param>
        /// <remarks>
        /// Typically, this method is called only once when the first instance of a derived context
        /// is created.  The model for that context is then cached and is for all further instances of
        /// the context in the app domain.  This caching can be disabled by setting the ModelCaching
        /// property on the given ModelBuidler, but note that this can seriously degrade performance.
        /// More control over caching is provided through use of the DbModelBuilder and DbContextFactory
        /// classes directly.
        /// </remarks>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new InsurancePolicyMap());
        }
    }
}
