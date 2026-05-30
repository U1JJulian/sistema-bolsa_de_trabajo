using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using system_bdt.Models.Entities;

namespace system_bdt.Repositories.Interfaces.DB_BDT
{
    public interface IAccountRepository : IRepositoryBase<Account>
    {
        //Aqui dentro se coloca la direccion del metodo a consultar
        //Ejemplo:

        //Account GetByEmail(string email);
    }
}
