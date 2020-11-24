﻿using _0_Framework.Domain;
using _0_Framework.Infrastructure;
using AccountManagement.Application.Contracts.Role;
using AccountManagement.Domain.RoleAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Infrastructure.EFCore.Repository
{
    public class RoleRepository : RepositoryBase<long, Role>, IRoleRepository
    {
        private readonly AccountContext _accountContext;

        public RoleRepository(AccountContext accountContext):base(accountContext)
        {
            _accountContext = accountContext;
        }
        public EditRole GetDetail(long id)
        {
            return _accountContext.Roles.Select(x => new EditRole
            {
                Id = x.Id,
                Title = x.Title
            }).FirstOrDefault(x=>x.Id == id);
        }

        public List<RoleViewModel> GetRoles()
        {
            return _accountContext.Roles.Select(x => new RoleViewModel 
            {
                Id=x.Id,
                Title=x.Title
            }).ToList();

            
        }
    }
}
  