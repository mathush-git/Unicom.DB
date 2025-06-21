using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom.DB.Models;
using Unicom.DB.Service;

namespace Unicom.DB.Controller
{
    internal class LecturerCourseController
    {
        private readonly LecturerCourseService _service;

        public LecturerCourseController()
        {
            _service = new LecturerCourseService();
        }

        public void AssignLecturerToCourse(int lecturerId, int courseId)
            => _service.AssignLecturerToCourse(lecturerId, courseId);

        public void RemoveLecturerFromCourse(int lecturerId, int courseId)
            => _service.RemoveLecturerFromCourse(lecturerId, courseId);

        public List<Lecturer> GetLecturerForCourse(int lecturerId)
            => _service.GetLecturerForCourse(lecturerId);
    }
}
