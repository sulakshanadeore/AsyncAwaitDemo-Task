namespace AsyncAwaitDemo
{
    internal class Program
    {


        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello, World!.... Fetching Data from the db...\n Please wait");
        //    string data =  GetDataFromDB();
        //    Console.WriteLine("I am on a other task1");
        //    Console.WriteLine("I am on a other task2");
        //    Console.WriteLine(data);


        //}

        //static string GetDataFromDB()
        //{
        //    Thread.Sleep(3000);//3 milliseconds

        //    return "Got the data from DB";
        //}


        static  async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!.... Fetching Data from the db...\n Please wait");
            //string data = await GetDataFromDB();

            Task<string> t1=GreetUser("Smita", 2000);
            Task<string> t2 = GreetUser("Raj", 3000);
            Console.WriteLine("I am on a other task1");
            Console.WriteLine("I am on a other task2");

            string[] result=await Task.WhenAll(t1, t2);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Ended");
            //Console.WriteLine("I am on a other task1");
            //Console.WriteLine("I am on a other task2");
            //Console.WriteLine(data);
        }



        static async Task<String> GreetUser(String username, int delayMS)
        { 
        await Task.Delay(delayMS);
            return $"{username} completed this in {delayMS / 1000} seconds";
        
        }
        static async Task<string> GetDataFromDB()
        {
            //Thread.Sleep(3000);//3 milliseconds
            await Task.Delay(3000);
            return "Got the " +
                "data from DB";
        }
    }
}
