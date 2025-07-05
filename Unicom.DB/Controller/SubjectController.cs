using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom.DB.Models;
using Unicom.DB.Service;

namespace Unicom.DB.Controller
{
    internal class SubjectController
    {
        private readonly SubjectService _subjectService;

        public SubjectController()
        {
            _subjectService = new SubjectService();
        }

        public List<Subject> GetAllSubject() => _subjectService.GetAll();

        public void AddSubject(Subject subject) => _subjectService.Add(subject);

        public void UpdateSubject(Subject subject) => _subjectService.Update(subject);

        public void DeleteSubject(int subjectId) => _subjectService.Delete(subjectId);
    }
}
