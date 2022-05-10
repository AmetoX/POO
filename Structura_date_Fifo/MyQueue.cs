//Lab 10.05.2022
//structura de date de tip Fifo(first in , first out)
//Fifo queue

public class MyQueue
{
    #region data
    private int[] data;
    private int left = 0;
    private int right = 0;
    private int count = 0;
    #endregion
    #region Ctors
    public MyQueue() : this(42)
    {

    }
    public MyQueue(int n)
    {
        data = new int[n];
    }
    #endregion
    #region Proprerties
    public bool Empty
    {
        get { return left == right; }
    }
    public int Count
    {
        get { return count; }
    }
    #endregion
    #region Methods
    public void Enqueue(int val)
    {
        if (count < data.Length)
        {
            if (right < data.Length)
            {
                data[right++] = val;
            }
            else
            {
                data[0] = val;
                right = 1;
            }
            count++;
        }
        else
        {
            throw new QueueFullException("Coada este plina.");
        }        
    }
    public int Dequeue()
    {
        int resutlt;
        if (count > 0)
        {
            resutlt = data[left];
            left = (left+1) % data.Length;
            count--;
            return resutlt;
        }
        else
        {
            throw new QueueEmptyException("Coada este goala.");
        }       
    }
    #endregion
}