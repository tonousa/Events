﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace ManagingUsers
{
    public class StaticRoleProvider : RoleProvider
    {
        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            return true;
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            return roleName == "users" && usernameToMatch == "Joe" ?
                new string[] { "Joe" } : new string[0];
        }

        public override string[] GetAllRoles()
        {
            return new string[] { "users", "admins" };
        }

        public override string[] GetRolesForUser(string username)
        {
            return username == "Joe" ? new string[] { "users" } : new string[0];
        }

        public override string[] GetUsersInRole(string roleName)
        {
            return roleName == "users" ? new string[] { "Joe" } : new string[0];
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            return username == "Joe" && roleName == "users";
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            return roleName == "users" || roleName == "admins";
        }
    }
}