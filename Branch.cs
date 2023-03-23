public class Branch
{
    private List<Branch> branches = new List<Branch>();
    private int selfNum;
    public Branch(int num){
        selfNum = num;
        Console.WriteLine($"Branch {selfNum} created");
    }
    public void addBranch(Branch newBranch) {
        branches.Add(newBranch);
        Console.WriteLine($"Branch {newBranch.getNum()} added to --> {selfNum}");
    }
    public int getNum() {
        return selfNum;
    }
    public void findBranch(int num, List<int>? nodes = null) {
        if(nodes == null) nodes = new List<int>();
        foreach(Branch b in branches) {
            nodes.Add(selfNum);
            if(b.getNum() == num) {
                Console.Write($"Branch {num} found: (");
                foreach (int i in nodes) Console.Write($"{i} --> ");
                Console.WriteLine($"{num})");
            }
            b.findBranch(num, nodes);
            nodes.RemoveAt(nodes.Count - 1);
        }
    }
    public void countDepth() {
        List<int> nodes = traverseNodes();
        Console.WriteLine($"Structure Depth: {nodes.Max()}");
    }
    public void countBranches() {
        List<int> nodes = traverseNodes();
        Console.WriteLine($"Node count: {nodes.Count}");
    }
    private List<int> traverseNodes(int count = 1, List<int>? nodes = null) {
        if(nodes == null) nodes = new List<int>();
        nodes.Add(count);
        foreach(Branch b in branches) b.traverseNodes(count + 1, nodes);
    
        return nodes;
    }
    public void drawPaths(List<int>? nodes = null) {
        if(nodes == null) nodes = new List<int>();
        foreach(Branch b in branches) {
            int num = b.getNum();
            nodes.Add(selfNum);
            if(b.branches.Count == 0) {
            Console.Write($"(");
            foreach (int i in nodes) Console.Write($"{i} --> ");
            Console.WriteLine($"{num})");
                
            }
            b.drawPaths(nodes);
            nodes.RemoveAt(nodes.Count - 1);
        }
    }
}



