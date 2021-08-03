using System;
using System.Collections.Generic;
using System.Text;

namespace FinalThing
{
    
        public class TopChart
        {
            public string title { get; set; }
            public string subtitle { get; set; }
            public string publisher { get; set; }
            public int rank { get; set; }
            public int? previousRank { get; set; }
            public object delta { get; set; }
            public string apple_store_url { get; set; }
            public string icon_url { get; set; }
            public string release_date { get; set; }
            public string last_updated_date { get; set; }
            public string current_version { get; set; }
            public double rating { get; set; }
            public int rating_count { get; set; }
            public int price { get; set; }
            public bool in_app_purchases { get; set; }
        }

        public class Root
        {
            public string category { get; set; }
            public string country { get; set; }
            public string device { get; set; }
            public string purchaseType { get; set; }
            public List<TopChart> topChart { get; set; }
        }

    
}
