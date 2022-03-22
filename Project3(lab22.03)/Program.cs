using Project3_lab22._03_;

Console.WriteLine("-Hello-");
Console.WriteLine();

Point p1 = new Point { X = 3.0, Y = 4.0 };
Point p2 = new Point();
Point p3 = new Point(3, 4);

Console.WriteLine(p1);

Point p4 = new Point(5);
//Point p5 = new Point(5, 6) { Color = Co};
Console.WriteLine();
Console.WriteLine($"Distanta de la origine in pct {p1} este {p1.GetDistanceToOrigin()}");
Console.WriteLine();
Point p6 = new Point(1,1);
p6.MoveBy(2, 2);
Console.WriteLine($"Moved point {p6}.");
