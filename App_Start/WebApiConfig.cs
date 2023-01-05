using StudentManagement.Interfaces;
using StudentManagement.Repository;
using StudentManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using Unity;

namespace StudentManagement
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            EnableCorsAttribute cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);
            // Web API configuration and services
            var container = new UnityContainer();
            container.RegisterType<IDepartmentRepository, DepartmentRepository>();
            container.RegisterType<IStudentRepository, StudentRepository>();
            container.RegisterType<ICourseRepository, CourseRepository>();
            container.RegisterType<IStaff_X_CourseRepository, Staff_X_CourseRepository>();
            container.RegisterType<IStaffRepository, StaffRepository>();
            container.RegisterType<IStudent_X_CourseRepository, Student_X_CourseRepository>();
            container.RegisterType<IStudentRepository, StudentRepository>();
            container.RegisterType<IResultRepository, ResultRepository>();

            container.RegisterType<IDepartmentService, DepartmentService>();
            container.RegisterType<ICourseService, CourseService>();
            container.RegisterType<IStaff_X_CourseService, Staff_X_CourseService>();
            container.RegisterType<IStaffService, StaffService>();
            container.RegisterType<IStudent_X_CourseService, Student_X_CourseService>();
            container.RegisterType<IStudentService, StudentService>();
            container.RegisterType<IResultService,ResultService>();

            config.DependencyResolver = new UnityResolver(container);
            

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
