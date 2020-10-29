using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace CardGame.Model
{
    class deck
    {
        private string deck_id;
        public deck(string deck_id)
        {
            this.deck_id = deck_id;

        }


        public List<card> drawCard(int count)
        {
            HttpClient client = new HttpClient();
            string url = string.Format("https://deckofcardsapi.com/api/deck/{0}/draw/?count={1}",this.deck_id,count.ToString());
            var response = client.GetStringAsync(url);
            //Console.WriteLine(response.Result);
            JObject res = JObject.Parse(response.Result);
            List<card> card_list = new List<card>();
            for(int i =0; i < count; i++)
            {
                card c = new card(res["cards"][i]["code"].ToString(), res["cards"][i]["image"].ToString());
                card_list.Add(c);
            }
            
            
            
            return card_list;
        }

        public card drawCard()
        {
            HttpClient client = new HttpClient();
            string url = string.Format("https://deckofcardsapi.com/api/deck/{0}/draw/?count={1}", this.deck_id, "1");
            var response = client.GetStringAsync(url);
            //Console.WriteLine(response.Result);
            JObject res = JObject.Parse(response.Result);
            
            card c = new card(res["cards"][0]["code"].ToString(), res["cards"][0]["image"].ToString());
                
            



            return c;
        }

    }
}
