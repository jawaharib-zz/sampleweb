using System;

namespace calc
{
    public class Calculator : ICalculator
    {
        private IUSD_CLP_ExchangeRateFeed _feed;
        public Calculator(IUSD_CLP_ExchangeRateFeed feed)
        {
            this._feed = feed;
        }
        #region ICalculator Members
        public int Add(int param1, int param2)
        {
            throw new NotImplementedException();
        }
        public int Subtract(int param1, int param2)
        {
            throw new NotImplementedException();
        }
        public int Multipy(int param1, int param2)
        {
            throw new NotImplementedException();
        }
        public int Divide(int param1, int param2)
        {
            return param1 / param2;
        }
        public int ConvertUSDtoCLP(int unit)
        {
            return unit * this._feed.GetActualUSDValue();
        }
        #endregion
    }
}
