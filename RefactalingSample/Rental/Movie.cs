using System;
using System.Data;

namespace RefactalingSample.Rental
{
    public class Movie
    {
        public const int REGULAR = 0;
        public const int NEW_RENTAL = 0;
        public const int CHILDRENS = 0;

        private string _title;
        private int _priceCode;

        public Movie(string title, int priceCode)
        {
            _title = title;
            _priceCode = priceCode;
        }

        public int GetPriceCode()
        {
            return _priceCode;
        }

        public void SetPriceCode(int arg)
        {
            _priceCode = arg;
        }

        public string GetTitle()
        {
            return _title;
        }


    }
}