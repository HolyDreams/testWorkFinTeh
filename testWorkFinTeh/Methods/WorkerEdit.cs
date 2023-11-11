using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testWorkFinTeh.Models;

namespace testWorkFinTeh.Methods
{
    internal class WorkerEdit
    {
        public void EditWorker(WorkerStruct worker)
        {
            if (worker.ID == Guid.Empty)
                AddWorker(worker);
            else
                UpdateWorker(worker);
        }
        private void UpdateWorker(WorkerStruct worker)
        {
            var sqlQuery = $@"UPDATE finteh_workers
                              SET first_name = '{worker.Name}',
                                  middle_name = '{worker.MiddleName}',
                                  last_name = '{worker.LastName}',
                                  role_id = '{worker.RoleID}',
                                  departament_id = '{worker.DepartID}'
                              WHERE worker_id = '{worker.ID}'";
            SQLRequest.PostgreSQL(sqlQuery);
        }
        private void AddWorker(WorkerStruct worker)
        {
            var sqlQuery = $@"INSERT INTO finteh_workers (first_name, middle_name, last_name, role_id, departament_id)
                              VALUES('{worker.Name}',
                                     '{worker.MiddleName}',
                                     '{worker.LastName}',
                                     '{worker.RoleID}',
                                     '{worker.DepartID}')
                              RETURNING worker_id";
            var res = SQLRequest.PostgreSQL(sqlQuery);
            var rnd = new Random();
            sqlQuery = $@"INSERT INTO finteh_vacation (worker_id, date_start, date_end)
                              VALUES ('{(Guid)res.Rows[0][0]}',
                                      '{new DateTime(1, rnd.Next(1, 13), 1)}',
                                      '{new DateTime(1, rnd.Next(1, 13), 1)}')";
            SQLRequest.PostgreSQL(sqlQuery);
        }
        public void DelWorker(Guid workerID)
        {
            var sqlQuery = $@"UPDATE finteh_workers
                              SET delete_state_code = 1
                              WHERE worker_id = '{workerID}'";
            SQLRequest.PostgreSQL(sqlQuery);
        }
    }
}
