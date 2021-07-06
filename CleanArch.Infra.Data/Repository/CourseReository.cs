using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;

namespace CleanArch.Infra.Data.Repository
{
   public class CourseReository:ICourseRepository
   {
       private UniversityDBContext _ctx;

       public CourseReository(UniversityDBContext ctx)
       {
           this._ctx = ctx;
       }
        public IEnumerable<Course> GetCourses()
        {
            return _ctx.Courses;
        }

       public Course GetCourseById(int courseId)
       {
           return _ctx.Courses.Find(courseId);
       }
   }
}
