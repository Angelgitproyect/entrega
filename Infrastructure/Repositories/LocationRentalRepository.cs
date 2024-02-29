﻿using Core.Entities;
using Core.Interfaces.Repository;
using Persistence.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class LocationRentalRepository(PruebaTecnicaContext contex) : BaseRepository<LocationRental>(contex), ILocationRentalRepository
    {
    }
}
