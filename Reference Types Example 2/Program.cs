using System;

//ref link:https://www.youtube.com/watch?v=VSKxZIxacEw&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=5
//  object graph -- 

class Cow
{
    int mooCount;
    Udder udder;
    public Cow()
    {
        udder = new Udder();
    }
}

class Udder
{
    int numTeets;
    double ouncesOfMilk;
}

class MainClass
{
    static void Main()
    {
        Cow c = new Cow();
    }
}