﻿using System.Collections.Generic;
using System.Threading.Tasks;
using UserManagement.Core.Models;
using UserManagement.Repository.Interfaces;

namespace UserManagement.Services.Interfaces
{
    public interface IGroupService : IGenericRepository<Group>
    {
        //Any additional other than from the base repo
    }
}
