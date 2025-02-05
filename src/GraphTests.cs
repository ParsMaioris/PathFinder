[TestClass]
public class GraphTests
{


    [TestMethod]
    public void TestShortestPath()
    {
        var graph = new Graph();

        graph.AddEdge(1, 2, 3);
        graph.AddEdge(1, 4, 4);
        graph.AddEdge(2, 3, 2);
        graph.AddEdge(3, 5, 3);
        graph.AddEdge(3, 6, 5);
        graph.AddEdge(4, 2, 1);
        graph.AddEdge(4, 5, 1);
        graph.AddEdge(5, 6, 2);

        var result = graph.ShortestPath(1, 6);

        Assert.AreEqual(7, result);
    }


    [TestMethod]
    public void TestDirectPath()
    {
        var graph = new Graph();

        graph.AddEdge(1, 2, 5);

        var result = graph.ShortestPath(1, 2);

        Assert.AreEqual(5, result);
    }


    [TestMethod]
    public void TestSameNode()
    {
        var graph = new Graph();

        graph.AddEdge(1, 2, 5);

        var result = graph.ShortestPath(2, 2);

        Assert.AreEqual(0, result);
    }


    [TestMethod]
    public void TestNoPath()
    {
        var graph = new Graph();

        graph.AddEdge(1, 2, 5);
        graph.AddEdge(3, 4, 10);

        var result = graph.ShortestPath(1, 4);

        Assert.AreEqual(int.MaxValue, result);
    }
}