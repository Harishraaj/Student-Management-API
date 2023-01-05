using StudentManagement.Data;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Description;
using System.Web.Http;
using StudentManagement.Interfaces;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Net;

namespace StudentManagement.Repository
{
    public class ResultRepository:ApiController,IResultRepository
    {
        private StudentManagementContext db = new StudentManagementContext();

        // GET: api/Result
        public IQueryable<Result> GetResultDetails()
        {
            return db.Results;
        }

        // GET: api/Result/5
        [ResponseType(typeof(Result))]
        public Result GetResult(int id)
        {
            Result result = db.Results.Find(id);
            if (result == null)
            {
                throw new Exception("Result not found");
            }

            return result;
        }
        // PUT: api/Result/5
        [ResponseType(typeof(void))]
        public Result PutResult(Result result)
        {
            if (!ModelState.IsValid)
            {
                throw new Exception("Invalid Data");
            }
            if (result.ResultId<=0)
            {
                throw new Exception("Invalid Result Id");
            }
            db.Entry(result).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResultExists(result.ResultId))
                {
                    throw new Exception("Result not found");
                }
                else
                {
                    throw;
                }
            }

            return result;
        }

        // POST: api/Result
        [ResponseType(typeof(Result))]
        public Result PostResult(Result result)
        {
            if (!ModelState.IsValid)
            {
                throw new Exception("bad request");
            }
            try
            {
                db.Results.Add(result);
                db.SaveChanges();
                return result;
            }
            catch
            {
                throw new Exception("Unable to send post request");
            }
            
        }

        // DELETE: api/Result/5
        [ResponseType(typeof(Result))]
        public bool DeleteResult(int id)
        {
            Result result = db.Results.Find(id);
            if (result == null)
            {
                throw new Exception("Result not found");
            }

            db.Results.Remove(result);
            db.SaveChanges();

            return true;
        }
      
        private bool ResultExists(int id)
        {
            return db.Results.Count(e => e.ResultId == id) > 0;
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}