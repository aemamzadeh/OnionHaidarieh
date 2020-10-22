﻿using _01_HaidariehQuery.Contracts.CeremonyGuests;
using Haidarieh.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _01_HaidariehQuery.Query
{
    public class CeremonyGuestQuery : ICeremonyGuestQuery
    {
        private readonly HContext _hContext;

        public CeremonyGuestQuery(HContext hContext)
        {
            _hContext = hContext;
        }

        public List<CeremonyGuestQueryModel> GetComing()
        {
            return _hContext.CeremonyGuests.Where(x=> x.Status == true && 
                                                DateTime.Now.Date <= x.CeremonyDate.Date &&
                                                DateTime.Compare(x.CeremonyDate.AddHours(4),DateTime.Now)>0).
                                                Select(x=>new CeremonyGuestQueryModel 
            {
                Ceremony = x.Ceremony.Title,
                CeremonyDate = x.CeremonyDate,
                Image = x.Image,
                IsLive = x.IsLive,
                Guest = x.Guest.FullName,
                BannerFile = x.BannerFile
            }).ToList();
        }
        public List<CeremonyGuestQueryModel> GetPast()
        {
            return _hContext.CeremonyGuests.Where(x=>x.Status == true && 
                                                x.CeremonyDate.Date <= DateTime.Now.Date && 
                                                DateTime.Compare(x.CeremonyDate.AddHours(4),DateTime.Now)<0).
                                                Select(x => new CeremonyGuestQueryModel
                                                {
                                                    Ceremony = x.Ceremony.Title,
                                                    CeremonyDate = x.CeremonyDate,
                                                    Image = x.Image,
                                                    IsLive = x.IsLive,
                                                    Guest = x.Guest.FullName,
                                                    BannerFile = x.BannerFile
                                                }).ToList();
        }
        public List<CeremonyGuestQueryModel> GetAll()
        {
            return _hContext.CeremonyGuests.Where(x=>x.Status==true).Select(x => new CeremonyGuestQueryModel
            {
                Ceremony = x.Ceremony.Title,
                CeremonyDate = x.CeremonyDate,
                Image = x.Image,
                IsLive = x.IsLive,
                Guest = x.Guest.FullName,
                BannerFile = x.BannerFile
            }).ToList();

        }

    }
}