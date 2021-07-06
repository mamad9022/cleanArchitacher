using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using Microsoft.EntityFrameworkCore.Internal;

namespace CleanArch.Infra.Data.Repository
{
   public class UserRepository:IUserRepository
   {
       private UniversityDBContext _ctx;

       public UserRepository(UniversityDBContext ctx)
       {
           _ctx = ctx;
       }

       public bool IsExistUser(string email, string password)
       {
           return _ctx.Users.Any(u => u.Email == email && u.Password == password);
       }

       public void AddUser(User user)
        {
            _ctx.Add(user);
        }

        public bool IsExistUserName(string userName)
        {
            return _ctx.Users.Any(u => u.UserName == userName);
        }

        public bool IsExistEmail(string email)
        {
            return _ctx.Users.Any(u => u.Email == email);
        }

       public void Save()
       {
           _ctx.SaveChanges();
       }
   }
}
