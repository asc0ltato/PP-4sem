using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Faculty : Organization, IStaff
    {
        protected List<Department> departments;

        public Faculty()
        {
            departments = new List<Department>();
        }

        public Faculty(Faculty university)
        {
            departments = university.departments;
            Name = university.Name;
            ShortName = university.ShortName;
            Address = university.Address;
            TimeStamp = university.TimeStamp;
        }

        public Faculty(int id, string name, string shortName, string address, DateTime timeStamp) : base(id, name, shortName, address, timeStamp)
        {
        }

        public int AddDepartment(Department department)
        {
            departments.Add(department);
            return departments.IndexOf(department);
        }

        public bool DelDepartment(int index)
        {
            if (VerDepartment(index))
            {
                departments.RemoveAt(index);
                return true;
            }
            else
                return false;
        }

        public bool UpdateDepartment(Department department)
        {
            if (!departments.Contains(department))
                return false;

            int index = departments.IndexOf(department);

            departments[index] = new Department("Алексей");
            return true;
        }

        private bool VerDepartment(int index)
        {
            if (index >= 0 && index < departments.Count)
                return true;
            else
                return false;
        }

        public List<Department> GetDepartments()
        {
            return departments;
        }
    }
}
