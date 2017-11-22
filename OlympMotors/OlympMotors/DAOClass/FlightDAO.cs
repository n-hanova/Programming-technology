using OlympMotors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OlympMotors.DAOClass
{
    public class FlightDAO
    {
        private Entities entities = new Entities();

        public IEnumerable<Flight> GetAllFlights()
        {
            return entities.Flight.Select(n => n);
        }


        public bool AddFlight(Flight flight)
        {
            try
            {
                entities.Flight.Add(flight);
                entities.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public void UpdateFlight(Flight flight)
        {
            var Entity = entities.Flight.FirstOrDefault(x => x.Id_Flight == flight.Id_Flight);
            Entity.NumberFlight = flight.NumberFlight;
            Entity.StartTime = flight.StartTime;
            Entity.StopTime = flight.StopTime;
            Entity.Id_Route = flight.Id_Route;
            Entity.Id_Driver = flight.Id_Driver;
            Entity.Id_Conductor = flight.Id_Conductor;
            Entity.Id_Transport = flight.Id_Transport;
            Entity.CountTicket = flight.CountTicket;
            entities.SaveChanges();
        }

        public Flight GetFlight(int id)
        {
            return entities.Flight.Where(n => n.Id_Flight == id).First();
        }

        public void DeleteFlight(int id)
        {
            Flight delF = GetFlight(id);
            entities.Flight.Remove(delF);
            entities.SaveChanges();
        }
    }
}