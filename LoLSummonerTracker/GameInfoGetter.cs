using RiotSharp;
using RiotSharp.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLSummonerTracker
{
    public class GameInfoGetter
    {

        public GameInfoGetter(){
        
        var api = RiotApi.GetDevelopmentInstance("RGAPI-e561c93b-842d-4bf0-913b-d0aac559f3a0");

            try
            {
                var summoner = api.Summoner.GetSummonerByNameAsync(Region.Euw, "Boomkin").Result;
                var name = summoner.Name;
                var level = summoner.Level;
                var accountId = summoner.AccountId;
            }
            catch (RiotSharpException ex)
            {
                // Handle the exception however you want.
            }


        }

    }
}
