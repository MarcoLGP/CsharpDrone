namespace ConsoleApp1
{
    public class ConsoleApp1
    {
        public static void Main(string[] args)
        {
            Drone d1 = new Drone();
            d1.AumentarVelocidade();
            Console.WriteLine(d1.Velocidade);
        }
    }
}