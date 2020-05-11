using RiotSharp;
using RiotSharp.Endpoints.SummonerEndpoint;
using RiotSharp.Endpoints.StaticDataEndpoint;
using RiotSharp.Misc;
using System.Linq;


namespace LoLSummonerTracker
{
    public class GameInfoGetter
    {
        Summoner summoner;
        RiotApi api;

        public GameInfoGetter()
        {

            api = RiotApi.GetDevelopmentInstance("RGAPI-e561c93b-842d-4bf0-913b-d0aac559f3a0");

            try
            {
                summoner = api.Summoner.GetSummonerByNameAsync(Region.Euw, "Boomkin").Result;


            }
            catch (RiotSharpException ex)
            {
                // Handle the exception however you want.
            }


        }

        public string getId()
        {

            return summoner.Id;

        }

    }
}
