//Lab 10.05.2022
//structura de date de tip Fifo(first in , first out)
//Fifo queue
using Structura_date_Fifo;


MyQueue q1 = new MyQueue();
q1.Enqueue(1);
q1.Enqueue(2);
q1.Enqueue(3);
Console.WriteLine($"Numarul de elemnte din coada este: {q1.Count}");
while (!q1.Empty)
{
    Console.WriteLine(q1.Dequeue());//le scoate din coada => 1 2 3
}
Console.WriteLine();


MyGenericQueue<int> q2 = new MyGenericQueue<int>();
Random random = new Random();
for(int i = 1; i <= 40; i++)
{
    int op  = random.Next(3);
    int val;
    if (op <= 1)
    {
        val = random.Next(1000);
        q2.Enqueue(val);
        Console.WriteLine($"Enqueue: {val}");
    }
    else
        Console.WriteLine($"Dequeue: {q2.Dequeue()}");
}