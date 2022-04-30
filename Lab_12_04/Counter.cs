internal class Counter
{
    protected string id;
    protected int count;
    private Counter? nextCounter;

    public Counter? NextCounter
    {
        get { return nextCounter; }
        set { nextCounter = value; }
    }
    public int Count
    {
        get
        {
            return count;//propietate read-only
        }         
    }

    public Counter(string id)
    {
        this.id = id;
        this.count = 0;//initializarea asta oricum se face
        nextCounter = null;
    }

    internal void Increment()
    {
        count++;
        if(count == 10)
        {
            count = 0;
            if (nextCounter != null)
            {
                nextCounter.Increment();
            }
        }
    }

    internal void Reset()
    {
        count = 0;
    }

    public override string ToString()
    {
        return $"[Counter <{id}>: {count}]";
    }
}