Linked_List_DataStructures.Linked_List list = new Linked_List_DataStructures.Linked_List();

Console.WriteLine("\nLinkedList Operations:\n0.Exit\n1.Adding data to the list\n2.Display the data in the list\n3.Append the data\n4.insert the data\n5.Delete the data at first position\nEnter your choice:");
int option = Convert.ToInt32(Console.ReadLine());
while (option != 0)
{
    switch (option)
    {
        case 1:
            Console.WriteLine("Enter how many want to add to the linked list : ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                Console.WriteLine("Enter the data to add to the list : ");
                int data = Convert.ToInt32(Console.ReadLine());
                list.Add(data);
                n--;
            }
            break;
        case 2:
            list.Display();
            break;
        case 3:
            Console.WriteLine("Enter data to append.");
            int value = Convert.ToInt32(Console.ReadLine());
            list.Append(value);
            break;
        case 4:
            Console.WriteLine("Enter data to append.");
            int element = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the position where the data to insert : ");
            int position = Convert.ToInt32(Console.ReadLine());
            list.InsertAtPosition(position, element);
            break;
        case 5:
            list.Delete();
            break;
        default:
            Console.WriteLine("Invalid option.");
            break;
    }
    Console.WriteLine("\nLinkedList Operations:\n0.Exit\n1.Adding data to the list\n2.Display the data in the list\n3.Append the data\n4.insert the data\n5.Delete the data at first position\nEnter your choice:");
    option = Convert.ToInt32(Console.ReadLine());
}