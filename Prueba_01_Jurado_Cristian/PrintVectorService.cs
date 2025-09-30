
namespace Prueba_01_Jurado_Cristian; 

public class PrintVectorService
{
    //PRINCIPIO SRP: 
    public static void BGMQPrint(int[] vector)
    {
        int count = 0;
        do
        {
            Console.WriteLine(vector[count]);
            count++;
        }
        while (count < vector.Length);

    }
}
