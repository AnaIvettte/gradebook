using System.Collections.Generic;
using System;
//using Statistics;
//DEFINIENDO UNA CLASE EN C#
//NOTA. Debe estar dentro de un namespace porque si no estará en el namespace global y puede tener conflicto con alguna librería de microsoft
//SOLO SE PERMITE UNA CLASE POR ARCHIVO
//UNA CLASE CONSISTE EN 2 COSAS: ESTADO O DATOS Y COMPORTAMIENTO (QUE ACTUA EN EL ESTADO)


namespace GradeBook
{
    public class Book
    {
        //FIELD C#: Un campo es una variable de cualquier tipo que se declara directamente en una clase o struct
        //es una pieza de estado del objeto que llevará consigo el resto de su vida útil
        //cualquier metodo tiene acceso al campo
        

        //inicialización de variables
        //el constructor construye objetos del tipo Book en este caso

       /* Modificadores de acceso
Public: todo el código fuera de esta clase puede tener acceso al miembro
PRIVADO: solo es accsible por el código de la clase.*/
private List <double> listaCalificaciones;//FIELD NO USA var
public string Name;
        public Book(String name){
            listaCalificaciones=new List<double>();
            this.Name=name;
        }
        

        //DECLARACION DE METODOS
        public void addGrade (double calificacionAdd){
            this.listaCalificaciones.Add(calificacionAdd);
        }

        public  Statistics GetStatistics (){
            var result = new Statistics();
            result.Average=0.0;
            result.High= double.MinValue;
            result.Low= double.MaxValue;
           
                   
            foreach (var grade in listaCalificaciones){
             result.High=Math.Max(grade, result.High);
             result.Low=Math.Min(grade, result.Low);
             
                result.Average+=grade;
            }
            result.Average /=listaCalificaciones.Count;
            return result;
        }
    

    }
}
