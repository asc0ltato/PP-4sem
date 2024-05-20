using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Organization org = new Organization();

            org.PrintInfo();

            University university = new University();
            Department department = new Department("ISIT");
            Department department2 = new Department("POIT");
            Faculty faculty = new Faculty();

            faculty.AddDepartment(department);
            faculty.AddDepartment(department2);
            university.AddFaculty(faculty);

            for (int i = 0; i < university.GetFaculties().Count; i++)
            {
                Console.WriteLine("Факультетов: " + university.GetFaculties().Count);
            }

            Console.WriteLine("Специальностей:" + faculty.GetDepartments().Count);
            JobVacancy vacancy = new JobVacancy("Лектор");
            Person person = new Person("Гринюк");

            org.OpenJobVacancy(vacancy);
            Console.WriteLine("Открытые вакансии:" + org.PrintJobVacancies());
            Console.WriteLine($"{faculty.Recruit(vacancy, person).empName} назначен на роль {faculty.Recruit(vacancy, person).empVac}");
            org.CloseJobVacancy(0);

            Reason reason = new Reason("семейные обстоятельства");
            faculty.Dismiss(0, reason);
        }
    }
}