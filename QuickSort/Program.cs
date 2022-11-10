using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// kalapos tánc: https://www.youtube.com/watch?v=3San3uKKHgg

namespace QuickSort
{
	class Program
	{
		static void QuickSort(List<int> lista) => QuickSort(lista, 0, lista.Count - 1);
		static void QuickSort(List<int> lista , int e, int v )
		{
			if (e<v)
			{
				(int i, int j) = (e, v); // i és j és két kalap!
				while (i!=j) // amíg a két kalap nem találkozik!
				{
					if (i<j != lista[i]<lista[j]) // amikor nem stimmel és cserélni kell!
					{
						(i, j) = (j, i);  // kalapok cseréje
						(lista[i], lista[j]) = (lista[j], lista[i]); // számok cseréje
					}
					j += i < j ? -1 : 1; // a j mindig közelítsen i felé (virágos kalap mozgása)
				}
				// OSZD MEG ÉS URALKODJ!
				QuickSort(lista, e, i - 1); // elejétől addig, ahova az elem került (de az már nem)
				QuickSort(lista, i+1, v);
			}
		}
		static void Main(string[] args)
		{
			Random r = new Random();
			List<int> lista = new List<int>();
			for (int i = 0; i < 200; i++)
			{
				lista.Add(r.Next(0, 999));
			}

			foreach (int elem in lista)
			{
				Console.Write(elem);
				Console.Write(" ");
			}

			Console.WriteLine("\n----------------------------------------------------");
			QuickSort(lista);

			foreach (int elem in lista)
			{
				Console.Write(elem);
				Console.Write(" ");
			}
		}
	}
}
