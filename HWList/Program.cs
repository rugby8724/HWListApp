

List<string> students = new List<string>();

bool stopAddingStudents = false;

do
{
	Console.WriteLine("Hello Please add a student"); 
	string student = Console.ReadLine();
    students.Add(student);
    Console.WriteLine("If you would like to stop adding students please press E, else hit enter to continue");
    string? exitProgram = Console.ReadLine();
    if (exitProgram.ToLower() == "e")
    {
        stopAddingStudents = true;
    }
} while (!stopAddingStudents);

