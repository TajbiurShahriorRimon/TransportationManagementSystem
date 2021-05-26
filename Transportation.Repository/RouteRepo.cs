﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Data;
using Transportation.Entity;

namespace Transportation.Repository
{
    public class RouteRepo
    {
        public static List<Route> GetAll()
        {
            var routeList = new List<Route>();
            string sql = "SELECT * FROM route";
            var dt = DataAccess.GetDataTable(sql);
            int row = 0;
            while (row < dt.Rows.Count)
            {
                Route routes = ConvertToEntity(dt.Rows[row]);
                routeList.Add(routes);
                row++;
            }
            return routeList;
        }
        private static Route ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var r = new Route();
            r.RouteId = row["route_id"].ToString();
            r.DeptLocation = row["dept_location"].ToString();
            r.Destination = row["destination"].ToString();
            r.BusNo = row["bus_no"].ToString();
            r.ScheduleId = row["schedule_id"].ToString();
            r.Status = row["status"].ToString();
            return r;
        }
        
        public static string GetId() //Used to generate an Id
        {
            string sql = "select TOP 1 * from [Route] order by route_id DESC;";
            var dt = DataAccess.GetDataTable(sql);

            if (dt.Rows.Count > 0)
            {
                string id = dt.Rows[0]["route_id"].ToString();
               
                int intId=int.Parse(id) ;
                intId++;
                return intId.ToString();
            }

            return "01";
        }
        
        public static bool SearchRouteId(string key)
        {
            var sql = "select * from [Route] where route_id = '" + key + "';";
            var dt = DataAccess.GetDataTable(sql);
            return dt.Rows.Count == 1;
        }
        
        public static bool Insert(Route route)
        {
            int? n = null;
            var sql = $"INSERT INTO [Route] VALUES('{route.RouteId}', '{n}', '{n}', '{n}', '{route.DeptLocation}', '{route.Destination}', '{route.BusNo}', '{route.Status}')";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1; 
        }
        
        public static bool Update(Route route)
        {
            int? n = null;
            var sql = $"UPDATE [Route] SET route_id = '{route.RouteId}', dept_time = '{n}', arrival_time = '{n}', journey_date = '{n}', dept_location = '{route.DeptLocation}', destination = '{route.Destination}', bus_no = '{route.BusNo}', status = '{route.Status}';";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1;
        }
    }
}