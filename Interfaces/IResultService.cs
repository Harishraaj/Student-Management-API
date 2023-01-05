using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Interfaces
{
    public interface IResultService
    {
        IQueryable<Result> GetResultDetails();
        Result GetResult(int id);
        bool DeleteResult(int id);
        Result PostResult(Result result);
        Result PutResult(Result result);
    }
}
