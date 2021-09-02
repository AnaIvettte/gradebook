using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book libroCalificaciones = new Book("");
            libroCalificaciones.addGrade(89.1); //metodo no estatico
            libroCalificaciones.addGrade(99);
            libroCalificaciones.addGrade(100);
           // Book.addGrade();//si fuera estatico se manda a llamar así
           var stats = libroCalificaciones.GetStatistics();

           Console.WriteLine($"the lowest grade is {stats.Low}");
           Console.WriteLine($"the highest grade is {stats.High}");
           Console.WriteLine($"the average grade is {stats.Average}");
              
            


           
        }
    }
}
