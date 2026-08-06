//8-6

//Add_100NeiOuShuHe();
//RunNian();
//DaoSanJiao();
//JiSuanJieGuo();
//JieCheng();
//LanQiu();
//JISuanQiPan();
//JiSuanCunKuan();
//ZhaiTao();
//PiQiu();

//1
void Add_100NeiOuShuHe()
{
    int sum = 0;
    for (int i = 1; i <= 100; i++)
    {
        if (i % 2 == 0)
        {
            sum += i;
        }
    }
    Console.WriteLine(sum);
}



//2
void RunNian()
{
    int i = 1000;
    int n = 1;
    while (i <= 2000)
    {
        if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
        {
            if (n % 4 == 0)
            {
                Console.WriteLine(i);
            }
            else
                Console.Write(i + "    ");
            n++;
        }
        i++;
    }
}


//3
void DaoSanJiao()
{
    int n = 9;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n - i; j++)
        {
            Console.Write("*");

        }

        Console.WriteLine(" ");
    }
}



//4
void JiSuanJieGuo()
{
    double sum = 0;
    double s = 1;

    for (double j = 1; j <= 100; j++)
    {
        if (j % 2 == 0)
        {
            s = 1 / j * (-1);
        }
        else
        {
            s = 1 / j;
        }
        //Console.WriteLine(s);
        sum += s;
    }
    Console.WriteLine(sum);
}


//5

void JieCheng()
{
    long n = 1;
    long sum = 0;
    for (int j = 1; j <= 10; j++)
    {
        n *= j;
        //Console.WriteLine(n);
        sum += n;
    }
    Console.WriteLine(sum);

}

//6
void LanQiu()
{
    int i = 0;
    for (double h = 5; h > 0.1; h *= 0.3)
    {
        i++;
    }
    Console.WriteLine(i);
}


//7

void JISuanQiPan()
{
    double g = 0.00001;
    double sum = 0;
    for (long i = 0; i < 64; i++)
    {
        sum += Math.Pow(2, i);

    }

    Console.WriteLine(sum * g);
}


/*0  1  20
1  2  21
2  4  22
3 8   23 
4  16   24*/


//8

void JiSuanCunKuan()
{
    double money = 50000;
    int n = 0;
    for (int i = 1; money > 5000; i++)
    {
        money -= money * 0.05;
        n++;
        Console.WriteLine(money);
    }
    Console.WriteLine("手续费扣除" + n + "次");

}



/*
        50000
 1  50000*0.05  
 2  50000*0.05*0.05
3
 
 
 */

//9

void ZhaiTao()
{
    double x = 1;
    for (int i = 1; i < 7; i++)
    {
        x = (x + 1) * 2;
    }
    Console.WriteLine(x);
}



/*
x x/2-1
a+1)*2

7   1                                               1
6   1 +1）*2                         2*2             4
5   1 +1）*2  +1）*2                  2*2+1）*2    
4   1 +1）*2  +1）*2 +1）*2            2*2+1）
//382

 */


//10
void PiQiu()
{
    double h = 0;
    double sum = 0;
    for (int i = 1; i <= 9; i++)
    {
        h += 10 / Math.Pow(2, i);
    }
    sum = h * 2 + 10;
    Console.WriteLine(sum);
}





/*
1   10                  10   0
2   10/2+10/2           5    5
3   10/2/2+10/2/2       2.5  2.5


 */