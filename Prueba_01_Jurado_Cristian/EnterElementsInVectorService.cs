
namespace Prueba_01_Jurado_Cristian; 

public class EnterElementsInVectorService
{
    //Se emplea el principio de responsabilidad unica, solo se encarga de generar el vector original
    public static int[] EnterElementsInVector(int numberOfElements)
    {
        bool vectorIsComplete = false;
        int[] vector = new int[numberOfElements];
        int count = 0;
        do
        {
            Console.WriteLine("Ingrese el elemento #" + count);
            var element = Console.ReadLine();
            vector[count] = int.Parse(element);
            count++;

            if (count > numberOfElements - 1)
            {
                vectorIsComplete = true;
            }

        }
        while (!vectorIsComplete);
        return vector;
    }

}
