using System.IO;
string file = "movies.csv";
// ask for input
Console.WriteLine("Enter 1 to add a movie to the data file.");
Console.WriteLine("Enter 2 to see all movies data.");
Console.WriteLine("Enter anything else to quit.");
// input response
string? resp = Console.ReadLine();

if (resp == "1")
{
    StreamWriter sw = new StreamWriter(file, append: true);
    // for (int i = 0; i < 7; i++)
    // {
    //     Console.WriteLine("Enter Movie(Y/N)?");
        // input the response
        // string NewMovieChoice = Console.ReadLine().ToUpper();
        // if the response is anything other than "Y", stop asking
        // if (NewMovieChoice != "Y") { break; }
            Console.WriteLine("Enter Movie ID");
            int MovieID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give Movie Title");
            string? MovieTitle = Console.ReadLine();

            Console.WriteLine("Give Movie Genre(s)");
            string? Genre = Console.ReadLine();
        
            sw.WriteLine("{0},{1},{2}", MovieID, MovieTitle, Genre);
    // }
    sw.Close();
}
else if (resp == "2")
{
//Parse data file
StreamReader sr = new StreamReader(file);
    while (!sr.EndOfStream)
    {
        string line = sr.ReadLine();
            // convert string to array
            string[] title = line.Split(',');
            string[] genres = title[2].Split('|');

                // display array data
                Console.WriteLine("{0}", title[1]);
            }
            sr.Close();
}