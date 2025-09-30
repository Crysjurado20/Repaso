using System.Runtime.Intrinsics.Arm;

namespace Prueba_01_Jurado_Cristian; 

public class OrdenateVectorService
     //Se emplea el principio DIP debido a que se utiliza una interfaz para la inyección de dependencias
{
    private readonly IOrdenateVector _ordenator;

    public OrdenateVectorService(IOrdenateVector ordenator)
    {

        _ordenator = ordenator;

    }
    public int[] BGMQOrdenate(int[] vector, int[] indexVector)
    {


        return _ordenator.Ordenate(vector, indexVector);

    }

}
