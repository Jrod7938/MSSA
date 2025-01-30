namespace W3D3C2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ToDo> todoList = new List<ToDo>();
            todoList.Add(new ToDo() { TaskId = 1, Description = "Study For Test", EstimatedHours = 1.5f ,TaskStatus = Status.NotStarted});

            ToDo myTodo = new ToDo();
            myTodo.TaskId = 2;
            myTodo.Description = "Do Challenge Labs";
            myTodo.EstimatedHours = 3.5f;
            myTodo.TaskStatus = Status.Completed;

            todoList.Add(myTodo);
            todoList.Add(new ToDo() { TaskId = 3, Description = "Mentor Call", EstimatedHours = 2f, TaskStatus = Status.Dismissed });
            todoList.Add(new ToDo() { TaskId = 4, Description = "Build Resume", EstimatedHours = 5.0f, TaskStatus = Status.InProgress });
            todoList.Add(new ToDo() { TaskId = 5, Description = "Download Visual Studio", EstimatedHours = 0.5f, TaskStatus = Status.OnHold });

            PrintList(todoList);
        }

        static void PrintList(List<ToDo> todos) {
            foreach(ToDo todo in todos) {
                switch (todo.TaskStatus) {
                    case Status.Dismissed:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
                Console.WriteLine($"{todo.TaskId}, {todo.Description}, {todo.EstimatedHours}, {todo.TaskStatus}");
            }
        }
    }
}
