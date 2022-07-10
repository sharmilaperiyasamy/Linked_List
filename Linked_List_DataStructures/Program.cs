Linked_List_DataStructures.Linked_List list = new Linked_List_DataStructures.Linked_List();

Console.WriteLine("\nLinkedList Operations:\n0.Exit\n1.Adding data to the list\n2.Display the data in the list\n3.Append the data\nEnter your choice:");
int option = Convert.ToInt32(Console.ReadLine());
while (option != 0)
{
    switch (option)
    {
        case 1:
            Console.WriteLine("Enter the data to add to the list : ");
            int data = Convert.ToInt32(Console.ReadLine());
            list.Add(data);
            break;
        case 2:
            list.Display();
            break;
        case 3:
            Console.WriteLine("Enter data to append.");
            int value = Convert.ToInt32(Console.ReadLine());
            list.Append(value);
            break;
        default:
            Console.WriteLine("Invalid option.");
            break;
    }
    Console.WriteLine("\nLinkedList Operations:\n0.Exit\n1.Adding data to the list\n2.Display the data in the list\n3.Append the data\nEnter your choice:");
    option = Convert.ToInt32(Console.ReadLine());
}