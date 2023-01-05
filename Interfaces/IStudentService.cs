using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Interfaces
{
    public interface IStudentService
    {
        Student GetStudent(int id);
        IQueryable<Student> GetStudentDetails();
        Student PostStudent(Student student);
        bool DeleteStudent(int id);
        Student PutStudent(Student student);
    }
}
