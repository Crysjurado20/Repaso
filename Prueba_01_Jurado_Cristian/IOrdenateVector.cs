namespace Prueba_01_Jurado_Cristian; 

public interface IOrdenateVector
{
    //PRINCIPIO OCP: cada implementacion de la interfaz puede tener su propia forma de ordenar.
    int[] Ordenate(int[] originalVector, int[] indexVector);
}
