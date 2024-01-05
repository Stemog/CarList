﻿using Domain.Models;

namespace DAL.Contexts.Interfaces
{
    public interface IListingContext
    {
        void AddListing(Listing listing);
        Listing? GetListing(Guid listingId);
        List<Listing> GetListings();
    }
}