using OlympMotors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OlympMotors.DAOClass
{
    public class UserDAO
    {
        private Entities entities = new Entities();

        public IEnumerable<AspNetUsers> GetAllUsers()
        {
            return entities.AspNetUsers.Select(n => n);
        }


        public bool AddUser(AspNetUsers user)
        {
            try
            {
                entities.AspNetUsers.Add(user);
                entities.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public void UpdateUser(AspNetUsers user)
        {
            var Entity = entities.AspNetUsers.FirstOrDefault(x => x.Id == user.Id);
            //Entity.NumberFlight = flight.NumberFlight;
            //Entity.StartTime = flight.StartTime;
            //Entity.StopTime = flight.StopTime;
            //Entity.Id_Route = flight.Id_Route;
            //Entity.Id_Driver = flight.Id_Driver;
            //Entity.Id_Conductor = flight.Id_Conductor;
            //Entity.Id_Transport = flight.Id_Transport;
            //Entity.CountTicket = flight.CountTicket;
            //entities.SaveChanges();
        }

        //public AspNetUsers GetUser(int id)
        //{
        //    return entities.AspNetUsers.Where(n => n.Id == id).First();
        //}

        //public void DeleteUser(int id)
        //{
        //    AspNetUsers delU = GetUser(id);
        //    entities.AspNetUsers.Remove(delU);
        //    entities.SaveChanges();
        //}
    }
}