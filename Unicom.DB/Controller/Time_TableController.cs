using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom.DB.AddForms;
using Unicom.DB.Data;
using Unicom.DB.Models;
using Unicom.DB.Service;

namespace Unicom.DB.Controller
{
    internal class Time_TableController
    {
        private readonly Time_TableService _time_tableService;

        public Time_TableController()
        {
            _time_tableService = new Time_TableService();
        }

        public List<TimeTable> GetAllTimeTable() => _time_tableService.GetAll();

        public void AddTimeTable(TimeTable time_table) => _time_tableService.Add(time_table);

        public void UpdateTimeTable(TimeTable time_table) => _time_tableService.Update(time_table);

        public void DeleteTimeTable(int time_tableId) => _time_tableService.Delete(time_tableId);
    }
}
