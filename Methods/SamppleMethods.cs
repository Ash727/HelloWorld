using System;
using System.Net;

namespace Methods
{
    internal static class SamppleMethods
    {
        public static int Add (int x, int y)
        {
            WebClient client = new WebClient();
            byte [] dowonlad = client.DownloadData("searchTearm.com/results.json");
            
            return x + y;
        }

        public static void PrintHello()
        {
            Console.WriteLine($"Hello World");
        }

        private static void SayYes()
        {

        }

        public static string GetGoogleHomePage()
        {
            var webClient = new WebClient();
            byte[] googleHome = webClient.DownloadData("https://jsonplaceholder.typicode.com/todos/1");
            Uri a = new Uri("https://jsonplaceholder.typicode.com/todos/1");
            webClient.DownloadFileAsync(a, Directory.GetCurrentDirectory() + "/ToDo.json");
            //webClient.
            //webClient.Headers()
            // Neeed a stream reader

            using (var stream = new MemoryStream(googleHome))
            using (var reader = new StreamReader(stream))
            {

                return reader.ReadToEnd();

            }

        }
    }
}

