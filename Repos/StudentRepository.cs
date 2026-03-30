using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityMenuApp.Data;
using UniversityMenuApp.Models;

namespace UniversityMenuApp.Repos
{
    public class StudentRepository : IStudentRepository
    {
        private readonly SchoolDBContext _context;
        public StudentRepository(SchoolDBContext context)
        {
            _context = context;
        }
        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();

        }

        public IEnumerable<Student> GetStudents()
        {
            throw new NotImplementedException();
        }

        
    }
}