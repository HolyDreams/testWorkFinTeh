using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testWorkFinTeh.Models;
using testWorkFinTeh.Startup;

namespace testWorkFinTeh.Methods
{
    internal class GetData
    {
        public List<WorkerStruct> GetWorkers()
        {
            var sqlQuery = $@"SELECT w.worker_id,
                                     first_name,
                                     middle_name,
                                     last_name,
                                     role_id,
                                     departament_id,
                                     v.date_start,
                                     v.date_end
                              FROM finteh_workers AS w LEFT JOIN
                                     finteh_vacation AS v ON w.worker_id = v.worker_id AND
                                                             v.delete_state_code = 0
                              WHERE w.delete_state_code = 0";
            var res = SQLRequest.PostgreSQL(sqlQuery);
            if (res == null || res.Rows.Count == 0)
                return new List<WorkerStruct>();

            var roles = StaticParams.getRole();
            var departs = StaticParams.getDepart();

            return (from DataRow a in res.Rows
                    select new WorkerStruct
                    {
                        ID = (Guid)a["worker_id"],
                        Name = (string)a["first_name"],
                        MiddleName = (string)a["middle_name"],
                        LastName = a["last_name"] == DBNull.Value ? null : (string?)a["last_name"],
                        RoleID = (Guid)a["role_id"],
                        RoleName = roles.First(q => q.ID == (Guid)a["role_id"]).Name,
                        DepartID = (Guid)a["departament_id"],
                        DepartName = departs.First(q => q.ID == (Guid)a["departament_id"]).Name,
                        VacationStart = a["date_start"] == DBNull.Value ? null : (DateTime?)a["date_start"],
                        VacationEnd = a["date_end"] == DBNull.Value ? null : (DateTime?)a["date_end"]
                    }).ToList();
        }
        public WorkerStruct GetWorker(Guid id) 
        {
            var sqlQuery = $@"SELECT first_name,
                                     middle_name,
                                     last_name,
                                     role_id,
                                     departament_id
                              FROM finteh_workers
                              WHERE worker_id = '{id}' AND
                                    delete_state_code = 0";
            var res = SQLRequest.PostgreSQL(sqlQuery);
            if (res == null || res.Rows.Count == 0)
                return new WorkerStruct();

            var roles = StaticParams.getRole();
            var departs = StaticParams.getDepart();

            return (from DataRow a in res.Rows
                    select new WorkerStruct
                    {
                        ID = id,
                        Name = (string)a["first_name"],
                        MiddleName = (string)a["middle_name"],
                        LastName = a["last_name"] == DBNull.Value ? null : (string)a["last_name"],
                        RoleID = (Guid)a["role_id"],
                        RoleName = roles.First(q => q.ID == (Guid)a["role_id"]).Name,
                        DepartID = (Guid)a["departament_id"],
                        DepartName = departs.First(q => q.ID == (Guid)a["departament_id"]).Name
                    }).First();
        }
        public List<IdGuidNameStruct> GetRoles()
        {
            return (List<IdGuidNameStruct>)getObject("role_id", "finteh_roles");
        }
        public List<IdGuidNameStruct> GetDeparts()
        {
            return (List<IdGuidNameStruct>)getObject("departament_id", "finteh_departaments");
        }
        private object getObject(string idName, string dbName)
        {
            var sqlQuery = $@"SELECT {idName},
                                     name
                              FROM {dbName}
                              WHERE delete_state_code = 0";
            var res = SQLRequest.PostgreSQL(sqlQuery);
            if (res == null || res.Rows.Count == 0)
                return new List<IdGuidNameStruct>();

            return (from DataRow a in res.Rows
                    select new IdGuidNameStruct
                    {
                        ID = (Guid)a[0],
                        Name = (string)a["name"],
                    }).OrderBy(a => a.Name).ToList();
        }
    }
}
