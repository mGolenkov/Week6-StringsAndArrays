using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab, mis juhtub kasutaja homme (kasutame Random klassi)

            string[] predictions = { "win a million", "fall in love", "buy YouTube premium", "join the darkside for cookies" };
            
            Random rnd = new Random();
            int userFuture = rnd.Next(0, predictions.Length);

            Console.WriteLine($"Tommorrow you will {predictions[userFuture]}. ");
        }
    }
}
