using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug11
{
    class MainClass
    {
        public static void Main()
        {
            UserInterface desc = new ScreenDescription();
		do
		{
            		desc.showFirstScreen();
		}while(true);
        }
    }
}
