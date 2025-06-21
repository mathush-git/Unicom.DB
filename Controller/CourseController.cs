using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using Unicom.DB.Data;
using Unicom.DB.Models;
using Unicom.DB.Service;

namespace Unicom.DB.Controller
{
    internal class CourseController
    {
        private readonly CourseService _courseService;

        public CourseController()
        {
            _courseService = new CourseService();
        }

        public List<Course> GetAllCourse() => _courseService.GetAll();

        public void AddCourse(Course courses) => _courseService.Add(courses);

        public void UpdateCourse(Course courses) => _courseService.Update(courses);

        public void DeleteCourse(int coursesId) => _courseService.Delete(coursesId);
    }
}
