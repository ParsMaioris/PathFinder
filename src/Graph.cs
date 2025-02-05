public class Graph
{
    private readonly Dictionary<int, List<Edge>> _adjList;


    public Graph()
    {
        _adjList = new Dictionary<int, List<Edge>>();
    }


    public void AddEdge(int source, int target, int cost)
    {
        if (!_adjList.ContainsKey(source))
            _adjList[source] = new List<Edge>();

        _adjList[source].Add(new Edge(target, cost));

        if (!_adjList.ContainsKey(target))
            _adjList[target] = new List<Edge>();
    }


    public List<int> TopologicalSort()
    {
        var visited = new HashSet<int>();
        var result = new List<int>();

        foreach (var node in _adjList.Keys)
        {
            if (!visited.Contains(node))
                DFS(node, visited, result);
        }

        result.Reverse();

        return result;
    }


    private void DFS(int node, HashSet<int> visited, List<int> result)
    {
        visited.Add(node);

        if (_adjList.TryGetValue(node, out var edges))
        {
            foreach (var edge in edges)
            {
                if (!visited.Contains(edge.Target))
                    DFS(edge.Target, visited, result);
            }
        }

        result.Add(node);
    }


    public int ShortestPath(int start, int destination)
    {
        var topoOrder = TopologicalSort();

        topoOrder.Reverse();

        var dp = new Dictionary<int, int>();

        foreach (var node in _adjList.Keys)
            dp[node] = int.MaxValue;

        dp[destination] = 0;

        foreach (var node in topoOrder)
        {
            if (_adjList.TryGetValue(node, out var edges))
            {
                foreach (var edge in edges)
                {
                    if (dp[edge.Target] != int.MaxValue)
                        dp[node] = Math.Min(dp[node], edge.Cost + dp[edge.Target]);
                }
            }
        }

        return dp[start];
    }
}