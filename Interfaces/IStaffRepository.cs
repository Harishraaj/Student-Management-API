using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace StudentManagement.Interfaces
{
    public interface IStaffRepository
    {
        Staff GetStaff(int id);
        IQueryable<Staff> GetStaffDetails();
        Staff PostStaff(Staff staff);
        Staff PutStaff(Staff staff);
        bool DeleteStaff(int id);
    }
}
