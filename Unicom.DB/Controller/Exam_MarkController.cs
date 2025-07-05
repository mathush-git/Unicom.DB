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
    internal class Exam_MarkController
    {
        private readonly Exam_MarkService _exam_markService;

        public Exam_MarkController()
        {
            _exam_markService = new Exam_MarkService();
        }

        public List<Exam_mark> GetAllExam_mark() => _exam_markService.GetAll();

        public void AddExam_mark(Exam_mark exam_mark) => _exam_markService.AddExam_mark(exam_mark);

        public void UpdateExam_mark(Exam_mark exam_mark) => _exam_markService.Update(exam_mark);

        public void DeleteExam_mark(int exam_markId) => _exam_markService.Delete(exam_markId);
    }
}
