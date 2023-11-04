using System;
using System.Threading.Tasks;

namespace BreakfastAsync
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting breakfast preparation...");

            // Step 1: Heat the pan
            await HeatThePan();

            // Step 2: Fry eggs, fry bacon, toast bread
            Task eggsTask = FryEggs();
            Task baconTask = FryBacon();
            Task toastTask = ToastBread();
            await Task.WhenAll(eggsTask, baconTask, toastTask);

            // Step 3: Butter the bread (waits for toast to finish)
            await ButterTheBread();

            // Step 4: Pour juice
            PourJuice();

            Console.WriteLine("Breakfast is ready!");
        }

        static async Task HeatThePan()
        {
            Console.WriteLine("Heating the pan...");
            await Task.Delay(7000);
            Console.WriteLine("Pan is hot!");
        }

        static async Task FryEggs()
        {
            Console.WriteLine("Frying eggs...");
            await Task.Delay(5000);
            Console.WriteLine("Eggs are ready!");
        }

        static async Task FryBacon()
        {
            Console.WriteLine("Frying bacon...");
            await Task.Delay(6000);
            Console.WriteLine("Bacon is ready!");
        }

        static async Task ToastBread()
        {
            Console.WriteLine("Toasting bread...");
            await Task.Delay(3000);
            Console.WriteLine("Bread is toasted!");
        }

        static async Task ButterTheBread()
        {
            Console.WriteLine("Buttering the bread...");
            await Task.Delay(2000);
            Console.WriteLine("Bread is buttered!");
        }

        static void PourJuice()
        {
            Console.WriteLine("Pouring juice...");
            Console.WriteLine("Juice is ready!");
        }
    }
}
