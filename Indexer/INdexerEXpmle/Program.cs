internal class BusArray
{
    private Bus[] buses;

    public Bus this[int i]
    {
        get { return buses[i]; }
        set { buses[i] = value; }
    }

    public BusArray()
    {
        buses = new Bus[20000];
    }
}

internal class Bus
{
}