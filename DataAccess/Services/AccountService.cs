using AutoMapper;
using BusinessObject.Models;
using BusinessObject.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{

    public interface IAccountServices
    {
        IEnumerable<Account> GetAll();
    }

    public class AccountService : IAccountServices
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;


        public AccountService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }


        public IEnumerable<Account> GetAll()
        {
            var accounts = unitOfWork.Repository<Account>().GetAll();
            return accounts;
        }

    }


}
