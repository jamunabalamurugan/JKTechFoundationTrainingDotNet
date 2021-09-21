using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCreditCardDLL
{
    public class CardValidation
    {
        public bool AcceptCard(string cardNo)
        {
            //if (cardno.Length == 6)
            //    return true;
            //else
            //    return false;

            bool bIsValid = false;
            int iSum = 0;
            for (int i = 15; i >= 0; i--)
            {
                int iNum = Convert.ToInt32(cardNo[i].ToString());
                if (i % 2 == 0)
                {
                    iNum *= 2;
                    if (iNum > 9)
                        iNum -= 9;
                }
                iSum += iNum;
            }
            if (iSum % 10 == 0)
                bIsValid = true;

            return bIsValid;






        }
    }
}
