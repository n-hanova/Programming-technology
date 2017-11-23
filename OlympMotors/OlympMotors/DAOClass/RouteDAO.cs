using OlympMotors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OlympMotors.DAOClass
{
    public class RouteDAO
    {
        private Entities entities = new Entities();

        public IEnumerable<Route> GetAllRoutes()
        {
            return entities.Route.Select(n => n);
        }


        public bool AddRoute(Route route)
        {
            route.StartPoint = route.StartPoint;
            route.StopPoint = route.StopPoint;
            route.StartStop = route.StartPoint + "-" + route.StopPoint;
            try
            {
                entities.Route.Add(route);
                entities.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool UpdateRoute(Route route)
        {
            try { 
            var Entity = entities.Route.FirstOrDefault(x => x.Id_Route == route.Id_Route);
            Entity.StartPoint = route.StartPoint;
            Entity.StopPoint = route.StopPoint;
            Entity.StartStop = route.StartPoint + "-" + route.StopPoint;
                entities.SaveChanges();
        }
            catch
            {
                return false;
            }
            return true;
        }

        public Route GetRoute(int id)
        {
            return entities.Route.Where(n => n.Id_Route == id).First();
        }

        public void DeleteRoute(int id)
        {
            Route delR = GetRoute(id);
            entities.Route.Remove(delR);
            entities.SaveChanges();
        }
    }
}