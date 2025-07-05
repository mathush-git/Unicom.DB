using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom.DB.Data;
using Unicom.DB.Models;
using Unicom.DB.Service;

namespace Unicom.DB.Controller
{
    public class StudentController
    {
        private readonly StudentService _studentService;

        public StudentController()
        {
            _studentService = new StudentService();
        }

        public List<Student> GetAllStudent() => _studentService.GetAll();

        public void AddStudent(Student student) => _studentService.Add(student);

        public void UpdateStudent(Student student) => _studentService.Update(student);

        public void DeleteStudent(int StudentId) => _studentService.Delete(StudentId);

        internal object GetStudentById(int selectedStudentId)
        {
            throw new NotImplementedException();
        }
    }
}
