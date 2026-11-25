namespace C__Basics_Session04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question 1

            double[] prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine($"the second item is : {prices[1]}"); //40

            #endregion

            // ════════════════════════════════════════════════

            #region Question 2

            int[,] shelfCopies = { {3,5 } ,
                                   {1,4 } };

            Console.WriteLine(shelfCopies[1,0]); // 1

            #endregion

            // ════════════════════════════════════════════════

            #region Question 3

            static void PrintWelcomeMessage()
            {
                Console.WriteLine("Welcome to the Library!");
            }

            PrintWelcomeMessage();

            #endregion

            // ════════════════════════════════════════════════

            #region Question 4

            static string PrintBookTitle(string title)
            {
                return "Book title: " + title;
            }

            Console.WriteLine(PrintBookTitle("Clean Code"));

            #endregion

            // ════════════════════════════════════════════════

            #region Question 5

            static void AddBonusPages(int pages)
            {
                pages += 50;
            }

            int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine(pages); //400
            // المتغير الاصلي هيفضل زي ما هو عشان دي فاليو تايب 
            #endregion

            // ════════════════════════════════════════════════

            #region Question 6

            static void ApplyDiscount(double[] prices)
            {
                prices[0] -= 5;
            }
            double[] pricess = { 25.5, 40.0 };
            ApplyDiscount(pricess);

            Console.WriteLine(pricess[0]); //20.5

            #endregion

            // ════════════════════════════════════════════════

            #region Question 7

            static void AddBonusPagesByRef(ref int pages)
            {
                pages += 50;
            }
            int pagesref = 400;

            AddBonusPagesByRef(ref pagesref);

            Console.WriteLine(pagesref); //450

            // هنا هيتغير عشان استخدمنا ref 

            #endregion

            // ════════════════════════════════════════════════

            #region Question 8

            static void ReplaceArray(ref double[] pricesparameter)
            {
               pricesparameter = new double[] { 10.0, 12.5, 15.0 };
            }
            double[] doublesref = { 25.5, 40.0 };
            ReplaceArray(ref doublesref);
            Console.WriteLine(doublesref.Length); //3

            #endregion

            // ════════════════════════════════════════════════

            #region Question 9

            static bool TryGetPrice(string title , out double price)
            {
                if (title == "Clean Code")
                {
                    price = 25.5;
                    return true;
                }
                price = 0;
                return false;
            }

            if(TryGetPrice("Clean Code", out double price))
            {
                Console.WriteLine(price); // 25.5
            }

            #endregion

            // ════════════════════════════════════════════════

            #region Question 10

            static void PrintBookInfo(string title, int pagesss = 300)
            {
                Console.WriteLine($"title is : {title} , pages num is : {pagesss}");
            }

            PrintBookInfo("interesing book");
            PrintBookInfo("interesing book" , 600);

            #endregion

            // ════════════════════════════════════════════════

            #region Question 11

            PrintBookInfo(pagesss: 750, title: "swapped book");

            #endregion

            // ════════════════════════════════════════════════

            #region Question 12

            static void PrintAllTitles(params string[] titles)
            {
                for(int i = 0; i < titles.Length; i++)
                {
                    Console.WriteLine($"title {i+1} : {titles[i]}");
                }
            }

            
            PrintAllTitles("romance", "action", "police");

            #endregion
        }
    }
}
