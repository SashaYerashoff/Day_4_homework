using System;

namespace Day_4_homework
{
    class Program
    {
        static void Main(string[] args)
        {
			BanknotesFcija(); //pirmais izsaukums banknotem

			string yesno;
			Console.WriteLine("Ja vēlies turpināt, ieraksti - yes:");
            yesno = Console.ReadLine(); //pirma yesno piešķiršana

			while(yesno =="yes")
			{
				BanknotesFcija();//cilpas izsaukums banknotēm
				Console.WriteLine("Ja vēlies turpināt, ieraksti - yes:");
			    yesno = Console.ReadLine(); //kamēr "yes", tikmēr cilpos     
			}
           

        }

		static void BanknotesFcija() //switch priekš banknotem un input
		{
			string input;

			Console.WriteLine("Lūdzu ievadi dollāra banknotes nominālu: ");
			input = Console.ReadLine();

			switch (input)
			{
				case "1":
					Console.WriteLine("Tu ievadīji banknoti ar nominālu: ${0}", input);
					break;
				case "2":
					Console.WriteLine("Tu ievadīji banknoti ar nominālu: ${0}", input);
                    break;
				case "5":
                    Console.WriteLine("Tu ievadīji banknoti ar nominālu: ${0}", input);
                    break;
				case "10":
                    Console.WriteLine("Tu ievadīji banknoti ar nominālu: ${0}", input);
                    break;
				case "20":
                    Console.WriteLine("Tu ievadīji banknoti ar nominālu: ${0}", input);
                    break;
				case "50":
                    Console.WriteLine("Tu ievadīji banknoti ar nominālu: ${0}", input);
                    break;
				case "100":
                    Console.WriteLine("Tu ievadīji banknoti ar nominālu: ${0}", input);
                    break;
				default:
					Console.WriteLine("diemžēl es nevaru atpazīt tādu banknoti");
					break;
					
			}

		}
    }
}
