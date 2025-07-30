// creating string that will assemble the rocket 

string rocket = " / \\\n | |\n | |\n_|_|_\n";

//Console.WriteLine(rocket);

for(int i = 0; i<25; i++)
{
    Console.WriteLine(rocket);
    Thread.Sleep(5);
    Console.Clear();
    rocket = "\r\n" + rocket;
}
Console.ReadKey();