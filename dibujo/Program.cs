/*
 * Created by SharpDevelop.
 * User: CELERON
 * Date: 4/7/2018
 * Time: 23:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace dibujo
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.BackgroundColor=ConsoleColor.White;
			Console.Clear();
			
			char tecla;
			
			do{
				tecla=Console.ReadKey(true).KeyChar;
				switch(tecla)
				{
						case 'a': Console.SetCursorPosition(50,0);animacionu(); break;
						case 'w':Console.BackgroundColor=ConsoleColor.White;Console.Clear();break;
			}
			}while(tecla!='q');
			Console.ReadKey();
		}
		public static void animacionu ()
		{ int n=900;
			//girar izquierda
			//cabeza
			System.Threading.Thread.Sleep(n);
			dibujaraskcaminando(12,50,6,ConsoleColor.Black, ConsoleColor.Black);
			//un cubito
			System.Threading.Thread.Sleep(n);
			dibujaraskcaminando(2,48,7,ConsoleColor.Black, ConsoleColor.Black);
			//linea roja
			System.Threading.Thread.Sleep(n);
			dibujaraskcaminando(12,50,7,ConsoleColor.Black, ConsoleColor.Red);
			System.Threading.Thread.Sleep(n);
			dibujaraskcaminando(2,62,7,ConsoleColor.Black, ConsoleColor.Black);
			System.Threading.Thread.Sleep(n);
			dibujaraskcaminando(2,46,8,ConsoleColor.Black, ConsoleColor.Black);
			System.Threading.Thread.Sleep(n);
			dibujaraskcaminando(16,48,8,ConsoleColor.Black, ConsoleColor.Red);
			System.Threading.Thread.Sleep(n);
			dibujaraskcaminando(2,64,8,ConsoleColor.Black, ConsoleColor.Black);
			//cuarta linea
			System.Threading.Thread.Sleep(n);
			dibujaraskcaminando(2,46,9,ConsoleColor.Black, ConsoleColor.Black);
			dibujaraskcaminando(14,48,9,ConsoleColor.Black, ConsoleColor.Red);
			dibujaraskcaminando(4,64,9,ConsoleColor.Black, ConsoleColor.Black);
			//quinta linea
			System.Threading.Thread.Sleep(n);
			dibujaraskcaminando(6,44,10,ConsoleColor.Black, ConsoleColor.Black);
			dibujaraskcaminando(10,50,10,ConsoleColor.Black, ConsoleColor.Red);
			dibujaraskcaminando(2,68,10,ConsoleColor.Black, ConsoleColor.Black);
			//sexta linea
			System.Threading.Thread.Sleep(n);
			dibujaraskcaminando(14,44,11,ConsoleColor.Black, ConsoleColor.Black);
			dibujaraskcaminando(10,58,11,ConsoleColor.Black, ConsoleColor.Red);
			dibujaraskcaminando(4,64,11,ConsoleColor.Black, ConsoleColor.Black);
			//septima linea
			System.Threading.Thread.Sleep(n);
			dibujaraskcaminando(12,44,12,ConsoleColor.Black, ConsoleColor.Black);
			dibujaraskcaminando(2,60,12,ConsoleColor.Black, ConsoleColor.Black);
			dibujaraskcaminando(2,64,12,ConsoleColor.Black, ConsoleColor.Black);
			//octava linea
			System.Threading.Thread.Sleep(n);
			dibujaraskcaminando(4,46,13,ConsoleColor.Black, ConsoleColor.Black);
			dibujaraskcaminando(2,54,13,ConsoleColor.Black, ConsoleColor.Black);
			dibujaraskcaminando(2,60,13,ConsoleColor.Black, ConsoleColor.Black);
			dibujaraskcaminando(2,64,13,ConsoleColor.Black, ConsoleColor.Black);
			//novena linea
			System.Threading.Thread.Sleep(n);
			dibujaraskcaminando(2,48,14,ConsoleColor.Black, ConsoleColor.Black);
			dibujaraskcaminando(2,64,14,ConsoleColor.Black, ConsoleColor.Black);
			//decima linea
			System.Threading.Thread.Sleep(n);
			dibujaraskcaminando(2,46,15,ConsoleColor.Black, ConsoleColor.Black);
			dibujaraskcaminando(2,48,15,ConsoleColor.Black, ConsoleColor.DarkCyan);
			dibujaraskcaminando(4,50,15,ConsoleColor.Black, ConsoleColor.Black);
			dibujaraskcaminando(2,62,15,ConsoleColor.Black, ConsoleColor.Black);
			//onceava linea
			System.Threading.Thread.Sleep(n);
			dibujaraskcaminando(2,46,16,ConsoleColor.Black, ConsoleColor.Black);
			dibujaraskcaminando(2,48,16,ConsoleColor.Black, ConsoleColor.DarkCyan);
			dibujaraskcaminando(4,50,16,ConsoleColor.Black, ConsoleColor.Black);
			dibujaraskcaminando(8,54,16,ConsoleColor.Black, ConsoleColor.Black);
			//doceava linea
			System.Threading.Thread.Sleep(n);
			dibujaraskcaminando(4,46,17,ConsoleColor.Black, ConsoleColor.Black);
			dibujaraskcaminando(12,54,17,ConsoleColor.Black, ConsoleColor.Black);
			//treceava linea
			System.Threading.Thread.Sleep(n);
			dibujaraskcaminando(2,48,18,ConsoleColor.Black, ConsoleColor.Black);
			dibujaraskcaminando(2,44,18,ConsoleColor.Black, ConsoleColor.Black);
			dibujaraskcaminando(2,54,18,ConsoleColor.Black, ConsoleColor.Black);
			dibujaraskcaminando(2,60,18,ConsoleColor.Black, ConsoleColor.Black);
			dibujaraskcaminando(2,66,18,ConsoleColor.Black, ConsoleColor.Black);
			//catorceava linea
			System.Threading.Thread.Sleep(n);
			dibujaraskcaminando(2,44,19,ConsoleColor.Black, ConsoleColor.Black);
			dibujaraskcaminando(10,50,19,ConsoleColor.Black, ConsoleColor.Black);
			dibujaraskcaminando(2,64,19,ConsoleColor.Black, ConsoleColor.Black);
			//quinceava linea
			System.Threading.Thread.Sleep(n);
			dibujaraskcaminando(4,46,20,ConsoleColor.Black, ConsoleColor.Black);
			dibujaraskcaminando(6,58,20,ConsoleColor.Black, ConsoleColor.Black);
		    
		}
		
		public static void dibujaraskcaminando(int ancho,  int x, int y, ConsoleColor unColor, ConsoleColor bacolor)
		{
			int cont=0;
			while(cont<ancho)
			{
				
			
				Console.BackgroundColor=unColor;
				Console.ForegroundColor=bacolor;
				Console.SetCursorPosition(x+cont,y);
				Console.Write("█");
			

				cont++;
			}
			
		}
	}
}