using System;
using System.Threading;

namespace _07�����ӡ1_100
{
    //������ϰ��д�����̣߳������ӡ1-100����˭��ִ����
    //ThreadState������״̬������״̬������start����֮ǰ�� ����״̬������start����֮�� ����״̬�����н���֮�� ����״̬����ָ�߳��ڵȴ�һ���¼�����ĳ���ź��������߼��ϲ���ִ�У�

    class Program
    {
        static int a = 0;
        static bool b = true;
        static void Main(string[] args)
        {
            Thread t1 = new Thread(M);
            t1.Name = "t1";
            Thread t2 = new Thread(M);
            t2.Name = "--";
            t1.Priority = ThreadPriority.Highest;//�߳����ȼ������������ȼ�
            t1.Start();//֪ͨcpu�߳�t1׼����
            t2.Start();//֪ͨcpu�߳�t2׼����
            Console.ReadKey();

        }
        public static void M()
        {
            //��һ���̴߳ﵽ50ʱ����һ���߳���ֹ
            for (int i = 1; i < 51; i++)
            {
                Thread.Sleep(1);
                if (b)
                {
                    if (i == 50)
                    {
                        b = false;
                    }
                    a++;
                    Console.WriteLine(Thread.
                        CurrentThread.Name + ":" + a);//�õ���ǰ�߳�����Thread.CurrentThread.Name                    
                }
            }
        }
    }
}