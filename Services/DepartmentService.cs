using StudentManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentManagement.Repository;
using StudentManagement.Models;
namespace StudentManagement.Services
{
    public class DepartmentService : IDepartmentService
    {
        IDepartmentRepository _departmentRepository;
        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }


        public Department GetDepartment(int id)
        {
            return _departmentRepository.GetDepartment(id);
        }
        public IQueryable<Department> GetDepartmentDetails()
        {
            return _departmentRepository.GetDepartmentDetails();
        }
        public Department PutDepartment(Department department)
        {
            return _departmentRepository.PutDepartment(department);
        }
        public Department PostDepartment(Department department)
        {
            return _departmentRepository.PostDepartment(department);
        }
        public bool DeleteDepartment(int id)
        {
            return _departmentRepository.DeleteDepartment(id);  
        }
    }
}