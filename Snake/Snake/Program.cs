using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Program
	{
		static void Main( string[] args )
		{


			Point p1 = new Point( 1, 3, '*' );
			Move( p1, 10, 10 );
			Console.WriteLine( "Call Move. p1.x = " + p1.x + ", p1.y = " + p1.y );

			Point p2 = new Point( 4, 5, '#' );
			p1 = p2;
			p2.x = 8;
			p2.y = 8;
			Console.WriteLine( "p1 = p2. p1.x = " + p1.x + ", p1.y = " + p1.y + "; p2.x = " + p2.x + ", p2.y = " + p2.y );

			p1 = new Point( 1, 3, '*' );
			Update( p1 );
			Console.WriteLine( "Call update. p1.x = " + p1.x + ", p1.y = " + p1.y );

		    List<char> numList = new List<char>();
		    numList.Add('q');
		    numList.Add('w');
		    numList.Add('e');

		 foreach (var i in numList)
		    {
		        Console.WriteLine(i);
		    }

		    numList.RemoveAt(0);





		    List<char> symbs = new List<char>();
		    symbs.Add('$');
		    symbs.Add('^');
		    symbs.Add('#');

		    foreach (var j in symbs)
		    {
		        Console.WriteLine(j);
		    }

		    List<Point> pList = new List<Point>();
		    pList.Add(p1);
		    pList.Add(p2);


		}

		public static void Func1( int value )
		{
			
		}

		public static void Func2( int value )
		{
			value = value + 1;
		}



		public static void Move( Point p, int dx, int dy )
		{
			p.x = p.x + dx;
			p.y = p.y + dy;
		}

		public static void Update( Point p )
		{
			p = new Point();  // обнуляет значения по указателю p
		    Console.WriteLine( "Call update. p.x = " + p.x + ", p.y = " + p.y );
		}


	}
}
