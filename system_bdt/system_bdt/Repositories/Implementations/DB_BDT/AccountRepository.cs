using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using system_bdt.Data;
using system_bdt.Models.Entities;
using system_bdt.Repositories.Base;
using system_bdt.Repositories.Interfaces.DB_BDT;

namespace system_bdt.Repositories.Implementations.DB_BDT
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {

        public AccountRepository(ApplicationDbContext context): base(context)
        {
        }

        //Aqui dentro podemos crea la logica de consulta de la base de datos que queremos
        //Ejemplo:

        //public Account GetByEmail(string email)
        //{
        //    return Query().FirstOrDefault(x => x.Email == email);
        //}
    }
}