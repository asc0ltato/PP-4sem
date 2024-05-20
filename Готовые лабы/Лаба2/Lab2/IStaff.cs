using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    interface IStaff
    {
        List<JobVacancy> GetJobVacancies();
        List<Emploee> GetEmploees();
        List<JobTitle> GetJobTitles();
        int AddJobTitle(JobTitle jobTitle);
        string PrintJobVacancies();
        bool DelJobTitle(int index);
        int OpenJobVacancy(JobVacancy jobVacancy);
        bool CloseJobVacancy(int index);
        Emploee Recruit(JobVacancy job, Person person);
        bool Dismiss(int index, Reason reason);
    }
}
