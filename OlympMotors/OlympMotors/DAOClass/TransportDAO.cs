using OlympMotors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OlympMotors.DAOClass
{
    public class TransportDAO
    {
        private Entities entities = new Entities();

        public IEnumerable<Transport> GetAllTransports()
        {
            return entities.Transport.Select(n => n);
        }


        public bool AddTransport(Transport transport)
        {
            try
            {
                entities.Transport.Add(transport);
                entities.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool UpdateTransport(Transport transport)
        {
            try
            {
                var Entity = entities.Transport.FirstOrDefault(x => x.Id_Transport == transport.Id_Transport);
                Entity.State_number = transport.State_number;
                Entity.BrandTransport = transport.BrandTransport;
                entities.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public Transport GetTransport(int id)
        {
            return entities.Transport.Where(n => n.Id_Transport == id).First();
        }

        public void DeleteTransport(int id)
        {
            Transport delT = GetTransport(id);
            entities.Transport.Remove(delT);
            entities.SaveChanges();
        }
    }
}
