using System;

namespace _1_6._4_打印正弦函数
{
    /* 正弦函数的逻辑是每一行前面打印sin函数个空格，后面加上一个*
     * int n 就是前面空的部分，在列打印结束后面再打印一个*
     * Sin后面的类型是double类型，所以需要强转化成int类型
     * 之所以取i的值需要乘0.1是因为sin函数的对称轴到原点的位置大约是2/π，所以大约是1.4,所以i的取值越细致，越能看清楚变化，这里如果试一下0.05和0.1就能看出差异性了
     * 因为正常只能打印一半，所以需要在往右边移动30个单位
    */

    class Program
    {
        static void SinGraph()
        {
            for (int i = 0; i < 200; i++)    // 200行
            {
                int n = (int)(Math.Sin(i*0.1) * 30 + 30);   
                for(int j = 0;j < n;j++ ) 
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            SinGraph();
        }
    }
}
