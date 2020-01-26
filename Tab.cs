using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskanje
{
    public class Tab
    {
        private int[] tabela = new int[100];
        int dolzina;

        public Tab()
        {
            Random rnd = new Random();

            for(int i = 0; i < tabela.Length; i++)
            {
                tabela[i] = rnd.Next(1000);
            }
        }

        public void Dodaj(int x)
        {
            int[] temp = new int[tabela.Length];
            temp = tabela;
            tabela = new int[temp.Length + 1];
            for(int i = 0; i < temp.Length; i++)
            {
                tabela[i] = temp[i];
            }
            tabela[temp.Length] = x;
        }

        public void quickSort()
        {
            Array.Sort(tabela);
        }

        public bool Vsebuje(int x)
        {
            for (int i = 0; i < tabela.Length; i++)
            {
                if(tabela[i] == x)
                {
                    return true;
                }
            }
            return false;
        }

        public string ToString()
        {
            string num = "";

            for(int i = 0; i < tabela.Length; i++)
            {
                if(num == "")
                {
                    num = num + tabela[i];
                }
                num = num + "," + tabela[i];
            }

            return num;
        }

        public int Vsota()
        {
            int vsota = 0;

            for (int i = 0; i < tabela.Length; i++)
            {
                vsota = vsota + tabela[i];        
            }

            return vsota;
        }

        public int Min()
        {
            return tabela.Min();
        }

        public int Max()
        {
            return tabela.Max();
        }

        public double Povprecje()
        {
            return tabela.Average();
        }

        public bool VsebujeBinarno(int x)
        {
            int low = 0;
            int high = tabela.Length - 1;
            int mid;

            while (low <= high)
            {
                mid = (low + high) / 2;

                if (x < tabela[mid])
                {
                    high = mid - 1;
                }
                else if (x > tabela[mid])
                {
                    low = mid + 1;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        public void UrediMehurcki()
        {
            int temp = 0;

            for (int write = 0; write < tabela.Length; write++)
            {
                for (int sort = 0; sort < tabela.Length - 1; sort++)
                {
                    if (tabela[sort] > tabela[sort + 1])
                    {
                        temp = tabela[sort + 1];
                        tabela[sort + 1] = tabela[sort];
                        tabela[sort] = temp;
                    }
                }
            }
        }

        public void DodajInUredi(int x)
        {
            Dodaj(x);

            int temp, j;

            for (int i = 1; i < tabela.Length; i++)
            {
                temp = tabela[i];
                j = i - 1;

                while (j >= 0 && tabela[j] > temp)
                {
                    tabela[j + 1] = tabela[j];
                    j--;
                }

                tabela[j + 1] = temp;
            }
        }

        public void Uredi()
        {
            int n = tabela.Length;
            int temp, smallest;

            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (tabela[j] < tabela[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = tabela[smallest];
                tabela[smallest] = tabela[i];
                tabela[i] = temp;
            }
        }
    }
}
