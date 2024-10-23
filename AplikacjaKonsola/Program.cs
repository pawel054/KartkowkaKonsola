namespace AplikacjaKonsola
{
    public class Program
    {
        static void Main(string[] args)
        {
            string filePath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Data.txt");
            var albumData = LoadDataFromFile(filePath);
            DisplayData(albumData);
           
        }

        /*
            ***********************************************
            nazwa funkcji: LoadDataFromFile
            opis funkcji: Funkcja wczytuje dane z pliku tekstowego i zapisuje je w liście
            parametry: parametr filePath to ścieżka do pliku tekstowego z którego wczytujemy dane
            zwracany typ i opis: "brak"
            autor: Paweł Marcisz
            ***********************************************
         * 
         */

        public static List<AlbumData> LoadDataFromFile(string filePath)
        {
                List<AlbumData> data = new List<AlbumData>();
                List<string> fileLines = new List<string>();
                var lines = File.ReadAllLines(filePath);
                foreach(var line in lines)
                {
                    fileLines.Add(line);
                }

                for(int i = 0; i < fileLines.Count; i+=6)
                {
                    AlbumData albumData = new AlbumData
                    {
                        Artist = fileLines[i],
                        Album = fileLines[i + 1],
                        SongsNumber = int.Parse(fileLines[i + 2]),
                        Year = int.Parse(fileLines[i + 3]),
                        DownloadNumber = int.Parse(fileLines[i + 4])
                    };
                    data.Add(albumData);
                }
                return data;
        }

        private static void DisplayData(List<AlbumData> albumDatas)
        {
            foreach(AlbumData albumData in albumDatas)
            {
                Console.WriteLine($"{albumData.Artist}\n{albumData.Album}\n{albumData.SongsNumber}\n{albumData.Year}\n{albumData.DownloadNumber}\n");
            }
        }
    }
}
