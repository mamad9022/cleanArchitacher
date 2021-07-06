using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Models;

namespace CleanArch.Application.Interfaces
{
   public interface ICourseService
   {
       CourseViewModel GetCourses();
       Course GetCourseById(int courseId);
   }
}
