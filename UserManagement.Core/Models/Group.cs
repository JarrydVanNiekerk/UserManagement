﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Core.Models;

namespace UserManagement.Core.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        public ICollection<UserGroup> UserGroups { get; set; }
        public ICollection<GroupPermission> GroupPermissions { get; set; }  // Many-to-many with Permissions
    }
}

