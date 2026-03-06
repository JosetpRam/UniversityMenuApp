using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityMenuApp.Models;

namespace UniversityMenuApp.Repositories
{
    public class SubjectRepository : ISubjectRepository
    {
        

        public IEnumerable<Subject> GetSubjects()
        {
            return new List<Subject>
        {
            new() { Id = 1, Name = "Matemáticas" },
            new() { Id = 2, Name = "Programación I" },
            new() { Id = 3, Name = "Base de Datos" },
            new() { Id = 4, Name = "Estructuras de Datos" },
        };
        }
    }
}
