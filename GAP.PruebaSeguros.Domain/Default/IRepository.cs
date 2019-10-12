using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP.PruebaSeguros.Domain.Default
{
    public interface IRepository<TEntity> : IUnitOfWork where TEntity : class, new()
    {
        /// <summary>
        /// Get the context of this repository.
        /// </summary>
        IContext StoreContext { get; }

        /// <summary>
        /// Add an item to the repository.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="user"></param>
        bool Add(TEntity item, AbstractUser user);

        /// <summary>
        /// Add a collection of items to the repository.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="user"></param>
        bool AddItems(IEnumerable<TEntity> items, AbstractUser user);

        /// <summary>
        /// Remove an item from the repository.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="user"></param>
        void Remove(TEntity item, AbstractUser user);

        /// <summary>
        /// Apply a modified entity to the repository, When calling commit of the unit of work, these changes will be stored.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="user"></param>
        bool Modify(TEntity item, AbstractUser user);

        /// <summary>
        /// Gets all elements of type {T} that are found in the repository.
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> GetAll();
    }
}

