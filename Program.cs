public class Program
{
    public static void Main()
    {
        Console.WriteLine("\n# Start Clock App:");
        Clock clock = new Clock();
        clock.startClock();
        /*
            Enter hours between 1 and 12: 3
            Enter minutes between 0 and 59: 35
            !^^^^^^^^^^^^^^^^^!
            !       12        !
            !                 !
            !                 !
            !                 !
            ! 9      O----- 3 !
            !       /         !
            !      /          !
            !     /           !
            !        6        !
            !_________________!
            Time: 03:35
            Lesser Angle: 102.5°

            Enter hours between 1 and 12: 6
            Enter minutes between 0 and 59: 10
            !^^^^^^^^^^^^^^^^^!
            !       12        !
            !           /     !
            !          /      !
            !         /       !
            ! 9      O      3 !
            !        |        !
            !        |        !
            !        |        !
            !        6        !
            !_________________!
            Time: 06:10
            Lesser Angle: 125°
        */

        Console.WriteLine("\n# Create Branch Objects:");
        Branch root = new Branch(0); // Branch 0 created
        Branch node1 = new Branch(1); // Branch 1 created
        Branch node2 = new Branch(2); // Branch 2 created
        Branch node3 = new Branch(3); // Branch 3 created
        Branch node4 = new Branch(4); // Branch 4 created
        Branch node5 = new Branch(5); // Branch 5 created
        Branch node6 = new Branch(6); // Branch 6 created
        Branch node7 = new Branch(7); // Branch 7 created
        Branch node8 = new Branch(8); // Branch 8 created
        Branch node9 = new Branch(9); // Branch 9 created
        Branch node10 = new Branch(10); // Branch 10 created

        Console.WriteLine("\n# Create Object Structure:");
        root.addBranch(node1); // Branch 1 added to --> 0
        node1.addBranch(node2); // Branch 2 added to --> 1  
        root.addBranch(node3); // Branch 3 added to --> 0 
        node3.addBranch(node4); // Branch 4 added to --> 3
        node4.addBranch(node5); // Branch 5 added to --> 4
        node3.addBranch(node6); // Branch 6 added to --> 3
        node6.addBranch(node7);// Branch 7 added to --> 6
        node7.addBranch(node8); // Branch 8 added to --> 7
        node6.addBranch(node9); // Branch 9 added to --> 6
        node3.addBranch(node10); // Branch 10 added to --> 3  

        Console.WriteLine("\n# Draw Structure Paths:");
        root.drawPaths();
        /*
            (0 --> 1 --> 2)
            (0 --> 3 --> 4 --> 5)
            (0 --> 3 --> 6 --> 7 --> 8)
            (0 --> 3 --> 6 --> 9)
            (0 --> 3 --> 10)
        */

        Console.WriteLine("\n# Find Node:");
        root.findBranch(8); // Branch 8 found: (0 --> 3 --> 6 --> 7 --> 8)

        Console.WriteLine("\n# Count Depth:");
        root.countDepth(); // Structure Depth: 5

        Console.WriteLine("\n# Count Branches:");
        root.countBranches(); // Node count: 11
    }
}