using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom.DB.Models;
using Unicom.DB.Service;

namespace Unicom.DB.Controller
{
    internal class StudentLecturerController
    {
        private readonly StudentLecturerService _service;

        public StudentLecturerController()
        {
            _service = new StudentLecturerService();
        }

        public void AssignLecturerToStudent(int studentId, int teacherId)
            => _service.AssignLecturerToStudent(studentId, teacherId);

        public void RemoveLecturerFromStudent(int studentId, int teacherId)
            => _service.RemoveLecturerFromStudent(studentId, teacherId);

        public List<Lecturer> GetLecturerForStudent(int studentId)
            => _service.GetLecturerForStudent(studentId);
    }
}
