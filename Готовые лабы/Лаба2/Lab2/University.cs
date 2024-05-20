using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab2
{
    public class University : Organization, IStaff
    {
        protected List<Faculty> faculties;

        public University()
        {
            faculties = new List<Faculty>();
        }

        public University(University university)
        {
            faculties = university.faculties;
            Name = university.Name;
            ShortName = university.ShortName;
            Address = university.Address;
            TimeStamp = university.TimeStamp;
        }

        public University(int id, string name, string shortName, string address, DateTime timeStamp) : base(id, name, shortName, address, timeStamp)
        {
        }

        public int AddFaculty(Faculty faculty)
        {
            faculties.Add(faculty);
            return faculties.IndexOf(faculty);
        }

        public bool DelFaculty(int index)
        {
            if (VerFaculty(index))
            {
                faculties.RemoveAt(index);
                return true;
            }
            else
                return false;
        }

        public bool UpdateFaculty(Faculty faculty)
        {
            if (!faculties.Contains(faculty))
                return false;

            int index = faculties.IndexOf(faculty);

            faculties[index] = new Faculty();
            return true;
        }

        private bool VerFaculty(int index)
        {
            if (index >= 0 && index < faculties.Count)
                return true;
            else
                return false;
        }

        public List<Faculty> GetFaculties()
        {
            return faculties;
        }
    }
}
