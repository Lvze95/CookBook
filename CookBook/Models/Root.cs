using Newtonsoft.Json;
using System.Collections.Generic;

namespace CookBook.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Root
    {
        [JsonProperty("recipe")]
        public List<Recipe> Recipe { get; set; }
    }
}