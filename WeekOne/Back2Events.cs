

namespace WeekOne;

public class Back2Events
{
    //Delegate definition
    public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);

    public delegate void EventHandler<TEventArgs>(object source, TEventArgs e) where TEventArgs : EventArgs;

    public class Broadcaster
    {
        public event PriceChangedHandler PriceChanged;
    }

    public class Stock
    {
        string _symbol;
        decimal _price;

        public Stock(string symbol)
        {
            _symbol = symbol;
        }

        //public event PriceChangedHandler PriceChanged;

        public event EventHandler PriceChanged;

        protected virtual void OnPriceChanged(EventArgs e)
        {
            PriceChanged?.Invoke(this, e);
        }

        public decimal Price
        {
            get { return _price; }
            set
            {
                if(_price == value) return;
                decimal oldPrice = _price;
                _price = value;
                OnPriceChanged(EventArgs.Empty);
            }
        }
    }


    public class PriceChangedEventArgs : System.EventArgs
    {
        public readonly decimal LastPrice;
        public readonly decimal NewPrice;


        public PriceChangedEventArgs(decimal lastPrice, decimal newPrice)
        {
            LastPrice = lastPrice;
            NewPrice = newPrice;
        }
    }

}


