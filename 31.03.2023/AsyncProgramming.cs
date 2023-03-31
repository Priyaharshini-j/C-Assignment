namespace AsyncProg
{
    internal class AsyncProgramming
    {
        //ChiefGues activities-> Speech Giving dependent on Speech review
        // catering depends on delivery
        // food depends on catering
        //prize depends on  prize arricval
        // speech review depends on arrival
        // bomb squad depends on decorated
        //
        public static async Task Main(string[] args)
        {
            await FoodSection();
            await SpeechPrepare();


            Console.ReadKey();


        }
        //Asynchronous Task related to Food
        public static async Task FoodSection()
        {
            Task task = RawMaterials();
            await task;
            Task foodPrepare = Catering();
            await foodPrepare;
            Serving();
        }
        public static async Task RawMaterials()
        {
            await Task.Delay(5000);
            Console.WriteLine("The Raw MAterials are Delivered");
            
        }
        public static async Task Catering()
        {
            await Task.Delay(5000);
            Console.WriteLine("Food is Prepared");
           
        }
        public static void Serving()
        {
                Console.WriteLine("Food can be served to the participants");
          
        }
        //Asynchronous Task Related to Sppech
        public static async Task SpeechPrepare()
        {
            Task decoration = Decor();
            Task Speech = SpeechReview();
            await Speech;
            await decoration;
            Task Bomb = BombSquad();
            await Bomb;
            Task arr = Arrival();
            await arr;
            SpeechGiving();
        }
        public static async Task SpeechReview()
        {
            await Task.Delay(5000);
            Console.WriteLine("The Speech Review is Done by PA");

        }
        public static async Task Decor()
        {
            await Task.Delay(5000);
            Console.WriteLine("Stage is Decorated");
        }

        public static async Task BombSquad()
        {
                Console.WriteLine("The Stage is checked by security");
            await Task.Delay(5000);

        }
        public static async Task Arrival()
        {
               
                    Console.WriteLine("Chief Guest is Picked from Airport");
                    await Task.Delay(5000);
                    Console.WriteLine("Chief Guest Have Arrived to the Venue");
            
        }

        public static void SpeechGiving()
        {
                Console.WriteLine("Speech is Given by Chief Guest");
          
            PrizeDistribution();
        }
        public static void PrizeDistribution()
        {
            Console.WriteLine("Prize is distributed to the Participants");
        }
    }
}
