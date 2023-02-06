namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string number, string model, string imei, int memory) : base(number, model, imei, memory)
        {
        }

        public override void InstallApp(string nameApp)
        {
            for(int i = 3; i > 0; i--) {
                Thread.Sleep(1000);
                Console.WriteLine($"Installing {nameApp} in {i}...");
            }

            Console.WriteLine($"{nameApp} instaled successfully!");
            Console.WriteLine("Now I'm low battery!");
        }
    }
}