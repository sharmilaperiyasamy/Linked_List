Linked_List_DataStructures.Linked_List list = new Linked_List_DataStructures.Linked_List();

Console.WriteLine("\nLinkedList Operations:\n0.Exit\n1.Adding data to the list\n2.Display the data in the list\n3.Append the data\n4.insert the data\nEnter your choice:");
int option = Convert.ToInt32(Console.ReadLine());
while (option != 0)
{
    switch (option)
    {
        case 1:
            string a = "";
            while (a != "n")
            {
                Console.WriteLine("Enter the data to add to the list : ");
                int data = Convert.ToInt32(Console.ReadLine());
                list.Add(data);
                Console.WriteLine("Do you want to add more data Y/N:");
                a = Console.ReadLine();
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

        default:
            Console.WriteLine("Invalid option.");
            break;
    }
    Console.WriteLine("\nLinkedList Operations:\n0.Exit\n1.Adding data to the list\n2.Display the data in the list\n3.Append the data\n4.insert the data\nEnter your choice:");
    option = Convert.ToInt32(Console.ReadLine());
}