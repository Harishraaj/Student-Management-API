using StudentManagement.Interfaces;
using StudentManagement.Models;
using StudentManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;

namespace StudentManagement.Services
{
    public class StaffService : IStaffService
    {
        IStaffRepository _staffRepository;
        public StaffService(IStaffRepository staffRepository)
        {
            _staffRepository= staffRepository;
        }
        public Staff GetStaff(int id)
        {
            return _staffRepository.GetStaff(id);
        }
        public IQueryable<Staff> GetStaffDetails()
        {
            return _staffRepository.GetStaffDetails();
        }
        public Staff PostStaff(Staff staff)
        {
            return _staffRepository.PostStaff(staff);
        }
        public Staff PutStaff(Staff staff)
        {
            return _staffRepository.PutStaff(staff);
        }
        public bool DeleteStaff(int id)
        {
            return _staffRepository.DeleteStaff(id);
        }
    }


}