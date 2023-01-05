using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using StudentManagement.Data;
using StudentManagement.Models;
using StudentManagement.Services;

namespace StudentManagement.Controllers
{
    public class ResultController : ApiController
    {
        ResultService _resultService;
        public ResultController(ResultService resultService)
        {
            _resultService = resultService;
        }


        // GET: api/Result
        public IQueryable<Result> GetResultDetails()
        {
            return _resultService.GetResultDetails();
        }

        // GET: api/Result/5
        [ResponseType(typeof(Result))]
        public Result GetResult(int id)
        {
            return _resultService.GetResult(id);
        }

        // PUT: api/Result/5
        [ResponseType(typeof(void))]
        public Result PutResult(Result result)
        {
            return _resultService.PutResult(result);
        }

        // POST: api/Result
        [ResponseType(typeof(Result))]
        public Result PostResult(Result result)
        {
            return _resultService.PostResult(result);
        }

        // DELETE: api/Result/5
        [ResponseType(typeof(Result))]
        public bool DeleteResult(int id)
        {
            return _resultService.DeleteResult(id); 
        }
    }
}