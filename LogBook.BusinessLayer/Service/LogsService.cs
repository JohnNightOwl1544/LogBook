﻿using LogBook.BusinessLayer.Entities;
using LogBook.BusinessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBook.BusinessLayer.Service
{
    public class LogsService
    {
        private LogRepository _selectLogs;
        private LogRepository _insertLogs;
        private LogRepository _updateLogs;
        private LogRepository _deleteLogs;

        public LogsService()
        {
            _selectLogs = new LogRepository();
            _insertLogs = new LogRepository();
            _updateLogs = new LogRepository();
            _deleteLogs = new LogRepository();
        }

        public List<Logs> GetAllLogs()
        {
            return _selectLogs.Select().ToList();
        }

        public int PostLogs(Logs data)
        {
            return _insertLogs.Insert(data);
        }

        public int UpdateLogs(Logs data)
        {
            return _updateLogs.Update(data);
        }

        public int DeleteLogs(Logs data)
        {
            return _deleteLogs.Delete(data);
        }
    }
}