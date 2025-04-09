using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
var todoList = new List<TodoItem>();
Console.WriteLine(value:"Willkommen beim Todoinator!");
while (true)   
{
    foreach(var item in todoList)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine(value:"""
    1.Neues Todo
    2.Todo abhaken
    """);
    var userMenuChoice= Console.ReadLine();
    switch (userMenuChoice)
    {
        case "1":
            //Todo erstelllen
            Console.WriteLine("Was ist das Todo?");
            var todoDescription = Console.ReadLine();
            Console.WriteLine("""
            Wie wichtig? 
            1 => Hohe Prio
            2 => Normale Prio
            3 => Niedrige Prio
            """);
            var todoPrio = Console.ReadLine();
            var newTodo = new TodoItem();
            newTodo.Description= todoDescription;
            newTodo.Prio = Convert.ToInt32 (todoPrio);
            todoList.Add(newTodo);
            break;
        case "2":
            //Todo abhaken
            System.Console.WriteLine("WElches Todo möchteset du löschen?");
            var indexToDelete = Convert.ToInt32(Console.ReadLine());
            todoList.RemoveAt(indexToDelete);
            break;
        default:
            //Nicht definierter Input eg. "hamester"
            break;

    }
    Console.Clear();
}