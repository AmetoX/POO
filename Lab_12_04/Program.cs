﻿Console.WriteLine("Hello, World!");
Console.WriteLine();//-MultiCounter-

Counter heads = new Counter("heads");
Counter tails = new Counter("tails");
Random random = new Random();

for(int i = 0; i < 1000; i++)
{
    switch (random.Next(2))
    {
        case 0:
            heads.Increment();
            break;
        case 1:
            tails.Increment();
            break;
        default:
            break;
    }
}

Console.WriteLine($"Heads: {heads.Count}, Tails: {tails.Count}.");
Console.WriteLine(heads);
Console.WriteLine(tails);
Console.WriteLine();

heads.Reset();
tails.Reset();

Console.WriteLine($"Heads: {heads.Count}, Tails: {tails.Count}.");
Console.WriteLine(heads);
Console.WriteLine(tails);
Console.WriteLine();

MultiCounter mc = new MultiCounter(4);

for(int i = 0; i < 10; i++)
{
    mc.Increment();
    Console.WriteLine(mc);
}