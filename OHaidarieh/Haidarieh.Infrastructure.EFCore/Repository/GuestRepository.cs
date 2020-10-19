﻿using _0_Framework.Infrastructure;
using Haidarieh.Application.Contracts.Guest;
using Haidarieh.Domain.GuestAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haidarieh.Infrastructure.EFCore.Repository
{
    public class GuestRepository : RepositoryBase<long, Guest>, IGuestRepository
    {
        private readonly HContext _hContext;
        public GuestRepository(HContext hContext) : base(hContext)
        {
            _hContext = hContext;
        }
        public EditGuest GetDetail(long id)
        {
            return _hContext.Guests.Select(x => new EditGuest()
            {
                Id = x.Id,
                FullName = x.FullName,
                Tel = x.Tel,
                GuestType = x.GuestType,
                Image = x.Image,
                ImageAlt = x.ImageAlt,
                ImageTitle = x.ImageTitle,
                Coordinator = x.Coordinator
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<GuestViewModel> GetGuests()
        {
            return _hContext.Guests.Select(x => new GuestViewModel
            {
                Id=x.Id,
                GuestType=x.GuestType,
                FullName=x.FullName,
                Image=x.Image,
                Tel=x.Tel,
                Coordinator=x.Coordinator
            }).ToList();
        }

        public List<GuestViewModel> Search(GuestSearchModel searchModel)
        {
            var query = _hContext.Guests.Select(x => new GuestViewModel
            {
                Id = x.Id,
                FullName = x.FullName,
                Tel = x.Tel,
                GuestType = x.GuestType,
                Image = x.Image,
                Coordinator = x.Coordinator
            });

            if (!string.IsNullOrWhiteSpace(searchModel.FullName))
                query = query.Where(x => x.FullName.Contains(searchModel.FullName));

            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}
