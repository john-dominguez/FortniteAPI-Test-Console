using FortniteApi;
using FortniteApi.Data;
using System;
using System.Media;
using Library;

namespace Api_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            GetInfo();
            Console.ReadKey();
        }

        public static async void GetInfo()
        {
            using (FortniteClient client = new FortniteClient("bb93b0a2-0a92-4969-89aa-5180e589a065"))
            {
                var response = await client.FindPlayerAsync(Platform.Pc, "Sougyo");

                
//                Console.WriteLine(response.Stats["P2"]["score"].ValueInt);
//                Console.WriteLine(response.RecentMatches.Count);

                Console.WriteLine($"Solo Wins: {response.Stats[Playlist.Solo][Stat.Top1].ValueInt}");
                response.Stats[Playlist.Solo][Stat.]
//
//                var keys = response.Stats.Keys;
//                foreach (var key in keys)
//                {
//                    foreach (var key2 in response.Stats[key].Keys)
//                    {
//                        Console.WriteLine($"{key2} : {response.Stats[key][key2]}");
//                    }
//
//                    Console.WriteLine("---");
//                }
//
//                foreach (var match in response.RecentMatches.AsReadOnly())
//                {
//                    Console.WriteLine(match.DateCollected);
//                    Console.WriteLine(match.Kills);
//                }

//                Serializer.Serialize(response, 0);


            }
        }
    }
}
