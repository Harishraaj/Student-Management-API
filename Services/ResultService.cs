using StudentManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using StudentManagement.Repository;
using StudentManagement.Models;

namespace StudentManagement.Services
{
    public class ResultService : IResultService
    {
        IResultRepository _resultRepository;
        public ResultService(IResultRepository resultRepository)
        {
            _resultRepository= resultRepository;
        }
        public Result GetResult(int id)
        {
            return _resultRepository.GetResult(id);
        }
        public IQueryable<Result> GetResultDetails()
        {
            return _resultRepository.GetResultDetails();
        }
        public bool DeleteResult(int id)
        {
            return _resultRepository.DeleteResult(id);
        }
        public Result PostResult(Result result)
        {
            return _resultRepository.PostResult(result);
        }
        public Result PutResult( Result result)
        {
            return _resultRepository.PutResult(result);
        }
    }
}