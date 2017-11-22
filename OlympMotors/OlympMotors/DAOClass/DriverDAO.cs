using OlympMotors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OlympMotors.DAOClass
{
    public class DriverDAO
    {
        private Entities entities = new Entities();

        public IEnumerable<Driver> GetAllDrivers()
        {
            return entities.Driver.Select(n => n);
        }


        public bool AddDriver(Driver driver)
        {
            try
            {
                entities.Driver.Add(driver);
                entities.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public void UpdateDriver(Driver driver)
        {
            var Entity = entities.Driver.FirstOrDefault(x => x.Id_Driver == driver.Id_Driver);
            Entity.Driver_license = driver.Driver_license;
            Entity.NameDriver = driver.NameDriver;
            Entity.SurnameDriver = driver.SurnameDriver;
            entities.SaveChanges();
        }

        public Driver GetDriver(int id)
        {
            return entities.Driver.Where(n => n.Id_Driver == id).First();
        }

        public void DeleteDriver(int id)
        {
            Driver delD = GetDriver(id);
            entities.Driver.Remove(delD);
            entities.SaveChanges();
        }
    }
}