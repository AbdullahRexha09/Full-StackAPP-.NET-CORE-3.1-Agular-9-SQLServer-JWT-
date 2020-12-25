﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapplication.Models;

namespace webapplication.Services
{
    public interface ILocationService
    {
        List<Location> GetAllLocations();
        bool DeleteLocation(Guid Id);
        Location UpdateLocation(Location location);
        Location AddLocation(Location location);
    }
}