using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Circle
    {


         double Radius;

        

        public Circle (double Radius)
        {
            this.Radius = Radius;    
        }
       
        public double CalculateCircumference()   
        {    
            return Math.Round(Radius * 2 * Math.PI,2);
        }


        public double CalculateArea()
        {
            return Radius * Radius * Math.PI;
        }



       
       
        //public string CalculateFormattedCircumference()
      
        //public string CalculateFormattedArea()
        //private string FormatNumber (Number x)
        //Define a member called radius. This member should be private.
        //define a property to get access to the class member: Radius
    }
}
