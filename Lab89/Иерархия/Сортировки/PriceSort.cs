internal class PriceSort : IComparer<Computer>
{
    public int Compare(Computer? x, Computer? y)
    {
        if(x.Price > y.Price)
            return 1;
        else if (x.Price < y.Price)
            return -1;
        else 
            return 0;
    }
}

