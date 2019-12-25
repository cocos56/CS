using System;

namespace _03接口练习_多态
{
	//什么时候用虚方法实现多态？
	//什么时候用抽象类实现多态？
	//什么时候用接口实现多态？
	class Program
	{
		static void Main(string[] args)
		{
			//麻雀会飞 鹦鹉会飞会说话 鸵鸟不会飞 企鹅不会飞会游泳 直升机会飞
			//用多态来实现（虚方法 抽象类 接口）
			IFlyable fly = new Plane();//new YingWu();//new MaQue();
			fly.Fly();
			//ISpeakable speak = new YingWu();
			//speak.Speak();
			
		}

	}

	//当抽象类中的方法都是抽象方法的时候，就可以将抽象类改为接口
	public interface IFlyable
	{
		void Fly();
	}
	public interface ISpeakable
	{
		void Speak();
	}
	public interface ISwimable
	{
		void Swim();
	}
	public class Bird
	{
		public double Wings { get; set; }//自动属性
		public void EatAndDrink()
		{
			Console.WriteLine("我会吃喝");
		}
	}
	public class MaQue : Bird, IFlyable
	{
		public void Fly()
		{
			Console.WriteLine("麻雀会飞");
		}
	}
	public class YingWu : Bird, ISpeakable,IFlyable
	{
		public void Speak()
		{
			Console.Write("鹦鹉会说话\t");
		}

		public void Fly()
		{
			Console.WriteLine("鹦鹉会飞");
		}
	}
	public class TuoBird : Bird
	{ }
	public class QQ : Bird, ISwimable
	{
		public void Swim()
		{
			Console.WriteLine("企鹅会游泳");
		}
	}
	public class Plane : Bird, IFlyable
	{
		public void Fly()
		{
			Console.WriteLine("直升飞机转动螺旋桨进行飞翔");
		}
	}
}