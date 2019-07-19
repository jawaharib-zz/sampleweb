using System;
using System.Collections.Generic;
using System.Text;

namespace calc
{
    public interface ICalculator
    {
        int Add(int param1, int param2);
        int Subtract(int param1, int param2);
        int Multipy(int param1, int param2);
        int Divide(int param1, int param2);
        int ConvertUSDtoCLP(int unit);
    }
    public interface IUSD_CLP_ExchangeRateFeed
    {
        int GetActualUSDValue();
    }
}
