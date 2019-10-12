using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP.PruebaSeguros.Domain.Default
{
    public abstract class AbstractUser
    {
        /// <summary>
        /// User Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// User Name.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// User Role Name.
        /// </summary>
        public abstract string RoleName { get; }

        /// <summary>
        /// User Current IP.
        /// </summary>
        public string CurrentIp { get; set; }
    }
}
