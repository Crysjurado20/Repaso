namespace Prueba_01_Jurado_Cristian
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuantos datos tiene el vector?");
            var numberOfElements = Console.ReadLine();
            int numberOfElementsAsNumber = int.Parse(numberOfElements);
            int[] vector = EnterElementsInVectorService.EnterElementsInVector(numberOfElementsAsNumber);
            int[] indexVector = CalculateIndexVectorService.CalculateIndexVector(vector);

            IOrdenateVector ordenatorMoreLess = new OrdenateMoreLess();

            OrdenateVectorService service = new OrdenateVectorService(ordenatorMoreLess);

            Console.WriteLine("\nVector original\n");

            PrintVectorService.BGMQPrint(vector);

            Console.WriteLine("\nVector de indices\n");

            var vectorIndices = CalculateIndexVectorService.CalculateIndexVector(vector);

            PrintVectorService.BGMQPrint(vectorIndices);
            Console.WriteLine("\nVector ordenado en base al vector de  indices ordenado\n");

            int[] ordeningIndexVector = service.BGMQOrdenate(vector, indexVector);
            PrintVectorService.BGMQPrint(service.BGMQOrdenate(vector, vectorIndices));
        }
    }
}
