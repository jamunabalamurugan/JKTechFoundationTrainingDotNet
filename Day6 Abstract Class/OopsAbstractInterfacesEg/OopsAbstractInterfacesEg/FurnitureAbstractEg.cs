using System;
namespace FFC
{
    public abstract class Furniture
    {
        protected string color;
        protected int width;
        protected int height;
        public  abstract void Accept();  //Only declaring a function for sake of override --Pure virtual Functions 
        public  abstract void Display();//Does not have an implementation of its own....its added for the sake of taking advantage of inheritance and dynamic binding

        public void Method1()
        {
            Console.WriteLine("There is nothing called Furniture....Its abstract");
        }
        public abstract void Hello();
    }

   abstract  class Bookshelf : Furniture
    {
        protected int numOf_shelves;
        public override void Accept()
        {
            string str2, str3, str4;
            Console.WriteLine("ENTER VALUES FOR BOOKSHELF");
            Console.WriteLine("Enter Color ");

            color = Console.ReadLine();
            Console.WriteLine("Enter Width ");
            str2 = Console.ReadLine();
            width = Convert.ToInt32(str2);
            Console.WriteLine("Enter Height ");
            str3 = Console.ReadLine();
            height = Convert.ToInt32(str3);
            Console.WriteLine("Enter No. of shelves ");
            str4 = Console.ReadLine();
            numOf_shelves = Convert.ToInt32(str4);
        }
        public override void Display()
        {
            Console.WriteLine("DISPLAYING VALUES FOR BOOKSHELF");
            Console.WriteLine("Color is {0}", color);
            Console.WriteLine("Width is {0}", width);
            Console.WriteLine("Height is {0}", height);
            Console.WriteLine("Number of shelves is {0}",
            numOf_shelves);
        }
    }
    class Study : Bookshelf
    {
        string TextbookName;
        public override void Hello()
        {
            Console.WriteLine("Hello from Study Bookshelf");
        }
        public override void Accept()
        {
            string str2, str3, str4;
            Console.WriteLine("ENTER VALUES FOR BOOKSHELF");
            Console.WriteLine("Enter Color ");

            color = Console.ReadLine();
            Console.WriteLine("Enter Width ");
            str2 = Console.ReadLine();
            width = Convert.ToInt32(str2);
            Console.WriteLine("Enter Height ");
            str3 = Console.ReadLine();
            height = Convert.ToInt32(str3);
            Console.WriteLine("Enter No. of shelves ");
            str4 = Console.ReadLine();
            numOf_shelves = Convert.ToInt32(str4);
            Console.WriteLine("Enter the Text Book Name");
            TextbookName = Console.ReadLine();
        }
    }
    class Chair : Furniture
    {
        private int numOf_legs;
        public override void Accept()
        {

            string str2, str3, str4;
            Console.WriteLine("ENTER VALUES FOR CHAIR");
            Console.WriteLine("Enter Color ");

            color = Console.ReadLine();
            Console.WriteLine("Enter Width ");
            str2 = Console.ReadLine();
            width = Convert.ToInt32(str2);
            Console.WriteLine("Enter Height ");
            str3 = Console.ReadLine();
            height = Convert.ToInt32(str3);
            Console.WriteLine("Enter No. of legs in a chair ");
            str4 = Console.ReadLine();
            numOf_legs = Convert.ToInt32(str4);
        }
        public override void Display()
        {
            Console.WriteLine("DISPLAYING VALUES FOR CHAIR");
            Console.WriteLine("Color is {0}", color);
            Console.WriteLine("Width is {0}", width);
            Console.WriteLine("Height is {0}", height);
            Console.WriteLine("Number of legs is {0}", numOf_legs);

        }
        public override void Hello()
        {
            Console.WriteLine("Hello from Chair");
        }
    }
    class BookShelfChair
    {
        static int Main(string[] args)
        {
            Bookshelf b1 = new Study();
            Chair c1 = new Chair();
            Study s1 = new Study();
            s1.Accept();
            s1.Display();
            Console.WriteLine("Furniture Object");
            // Furniture fur1 = new Furniture(); Error--Cannot instatiate an abstract class directly like this

            Console.WriteLine("Enter your choice");
            int ch = Convert.ToInt32(Console.ReadLine());
            Furniture fur;
            if (ch == 1)
                fur = new Study();//We can use a child class to instatiate an Abstract class
            else
                fur = new Chair();

            fur.Accept();
            fur.Display();
            fur.Method1();
            //Or
            //Console.WriteLine("BookShelf Object");
            //b1.Accept();
            //b1.Display();

            //Console.WriteLine("Chair Object");
            //c1.Accept();
            //c1.Display();
            Console.ReadLine();
            return 0;
        }
    }
}
