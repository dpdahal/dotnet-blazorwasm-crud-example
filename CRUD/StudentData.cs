using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD.Models;

namespace CRUD
{
    public static class StudentData
    {

        private static List<Students> students = new (){
            new Students(){
                Id=1,
                Name="Sophia",
                Email="sophia@gmail.com",
                Phone="98798",
                Address="Kathmandu"
            },
            new Students(){
                Id=2,
                Name="Nandira",
                Email="nandira@gmail.com",
                Phone="98798",
                Address="Kathmandu"
            },
            new Students(){
                Id=3,
                Name="hari",
                Email="hari@gmail.com",
                Phone="98798",
                Address="Pokhara"
            }
        };

        public static Students[] GetStudents(){
            return students.ToArray();
        }

        public static void AddStudent(Students student){
            student.Id =students.Max(s => s.Id) + 1;
            students.Add(student);
        }

        public static Students GetStudent(int id){
            return students.Find(s => s.Id == id) ?? throw new Exception("Student not found");        
        }

        public static void UpdateStudent(Students student){
            Students existingStudent = students.Find(s => s.Id == student.Id) ?? throw new Exception("Student not found");
            existingStudent.Name = student.Name;
            existingStudent.Email = student.Email;
            existingStudent.Phone = student.Phone;
            existingStudent.Address = student.Address;
        }

        public static void DeleteStudent(int id){
            Students student = GetStudent(id);
            students.Remove(student);
        }

    }
}