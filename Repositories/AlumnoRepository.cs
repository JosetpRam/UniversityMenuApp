using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityMenuApp.Models;

namespace UniversityMenuApp.Repositories
{
    public class AlumnoRepository : IAlumnoRepository
    {

        public List<Student> GetAll()
        {
            return new List<Student>
            {
                new Student { Id = 1, FullName = "David Benavides",  Email = "davben@gmail.com" },
                new Student { Id = 2, FullName = "Rita Lopez",       Email = "rita@gmail.com" },
                new Student { Id = 3, FullName = "Mario Herrera",    Email = "mario@gmail.com" },
            };
        }
    }
}
