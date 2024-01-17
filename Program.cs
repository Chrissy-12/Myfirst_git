namespace helloworld;

class Program
    static void Main(string[] args)
    {
        Console.WriteLine ("Algorithm")

        // Create array called gradesArray
        float [] gradesArray = new float [10];
        
        // Add grades method, gradesArray 
        addGrades(gradesArray);
        
        // Display Grades
        displayGrades(gradesArray);
        
        // create new stack
        stackalloc<float> myStack = new Stack<float>();

        // call pushstack method passing grades array
        pushStack(gradesArray, myStack);

        // peekstack passing grades array 
        peekStack(myStack);

        // popStack method twice to remove top items from stack
        popStack(myStack);
        popStack(myStack);

        // creat Sortedlist call my courses
        SortedList<string, string> myCourses = new SortedList<string, string>();

        // populateList 
        populateList(myCourses);
        
        //remove item from mycourse list using key
        removeListItem(myCourses, "CS102");

    static void addGrades(float[] grdArray)
    {
        Random rnd = new Random();
        for(int i = 0; i < grdArray.Length; i ++)
        {
            int random = rnd.Next(0,100);
            float.tryParse(random.ToString(), out float results);
            grdArray[i] = results;
        }
    }
static void displayGrades(float[] grdArray)
{
    Console.WriteLine("Grades: ");
    foreach (float grade in grdArray)
    {
        Console.WriteLine(grade);
    }
}


static void pushStack(float[] grdArray, Stack<float> stack)
{
    foreach (float grade in grdArray)
    {
        stack.Push(grade);
    }
}

static void popStack(Stack<float> stack)
{
    Console.WriteLine("Item removed from the stack: ");
    Console.WriteLine(stack.Pop());
}

static void peekStack(Stack<float> stack)
{
    Console.WriteLine("Item at the top of the stack: ");
    Console.WriteLine(stack.Peek());
}

static void populateList(SortedList<string, string> list)
{
    Console.WriteLine("Populating List with data...");
    list.Add("CS101", "Introduction to Computer Science");
    list.Add("CS102", "Data Structures and Algorithms");
    list.Add("CS201", "Introduction to Databases");
    list.Add("CS301", "Introduction to Object-Oriented Programming");
    displayList(list);
}

static void displayList(SortedList<string, string> list)
{
    Console.WriteLine("Displaying myCourses list: ");
    foreach (KeyValuePair<string, string> entry in list)
    {
        Console.WriteLine(entry);
    }
}

static void removeListItem(SortedList<string, string> list, string filter)
{
    Console.WriteLine($"Removing {filter} from list.");
    list.Remove(filter);
    Console.WriteLine("Item removed from list.");
    displayList(list);

    }
}
