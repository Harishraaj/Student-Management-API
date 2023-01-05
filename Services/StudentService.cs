using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentManagement.Interfaces;
using StudentManagement.Models;
using StudentManagement.Repository;
namespace StudentManagement.Services
{
    public class StudentService : IStudentService
    {
        IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public Student GetStudent(int id) 
        {
            var result=_studentRepository.GetStudent(id);
            return result; 
        }
        public IQueryable<Student> GetStudentDetails()
        {
            var result = _studentRepository.GetStudentDetails();
            return result;
        }
       public Student PostStudent(Student student)
        {
            return _studentRepository.PostStudent(student);
        }
        public bool DeleteStudent(int id)
        {
            return _studentRepository.DeleteStudent(id);
        }
        public Student PutStudent(Student student)
        { 
            return _studentRepository.PutStudent(student);
        }
    }
}