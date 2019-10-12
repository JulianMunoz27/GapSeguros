using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GAP.PruebaSeguros.Domain.Specification
{
    public interface ISpecification<TEntity> where TEntity : class, new()
    {
        /// <summary>
        /// Check if this specification meets a lambda expression.
        /// </summary>
        /// <returns></returns>
        Expression<Func<TEntity, bool>> SatisfiedBy();
    }
}
