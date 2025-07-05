using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom.DB.Models;
using Unicom.DB.Service;

namespace Unicom.DB.Controller
{
    internal class ExamController
    {
        private readonly ExamService _examService;

        public ExamController()
        {
            _examService = new ExamService();
        }

        public List<ExamItem> GetAllExam() => _examService.GetAll();

        public void AddExam(ExamItem examitem) => _examService.Add(examitem);

        public void UpdateExam(ExamItem examitem) => _examService.Update(examitem);

        public void DeleteExam(int examitemId) => _examService.Delete(examitemId);
    }
}
