using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Entities.Contracts
{
    public interface IPerishable
    {
        DateTime ExpirationDate { get; }
    }
}
