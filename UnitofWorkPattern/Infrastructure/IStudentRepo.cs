using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitofWorkPattern.Models;

namespace UnitofWorkPattern.Infrastructure
{
   public interface IStudentRepo
    {
        IList<Student> GetAll();
        Student GetById(int Id);
        void Insert(Student student);
        void Update(Student student);
        void Delete(Student student);

    }
}
