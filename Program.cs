using System;

namespace Probleme_Set_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Load();
        }

        private static void Question()
        {
            Console.WriteLine();
            Console.Write("Doriti sa incercati o alta problema (DA/NU): ");
            string answer = Console.ReadLine();
            if (answer.Equals("Da", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.Clear(); Load();
            }
            else
            {
                if (answer.Equals("Nu", StringComparison.CurrentCultureIgnoreCase))
                    return;
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Input invalid. Incercati din nou.");
                    Question();
                }
            }
        }

        private static void Load()
        {
            Console.WriteLine("Probleme - setul 3");
            Console.WriteLine();
            Console.Write("Introduce-ti numarul problemei dorite (1-31) sau cifra '0' pentru a inchide consola: ");
            string nrprob = Console.ReadLine();
            Console.WriteLine();
            switch (nrprob)
            {
                case "0": return;
                case "1": Prob1(); break;
                case "2": Prob2(); break;
                case "3": Prob3(); break;
                case "4": Prob4(); break;
                case "5": Prob5(); break;
                case "6": Prob6(); break;
                case "7": Prob7(); break;
                case "8": Prob8(); break;
                case "9": Prob9(); break;
                case "10": Prob10(); break;
                case "12": Prob12(); break;
                case "13": Prob13(); break;
                case "14": Prob14(); break;
                case "15": Prob15(); break;
                default: Console.WriteLine("Input invalid. Incercati din nou."); Console.WriteLine(); Load(); break;
            }
        }

        private static void Prob1()
        {
            Console.WriteLine("Problema 1: Calculati suma elementelor unui vector de n numere citite de la tastatura.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'n': ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int suma = 0;
            Console.Write($"Introduce-ti cele {n} elemente ale vectorului: ");
            string secventa = Console.ReadLine();
            for (int i=0; i<n; i++)
            {
                v[i] = int.Parse(secventa.Split(' ')[i]);
                suma += v[i];
            }
            Console.WriteLine($"Suma elementelor vectorului este {suma}.");
            Question();
        }

        private static void Prob2()
        {
            Console.WriteLine("Problema 2: Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'n': ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.Write($"Introduce-ti cele {n} elemente ale vectorului: ");
            string secventa = Console.ReadLine();
            Console.Write("Introduce-ti variabila 'k': ");
            int k = int.Parse(Console.ReadLine());
            int poz = -1;
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(secventa.Split(' ')[i]);
                if(v[i]==k)
                {
                    poz = i + 1;
                    break;
                }
            }
            Console.WriteLine($"Elementul 'k' se afla pe pozitia {poz}.");
            Question();
        }

        private static void Prob3()
        {
            Console.WriteLine("Problema 3: Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'n': ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.Write($"Introduce-ti cele {n} elemente ale vectorului: ");
            string secventa = Console.ReadLine();
            v[0] = int.Parse(secventa.Split(' ')[0]);
            int maximum = v[0], minimum = v[0], pozmax = 1, pozmin = 1;
            for (int i = 1; i < n; i++)
            {
                v[i] = int.Parse(secventa.Split(' ')[i]);
                if(v[i] < minimum)
                {
                    minimum = v[i];
                    pozmin = i;
                }
                if (v[i] > maximum)
                {
                    maximum = v[i];
                    pozmax = i;
                }
            }
            Console.WriteLine($"Cel mai mare element al vectorului se afla pe pozitia {pozmax}, cel mai mic element al vectorului se afla pe pozitia {pozmin}.");
            Question();
        }

        private static void Prob4()
        {
            Console.WriteLine("Problema 4: Determinati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'n': ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.Write($"Introduce-ti cele {n} elemente ale vectorului: ");
            string secventa = Console.ReadLine();
            v[0] = int.Parse(secventa.Split(' ')[0]);
            int maximum = v[0], minimum = v[0], contormax = 1, contormin = 1;
            for (int i = 1; i < n; i++)
            {
                v[i] = int.Parse(secventa.Split(' ')[i]);
                if (v[i] < minimum)
                {
                    minimum = v[i];
                    contormin = 1;
                }
                else if (v[i] == minimum) contormin++;

                if (v[i] > maximum)
                {
                    maximum = v[i];
                    contormax = 1;
                }
                else if (v[i] == maximum) contormax++;
            }
            Console.WriteLine($"Cel mai mare element al vectorului este {maximum} si apare de {contormax} ori in vector, cel mai mic element al vectorului este {minimum} si apare de {contormin} ori.");
            Question();
        }

        private static void Prob5()
        {
            Console.WriteLine("Problema 5: Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'n': ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n+1];
            Console.Write($"Introduce-ti cele {n} elemente ale vectorului: ");
            string secventa = Console.ReadLine();
            Console.Write("Introduce-ti variabila 'e': ");
            int e = int.Parse(Console.ReadLine());
            Console.Write("Introduce-ti pozitia 'k': ");
            int k = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(secventa.Split(' ')[i]);
            }

            for (int i=n; i>=k+1; i--)
            {
                v[i] = v[i - 1];
            }
            v[k] = e;

            Console.WriteLine("Afisare vector:");
            for (int i = 0; i <= n; i++)
                Console.Write(v[i] + " ");
            Question();
        }

        private static void Prob6()
        {
            Console.WriteLine("Problema 6: Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k. Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'n': ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.Write($"Introduce-ti cele {n} elemente ale vectorului: ");
            string secventa = Console.ReadLine();
            Console.Write("Introduce-ti pozitia 'k': ");
            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(secventa.Split(' ')[i]);
            }

            for(int i=k; i<n-1; i++)
            {
                v[i] = v[i + 1];
            }
            n--;

            Console.WriteLine("Afisare vector:");
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");

            Question();
        }

        private static void Prob7()
        {
            Console.WriteLine("Problema 7: Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'n': ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.Write($"Introduce-ti cele {n} elemente ale vectorului: ");
            string secventa = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                v[n-1-i] = int.Parse(secventa.Split(' ')[i]);
            }

            Console.WriteLine("Afisare vector:");
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");

            Question();

        }

        private static void Prob8()
        {
            Console.WriteLine("Problema 8: Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'n': ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.Write($"Introduce-ti cele {n} elemente ale vectorului: ");
            string secventa = Console.ReadLine();
            v[n - 1] = int.Parse(secventa.Split(' ')[0]);
            for(int i=0; i<n-1; i++)
            {
                v[i] = int.Parse(secventa.Split(' ')[i+1]);
            }

            Console.WriteLine("Afisare vector:");
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
            Console.WriteLine();

            Question();
        }

        private static void Prob9()
        {
            Console.WriteLine("Problema 9: Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'n': ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.Write($"Introduce-ti cele {n} elemente ale vectorului: ");
            string secventa = Console.ReadLine();
            Console.Write("Introduce-ti variabila 'k': ");
            int k = int.Parse(Console.ReadLine());
            for(int i=0; i<k; i++)
            {
                v[n-k+i]= int.Parse(secventa.Split(' ')[i]);
            }

            for(int i=0; i<n-k; i++)
            {
                v[i]= int.Parse(secventa.Split(' ')[i + k]);
            }

            Console.WriteLine("Afisare vector:");
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
            Console.WriteLine();

            Question();
        }

        private static void Prob10()
        {
            Console.WriteLine("Problema 10: Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'n': ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.Write($"Introduce-ti cele {n} elemente ale vectorului: ");
            string secventa = Console.ReadLine();
            Console.Write("Introduce-ti variabila 'k': ");
            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(secventa.Split(' ')[i]);
            }

            int poz = -1, l = 0, r = n, m;
            while(l<r)
            {
                m = (l + r) / 2;
                if(v[m]==k)
                {
                    poz = m;
                    break;
                }
                if (v[m] > k)
                    r = m - 1;
                if (v[m] < k)
                    l = m + 1;
            }

            Console.WriteLine($"Elementul 'k' se afla pe pozitia {poz}.");
            Question();
        }

        private static bool Prim(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n != 2 && n % 2 == 0) return false;
            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        private static void Prob12()
        {
            Console.WriteLine("Problema 12: Sortare selectie.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'n': ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int temp = 0, minpoz;
            Console.Write($"Introduce-ti cele {n} elemente ale vectorului: ");
            string secventa = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(secventa.Split(' ')[i]);
            }

            for(int i=0; i<n-1; i++)
            {
                minpoz = i;
                for(int j=i+1; j<n; j++)
                {
                    if (v[minpoz] > v[j])
                        minpoz = j;
                }

                if(minpoz!=i)
                {
                    temp = v[i];
                    v[i] = v[minpoz];
                    v[minpoz] = temp;
                }
            }

            Console.WriteLine("Afisare vector:");
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
            Console.WriteLine();

            Question();
        }

        private static void Prob13()
        {
            Console.WriteLine("Problema 13: Sortare prin insertie.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'n': ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int temp, i, j;
            Console.Write($"Introduce-ti cele {n} elemente ale vectorului: ");
            string secventa = Console.ReadLine();
            for (i = 0; i < n; i++)
            {
                v[i] = int.Parse(secventa.Split(' ')[i]);
            }

            for(i=1; i<n; i++)
            {
                temp = v[i];
                j = i - 1;
                while(temp<=v[j] && j>=0)
                {
                    v[j + 1] = v[j];
                    j = j-1;
                }
                v[j + 1] = temp;
            }

            Console.WriteLine("Afisare vector:");
            for (i = 0; i < n; i++)
                Console.Write(v[i] + " ");
            Console.WriteLine();

            Question();
        }

        private static void Prob14()
        {
            Console.WriteLine("Problema 14: Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'n': ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.Write($"Introduce-ti cele {n} elemente ale vectorului: ");
            string secventa = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(secventa.Split(' ')[i]);
            }

            int temp, contor=0;
            for (int i = 0; i < n; i++)
            {
                if (v[i] == 0)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        temp = v[j];
                        v[j] = v[j - 1];
                        v[j - 1] = temp;
                    }
                    contor++;
                }
                else contor = 0;

                if (contor > 0)
                {
                    for(int aux=0; aux<contor; aux++)
                    if (v[i - 1] == 0)
                    {
                        for (int j = i; j < n; j++)
                        {
                            temp = v[j];
                            v[j] = v[j - 1];
                            v[j - 1] = temp;
                        }
                    }
                }


            }

            Console.WriteLine("Afisare vector:");
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
            Console.WriteLine();
            Question();
        }

        private static void Prob15()
        {
            Console.WriteLine("Problema 15: Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'n': ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.Write($"Introduce-ti cele {n} elemente ale vectorului: ");
            string secventa = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(secventa.Split(' ')[i]);
            }

            for(int i=0; i<n-1; i++)
            {
                for(int j=i+1; j<n; j++)
                {
                    if(v[i]==v[j])
                    {
                        while(j<n-1)
                        {
                            v[j] = v[j + 1];
                            j++;
                        }
                        n--;
                    }
                }
            }
            Console.WriteLine("Afisare vector:");
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
            Console.WriteLine();

            Question();
        }

    }
}
