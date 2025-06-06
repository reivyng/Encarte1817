﻿using Data.Implements.BaseData;
using Data.Interfaces.Security;
using Entity.Context;
using Entity.Model.Security;

namespace Data.Implements.Security.RolUserData;

    public class RolUserData : BaseModelData<RolUser>, IRolUserData
    {
        public RolUserData(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<bool> UpdatePartial(RolUser rolUser)
        {
            var existingRolUser = await _context.RolUsers.FindAsync(rolUser.Id);
            if (existingRolUser == null) return false;
            // Update only the fields that are not null
            if (rolUser.RolId > 0) existingRolUser.RolId = rolUser.RolId;
            if (rolUser.UserId > 0) existingRolUser.UserId = rolUser.UserId;
            _context.RolUsers.Update(existingRolUser);
            await _context.SaveChangesAsync();
            return true;
        }
    }