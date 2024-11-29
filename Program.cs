using AuctionAlgorithms.Agents.ProsumerAgent;

namespace AuctionAlgorithms;
using ActressMas;

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("whatever");
        var world = new EnvironmentMas(0, Utils.Delay);

        for (int i = 0; i < Utils.NumberOfProsumers; i++)
        {
            var agent = new ProsumerAgent();
            world.Add(agent, $"prosumer{i}");
        }
        
        world.Start();
    }
}