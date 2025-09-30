namespace Prueba_01_Jurado_Cristian; 

public class CalculateIndexVectorService
{
    //Se emplea el principio de responsabilidad unica, solo se encarga de generar el vector
    //de indices
    private static int[] fillVector(int size)
    {
        int count = 0;
        int[] vector = new int[size];
        do
        {
            vector[count] = count;
            count++;
        }
        while (count < vector.Length);

        return vector;
    }

    public static int[] CalculateIndexVector(int[] vector)
    {
        var elementsNumber = vector.Length;
        var ans = fillVector(elementsNumber);

        int i = 0;


        do
        {
            int j = i + 1;
            do
            {

                if (vector[ans[i]] < vector[ans[j]])
                {
                    var tmp = ans[j];
                    ans[j] = ans[i];
                    ans[i] = tmp;
                }
                j++;
            } while (j < elementsNumber);
            i++;
        } while (i < elementsNumber - 1);

        return ans;
    }


}
