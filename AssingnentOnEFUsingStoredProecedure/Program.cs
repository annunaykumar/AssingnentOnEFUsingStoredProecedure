using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssingnentOnEFUsingStoredProecedure
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            try
            {
                StudentDBEntities1 db = new StudentDBEntities1();
                //fetch all products
                List<AddStudent_Result> students = db.AddStudent().ToList();
                foreach (var item in students)
                {
                    Console.WriteLine($"Name:{item.Std_Name} Dateofbirth:{item.DOB} Degree:{item.Degree} job:{item.Jobtitle} company:{item.Company} Address:{item.Address_std} email:{item.Email} Studentid:{item.Std_id}");
                }
                Console.WriteLine();
                //get single record
                GetStudentById_Result student = db.GetStudentById("12").Single();
                Console.WriteLine($"Name:{student.Std_Name} Dateofbirth:{student.DOB} Degree:{student.Degree} job:{student.Jobtitle} company:{student.Company} Address:{student.Address_std} email:{student.Email} Studentid:{student.Std_id}");
                //Add new data
                db.AddStudent("36"); //add new product
              //  db.DeleteStudent("14"); //product with id 1 will removed

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
