using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Interfaces
{
    public interface IDepartmentRepository
    {
        Department GetDepartment(int id); 
        IQueryable<Department> GetDepartmentDetails();
        Department PutDepartment(Department department);
        Department PostDepartment(Department department);
        bool DeleteDepartment(int id);
    }
}
