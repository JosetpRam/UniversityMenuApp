using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityMenuApp.Models;

namespace UniversityMenuApp.Repositories
{
    public class MateriaRepository : IMateriaRepository
    {
        public List<Subject> GetAll()
        {
            return new List<Subject>
            {
                new Subject { Id = 1, Name = "Matemáticas" },
                new Subject { Id = 2, Name = "Proogramacion" },
                new Subject { Id = 3, Name = "Base de Datos" },
            };
        }
    }
}
