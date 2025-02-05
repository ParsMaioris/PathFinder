public class Edge
{
    public int Target { get; }
    public int Cost { get; }


    public Edge(int target, int cost)
    {
        Target = target;
        Cost = cost;
    }
}