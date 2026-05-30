using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using system_bdt.Models.Entities;
using system_bdt.Repositories.Interfaces.DB_BDT;
using system_bdt.Services.Interfaces.DB_BDT;

namespace system_bdt.Services.Implementations.DB_BDT
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _repository;

        public AccountService(
            IAccountRepository repository)
        {
            _repository = repository;
        }

        //public Account ObtenerPorCorreo(string correo)
        //{
        //    return _repository.GetByEmail(correo);
        //}
    }
}