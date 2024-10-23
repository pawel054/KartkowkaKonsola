namespace AplikacjaKonsola
{
    internal class Program
    {
        static List<AlbumData> albumDatas = new List<AlbumData>();
        static void Main(string[] args)
        {
            string filePath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Data.txt");
            LoadDataFromFile(filePath);
            DisplayData(albumDatas);
        }

        private static void LoadDataFromFile(string filePath)
        {
            if(File.Exists(filePath))
            {
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
                    albumDatas.Add(albumData);
                }
            }
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
