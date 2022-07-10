Linked_List_DataStructures.Linked_List list = new Linked_List_DataStructures.Linked_List();

Console.WriteLine("Enter how many values need to the list : ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine("\nEnter the data add to the list : ");
    int value = Convert.ToInt32(Console.ReadLine());
    list.Add(value);
    list.Display();
}