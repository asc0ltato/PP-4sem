using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab2
{
    public class Organization : IStaff
    {
        List<JobVacancy> vacancy = new List<JobVacancy>();
        List<Emploee> employees = new List<Emploee>();
        List<JobTitle> jobTitles = new List<JobTitle>();
        public int Id { get; private set; }
        public string Name { get; protected set; }
        public string ShortName { get; protected set; }
        public string Address { get; protected set; }
        public DateTime TimeStamp { get; protected set; }

        public Organization()
        {
            Id = 1;
            Name = "Белорусский Государственный Технологический Университет";
            ShortName = "БГТУ";
            Address = "Минск";
            TimeStamp = DateTime.Now;
        }

        public Organization(Organization organization)
        {
            Id = organization.Id;
            Name = organization.Name;
            ShortName = organization.ShortName;
            Address = organization.Address;
            TimeStamp = organization.TimeStamp;
        }

        public Organization(int id, string name, string shortName, string address,DateTime timeStamp)
        {
            Id = id;
            Name = name;
            ShortName = shortName;
            Address = address;
            TimeStamp = timeStamp;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"ID: {Id} Name: {Name} ShortName: {ShortName} Address: {Address} Time: {TimeStamp}\n");
        }

        public List<JobVacancy> GetJobVacancies()
        {
            return vacancy;
        }

        public List<Emploee> GetEmploees()
        {
            return employees;
        }

        public List<JobTitle> GetJobTitles()
        {
            return jobTitles;
        }

        public int OpenJobVacancy(JobVacancy jobVacancy)
        {
            vacancy.Add(jobVacancy);
            return vacancy.Count - 1;
        }

        public bool CloseJobVacancy(int index)
        {
            if (vacancy[index] != null)
            {
                vacancy.RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
        }

        public int AddJobTitle(JobTitle jobTitle)
        {
            jobTitles.Add(jobTitle);
            return 0;
        }

        public bool DelJobTitle(int index)
        {
            if (jobTitles[index] != null)
            {
                jobTitles.RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string PrintJobVacancies()
        {
            StringBuilder sb = new StringBuilder();
            if (vacancy.Count > 0)
            {
                foreach (JobVacancy jobVacancy in vacancy)
                {
                    sb.AppendLine(jobVacancy.vacansy);
                }
            }
            else
            {
                sb.AppendLine("Ничего");
            }
            return sb.ToString();
        }

        public Emploee Recruit(JobVacancy vacancy, Person person)
        {
            Emploee emp = new Emploee(person.PersonName, vacancy.vacansy);
            employees.Add(emp);
            return emp;
        }

        public bool Dismiss(int index, Reason reason)
        {
            if (employees[index] != null)
            {
                Console.WriteLine($"Сотрудник {employees[index].empName} уволен по причине: {reason.Text}");
                employees.RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
