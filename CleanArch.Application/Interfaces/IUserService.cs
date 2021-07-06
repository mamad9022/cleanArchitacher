using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Models;

namespace CleanArch.Application.Interfaces
{
   public interface IUserService
   {
       CheckUser CheckUser(string username, string email);
       int RegisterUser(User user);
       bool IsExistUser(string email, string password);
   }
}
