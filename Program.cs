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
        //Asking for MovieID
        Console.WriteLine("Enter MovieID");
        int MovieID;
            //Ensureing that MovieId is an int
            try
            {
                MovieID = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.Exception)
            {
                throw new Exception("Input for MovieID must be a number");
            }
        
        string? MovieTitle = "";
        while (String.IsNullOrEmpty(MovieTitle))
        {
            //Asking for Movie Title
            Console.WriteLine("Give Movie Title");
            MovieTitle = Console.ReadLine();
        }
        
        //Asking for Movie Genres
        Console.WriteLine("Give Movie Genre(s)");
        string? Genre = Console.ReadLine();
            //If Movie Genre is left blank a sentinal value is allocated
            bool GenreCheck = String.IsNullOrEmpty(Genre);
                if (GenreCheck is true)
                    {
                        Genre = "(no genres listed)";
                    }
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