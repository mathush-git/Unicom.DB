using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom.DB.Models;
using Unicom.DB.Service;

namespace Unicom.DB.Controller
{
    internal class LecturerController
    {
        private readonly LecturerService _lecturerService;

        public LecturerController()
        {
            _lecturerService = new LecturerService();
        }

        public List<Lecturer> GetAllLecturer() => _lecturerService.GetAll();

        public void AddLecturer(Lecturer lecturer) => _lecturerService.Add(lecturer);

        public void UpdateLecturer(Lecturer lecturer) => _lecturerService.Update(lecturer);

        public void DeleteLecturer(int lecturerId) => _lecturerService.Delete(lecturerId);
    }
}
