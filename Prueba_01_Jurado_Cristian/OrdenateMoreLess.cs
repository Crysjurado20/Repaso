using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_01_Jurado_Cristian
{
    public class OrdenateMoreLess : IOrdenateVector
    {   
        //Principio OPEN/CLOSE: una clase concreta que implementa una interfaz. 
        int[] IOrdenateVector.Ordenate(int[] originalVector, int[] indexVector)
        {
            int[] ordeningVector = new int[originalVector.Length];
            int count = 0;
            do
            {
                ordeningVector[count] = originalVector[indexVector[count]];
                count++;
            } while (count < indexVector.Length);
            return ordeningVector;
        }
    }
}
