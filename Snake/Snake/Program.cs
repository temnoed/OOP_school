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
			Point p1 = new Point( 10, 10, '*' );
			Point p2 = new Point( 11, 11, '#' );

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

		    foreach (var i in pList)
		    {
		        i.Draw();
		    }



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
