using ActressMas;

namespace AuctionAlgorithms.Agents.ProsumerAgent;

public class ProsumerAgent: Agent
{
    public int prosumerId = 0;
    
    public ProsumerAgent() : base(){}

    public override void Setup()
    {
        prosumerId = Int32.Parse(this.Name.Remove(0, 8));
        Console.WriteLine($"[{this.Name} {this.prosumerId}] Setup!");
    }
}