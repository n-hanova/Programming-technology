using OlympMotors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OlympMotors.DAOClass
{
    public class ConductorDAO
    {
        private Entities entities = new Entities();

        public IEnumerable<Conductor> GetAllConductors()
        {
            return entities.Conductor.Select(n => n);
        }


        public bool AddConductor(Conductor conductor)
        {
            try
            {
                entities.Conductor.Add(conductor);
                entities.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool UpdateConductor(Conductor conductor)
        {
            try
            { 
            var Entity = entities.Conductor.FirstOrDefault(x => x.Id_Conductor == conductor.Id_Conductor);
            Entity.NameConductor = conductor.NameConductor;
            Entity.SurnameConductor = conductor.SurnameConductor;
            entities.SaveChanges();
        }
            catch
            {
                return false;
            }
            return true;
        }

        public Conductor GetConductor(int id)
        {
            return entities.Conductor.Where(n => n.Id_Conductor == id).First();
        }

        public void DeleteConductor(int id)
        {
            Conductor delC = GetConductor(id);
            entities.Conductor.Remove(delC);
            entities.SaveChanges();
        }
    }
}