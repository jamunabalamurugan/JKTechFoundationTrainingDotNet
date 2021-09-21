using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardValidationDLL
{
    public class CreditCard
    {
        public bool ValidateCreditCard(string cardno)
        {
            //if (cardno.Length == 16)
            //{
            //    return true;
            //}
            //else
            //    return false;
            if (cardno.Length != 16)
                return false;
            else if (cardno.Length == 16)
            {
                bool bIsValid = false;
                int iSum = 0;
                for (int i = 15; i >= 0; i--)
                {
                    
                    int iNum = Convert.ToInt32(cardno[i]);
                    if (i % 2 == 0)
                    {
                        iNum *= 2;//6*2=12...8*2=16...1+6=7.....1+2=3  7*2=14..1+4=5
                        if (iNum > 9)
                            iNum -= 9;//iNum=iNum-9....16-9=7
                    }
                    iSum += iNum;//3+3+2+7+9+2+9+5+1+0+1+6+4+5+0+3=60
                }
                if (iSum % 10 == 0)
                    bIsValid = true;

                return bIsValid;
            }
            else
                return false;

        }

    }
}
