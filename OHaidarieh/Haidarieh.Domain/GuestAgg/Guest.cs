﻿using _0_Framework.Domain;
using Haidarieh.Domain.CeremonyGuestAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Threading.Tasks;

namespace Haidarieh.Domain.GuestAgg 
{
    public class Guest:EntityBase
    {
        public string FullName { get; private set; }
        public string Tel { get; private set; }
        public string Image { get; private set; }
        public string ImageAlt { get; private set; }
        public string ImageTitle { get; private set; }
        public string GuestType { get; private set; }
        public string Coordinator { get; private set; }
        public bool Status { get; private set; }
        public List<CeremonyGuest> CeremonyGuests { get; private set; }

        public Guest(string fullName, string tel, string image, string imageAlt, 
            string imageTitle, string guestType, string coordinator)
        {
            FullName = fullName;
            Tel = tel;
            Image = image;
            ImageAlt = imageAlt;
            ImageTitle = imageTitle;
            GuestType = guestType;
            Coordinator = coordinator;
            CeremonyGuests = new List<CeremonyGuest>();
        }
        public void Edit(string fullName, string tel, string image, string imageAlt,
            string imageTitle, string guestType, string coordinator)
        {
            FullName = fullName;
            Tel = tel;
            if(!string.IsNullOrWhiteSpace(image))
                Image = image;
            ImageAlt = imageAlt;
            ImageTitle = imageTitle;
            GuestType = guestType;
            Coordinator = coordinator;
            CeremonyGuests = new List<CeremonyGuest>();
        }
    }
}
