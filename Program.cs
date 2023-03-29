public class PrimeTree
{


    public static void Main()
    {
        // Initate Linked List
        LinkedList<String> directory = new LinkedList<String>();
        // Create a while loop to enter the rest of the names into the directory
        var input = 9999;
        while (input != 0)
        {
            var newName = "";
            Console.WriteLine("Directory Menu:");
            Console.WriteLine("0. Quit Program");
            Console.WriteLine("1. Enter Name in Front");
            Console.WriteLine("2. Enter Name Before");
            Console.WriteLine("3. Enter Name After");
            Console.WriteLine("4. Enter Name at the End");
            Console.WriteLine("5. Remove a Name");
            Console.WriteLine("6. View Directory");
            Console.WriteLine("Your choice: ");
            input = Convert.ToInt32(Console.ReadLine());
            
            switch (input)
            {
                case 1:
                    Console.WriteLine("Enter the name to add: ");
                    newName = Console.ReadLine();
                    directory.AddFirst(newName);
                    break;
                case 2:
                    Console.WriteLine("Enter the name to add: ");
                    newName = Console.ReadLine();
                    Console.WriteLine("Enter the name you want to add the new name in front of:");
                    string name2 = Console.ReadLine();
                    Node newNode = new Node(name2);
                     var node2 = directory.Find(name2);
                    directory.AddBefore(node2, newName);
                    break;
                case 3: 
                    Console.WriteLine("Enter the name to add: ");
                    newName = Console.ReadLine();
                    Console.WriteLine("Enter the name you want to add the new name behind of: ");
                    string name3 = Console.ReadLine();
                    Node newNode2 = new Node(name3);
                    var node3 = directory.Find(name3);
                    directory.AddAfter(node3, newName);
                    break;
                case 4:
                    Console.WriteLine("Enter the name to add: ");
                    newName = Console.ReadLine();
                    directory.AddLast(newName);
                    break;
                case 5:
                    Console.WriteLine("Enter the name you want to delete: ");
                    string name4 = Console.ReadLine();
                    Node newNode3 = new Node(name4);
                    var node4 = directory.Find(name4);
                    directory.Remove(node4);
                    break;
                case 6:
                    foreach (var name in directory)
                        Console.WriteLine(name);
                    break;
                    

                    
            }



        }

    }
}
public class Node 
{
    public string Data { get; set; }
    public Node? Next { get; set; }
    public Node? Prev { get; set; }

    public Node(string data) 
    {
        this.Data = data;
    }
}
