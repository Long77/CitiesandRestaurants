using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CitiesandRestaurants
{
    class Program
    {
        static void Main(string[] args)
        {

            var Houston = new City("Houston");

            var NewOrleans = new City("New Orleans");

            var Austin = new City("Austin");
            var Montrose = new Neighborhood("Montrose");
            var Midtown = new Neighborhood("Midtown");
            var EastDowntown = new Neighborhood("East DownTown");
            var NearNorth = new Neighborhood("Near Northside");
            var Heights = new Neighborhood("Heights");
            var ByWater = new Neighborhood("ByWater");
            var French = new Neighborhood("French Quarter");
            var Garden = new Neighborhood("Garden District");
            var Uptown = new Neighborhood("UpTown");
            var Downtown = new Neighborhood("Downtown");
            var EastSide = new Neighborhood("EastSide");
            var West = new Neighborhood("West Street");
            var North = new Neighborhood("North");
            var Barton = new Neighborhood("Barton Creek");
            var Campus = new Neighborhood("University");
            var Poscol = new Restaurant(name: "Poscol", websiteUrl: "http://www.poscolhouston.com/");
            var Brazil = new Restaurant(name: "Brazil", websiteUrl: "http://www.brasilcafehouston.com/");
            var Celcius = new Restaurant(name: "13 Celsius", websiteUrl: "http://13celsius.com/");
            var Mon = new Restaurant(name: "Mongoose vs Cobra", websiteUrl: "http://mongooseversuscobra.com/");
            var Ninfas = new Restaurant(name: "Ninfas on Navigation", websiteUrl: "http://ninfas.com/");
            var Moon = new Restaurant(name: "MoonTower", websiteUrl: "http://damngoodfoodcoldassbeer.com/mti/index.html");
            var Down = new Restaurant(name: "DownHouse", websiteUrl: "http://treadsack.com/downhouse/");
            var Row = new Restaurant(name: "Eight Row Flint", websiteUrl: "http://eightrowflint.com/");
            var Teo = new Restaurant(name: "Teotihuacan", websiteUrl: "http://www.teomexicancafe.com/");
            var BB = new Restaurant(name: "BB's Cafe", websiteUrl: "http://bbscafe.com/locations/heights/");
            var Blue = new Restaurant(name: "Blue Dahlia Bistro", websiteUrl: "http://www.bluedahliabistro.com/");
            var Easy = new Restaurant(name: "Easy Tiger", websiteUrl: "http://easytigeraustin.com/");
            var PF = new Restaurant(name: "PF Chang's", websiteUrl: "https://www.pfchangs.com/texas/1800-austin-arboretum");
            var New = new Restaurant(name: "New Fortune", websiteUrl: "http://www.newfortuneseafood.com/");
            var Tom = new Restaurant(name: "Tomodachi Sushi", websiteUrl: "http://www.tomosushiaustin.com/");
            var Tita = new Restaurant(name: "Titaya's", websiteUrl: "http://titayasthaicuisine.com/");
            var Kor = new Restaurant(name: "Koriente", websiteUrl: "http://www.koriente.com/");
            var Car = new Restaurant(name: "Carmelo's", websiteUrl: "http://www.carmelosrestaurant.com/austin");
            var Komfort = new Restaurant("Korean Komfort Food", websiteUrl: "https://twitter.com/koreankomfort");
            var Nich = new Restaurant("Sushi Niichi", websiteUrl: "https://www.facebook.com/Sushi-Niichi-21078220514/");
            var Bac = new Restaurant("Bacchanal Wine", websiteUrl: "http://www.bacchanalwine.com/#about-marquee");
            var Sat = new Restaurant("Satsuma Cafe", websiteUrl: "http://satsumacafe.com/");
            var Verti = new Restaurant("Verti Marte", websiteUrl: "https://www.couchster.com/neworleans/order/VertiMarte-89");
            var Pos = new Restaurant("Poseiden", websiteUrl: "http://www.poseidonnola.com/");
            var Lil = new Restaurant("Lilly's", websiteUrl: "https://www.zomato.com/new-orleans/lillys-cafe-new-orleans");
            var Vinc = new Restaurant("Vincent's", websiteUrl: "http://www.vincentsitaliancuisine.com/");
            var Upper = new Restaurant("Upperline", websiteUrl: "http://www.upperline.com/");
            var Tart = new Restaurant("Tartine", websiteUrl: "http://www.tartineneworleans.com/");
            var Coch = new Restaurant("Cochon", websiteUrl: "http://www.cochonrestaurant.com/");
            var Cleo = new Restaurant("Cleo's", websiteUrl: "https://www.facebook.com/CleosNOLA/");


            Houston.neighboringCities.Add(NewOrleans);
            Houston.neighboringCities.Add(Austin);
            NewOrleans.neighboringCities.Add(Houston);
            NewOrleans.neighboringCities.Add(Austin);
            Austin.neighboringCities.Add(Houston);
            Austin.neighboringCities.Add(NewOrleans);



            Houston.burroughs.Add(Montrose);
            Houston.burroughs.Add(Midtown);
            Houston.burroughs.Add(EastDowntown);
            Houston.burroughs.Add(NearNorth);
            Houston.burroughs.Add(Heights);
            Austin.burroughs.Add(EastSide);
            Austin.burroughs.Add(West);
            Austin.burroughs.Add(North);
            Austin.burroughs.Add(Barton);
            Austin.burroughs.Add(Campus);
            NewOrleans.burroughs.Add(ByWater);
            NewOrleans.burroughs.Add(French);
            NewOrleans.burroughs.Add(Garden);
            NewOrleans.burroughs.Add(Uptown);
            NewOrleans.burroughs.Add(Downtown);


            Montrose.restaurants.Add(Poscol);
            Montrose.restaurants.Add(Brazil);
            EastDowntown.restaurants.Add(Moon);
            EastDowntown.restaurants.Add(Ninfas);
            Midtown.restaurants.Add(Celcius);
            Midtown.restaurants.Add(Mon);
            Heights.restaurants.Add(Down);
            Heights.restaurants.Add(Row);
            NearNorth.restaurants.Add(Teo);
            NearNorth.restaurants.Add(BB);

            EastSide.restaurants.Add(Blue);
            EastSide.restaurants.Add(Easy);
            West.restaurants.Add(PF);
            West.restaurants.Add(New);
            North.restaurants.Add(Tom);
            North.restaurants.Add(Tita);
            Barton.restaurants.Add(Kor);
            Barton.restaurants.Add(Car);
            Campus.restaurants.Add(Komfort);
            Campus.restaurants.Add(Nich);

            ByWater.restaurants.Add(Bac);
            ByWater.restaurants.Add(Sat);
            French.restaurants.Add(Verti);
            French.restaurants.Add(Pos);
            Garden.restaurants.Add(Lil);
            Garden.restaurants.Add(Vinc);
            Uptown.restaurants.Add(Upper);
            Uptown.restaurants.Add(Tart);
            Downtown.restaurants.Add(Coch);
            Downtown.restaurants.Add(Cleo);




            Console.WriteLine("Poscol Website: {0}", Poscol.websiteUrl);
       
            Console.ReadLine();

        }
      
        class City
        {
            public string name;

            public City(string name)
            {
                this.name = name;
            }

            public List<City> neighboringCities = new List<City>();
            public List<Neighborhood> burroughs = new List<Neighborhood>();
            public List<Restaurant> restaurants = new List<Restaurant>();
       //     public List<Latlng> lats = new List<Latlng>();
       //     public List<Latlng> lngs = new List<Latlng>();
            public override string ToString()
            {
                string result = "";
                foreach (City c in neighboringCities)
                {
                    foreach(Restaurant s in restaurants)
                    {
                        result = result + ", " +c+", "+s;
                    }
                }
                return result;
            }
            
        }
        class Neighborhood
        {
            public string name;
        //    public City city;
            public Neighborhood(string name)
            {
                this.name = name;
            }
            public List<Restaurant> restaurants = new List<Restaurant>();
            public List<Neighborhood> burroughs = new List<Neighborhood>();
            public override string ToString()
            {
                string result = "";
                foreach(Neighborhood n in burroughs)
                {
                    foreach(Restaurant r in restaurants) { 
                    result = result+", "+n+", "+r;
                    }
                }
                return result;
            }


        }
        class Restaurant
        {
            public string name;
            public Restaurant(string name = "", string websiteUrl = "")
            {
                this.name = name;
                this.websiteUrl = websiteUrl;
            }
        /*    public string address; */
            public string websiteUrl;
         //   Category type;
        //    public List<Address> addresses = new List<Address>();
            public List<Restaurant> restaurants = new List<Restaurant>();
            public override string ToString()
            {
                string result = "";
                foreach (Restaurant r in restaurants)
                {
                    result = result + ", " + r;
                }
                return result;
            }
        }


    /*    class Latlng
        {
            double
            double Lngs;
            public List<Latlng> lats = new List<Latlng>();
            public List<Latlng> lngs = new List<Latlng>();
        }
        class Address
        {
            public Latlng Lat;
            public Latlng Lng;
            public string StreetAddress;
            public int zip;
            public City city;
        } */
        public enum Category
        {
            Italian,
            American,
            Thai,
            German,
            French,
            English,
            Mexican,
            Spanish,
            Chinese,
            Korean,
            Japanese,
            Other,
        }



    }
}    

