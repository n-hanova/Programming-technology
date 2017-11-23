using OlympMotors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OlympMotors.DAOClass
{
    public class AspNetUserDAO
    {

        private Entities entities = new Entities();

        public IEnumerable<AspNetUsers> GetAllUsers()
        {
            return entities.AspNetUsers.Select(n => n);
        }

        public bool UpdateUser(AspNetUsers user)
        {
            try
            { 
            var Entity = entities.AspNetUsers.FirstOrDefault(x => x.Id == user.Id);
            Entity.Email = user.Email;
            Entity.NameUser = user.NameUser;
            entities.SaveChanges();
        }
            catch
            {
                return false;
            }
            return true;
        }

        public AspNetUsers GetUser(string id)
        {
            return entities.AspNetUsers.Where(n => n.Id == id).First();
        }

        public void DeleteUser(string id)
        {
            AspNetUsers or = GetUser(id);
            entities.AspNetUsers.Remove(or);
            entities.SaveChanges();

        }

    }
}