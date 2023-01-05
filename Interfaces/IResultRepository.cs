using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace StudentManagement.Interfaces
{
    public interface IResultRepository
    {
        IQueryable<Result> GetResultDetails();
        Result GetResult(int id);
        bool DeleteResult(int id);
        Result PostResult(Result result);
        Result PutResult(Result result);
    }
}
