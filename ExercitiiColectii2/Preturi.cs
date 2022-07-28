using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercitiiColectii2
{
    internal class Preturi
    {
        private List <double> listaPreturi;
        public Preturi()
        {
            this.listaPreturi = new List<double>();
        }

        public void adaugarePret(double pret)
        {
            listaPreturi.Add(pret);
        }

        public void afisareListaPreturi()
        {
            foreach(double element in listaPreturi)
            {
                Console.WriteLine(element);
            }
        }

        public override string ToString()
        {
            string preturiElemente = "";
            foreach(double element in listaPreturi)
            {
                preturiElemente = preturiElemente + " " + element.ToString();
            }
            return preturiElemente;
        }

        public void stergerePrimulElement()
        {
            listaPreturi.RemoveAt(0);
        }

        public void stergereUltimulElement()
        {
            listaPreturi.RemoveAt(listaPreturi.Count() - 1);
        }

        public void sortareListaDePreturiCrescator()
        {
            listaPreturi.Sort();
        }

        public void sortareListaDePreturiDescrescator()
        {
            listaPreturi.Sort();
            listaPreturi.Reverse();
        }

        public double getElementAt(int pozitie)
        {
            return listaPreturi[pozitie];
        }

        public double getTotal()
        {
            return listaPreturi.Sum();
        }

        public int countPreturi()
        {
            return listaPreturi.Count();
        }

        public List<double> getListaPreturiAbove(double pretDeComparat)
        {
            List<double> lista2 = new List<double>();
            foreach(double element in listaPreturi)
            {
                if(pretDeComparat<element)
                {
                    lista2.Add(element);
                }
            }
            return lista2;
        }

        public List<double> getListaPreturiAbove2(double pretDeComparat)
        {
            List<double> lista2 = new List<double>();
            lista2 = listaPreturi.FindAll(pret => pret > pretDeComparat);
            return lista2;

            // return listaPreturi.FindAll(pret => pret > pretDeComparat);
        }

        //O metoda care returneaza cate elemente sunt sub un pret dat
        public int getNumberOfElementsBelow(double pretDeComparat2)
        {
            List<double> lista3 = new List<double>();
            lista3 = listaPreturi.FindAll(pret => pret < pretDeComparat2);
            return lista3.Count();
        }

        //O metoda care returneaza suma elementelor fara cel mai mic element
        
        public double sumWithoutMin()
        {
            double suma;
            List<double> auxiliar = new List<double>(listaPreturi);
            auxiliar.Sort();
            auxiliar.RemoveAt(0);
            return suma = auxiliar.Sum();
        }

        //O metoda care returneaza media celor mai mari trei elemente
        public double mediaCelorMaiMariTreiElemente()
        {
            double media;
            listaPreturi.Sort();
            listaPreturi.RemoveRange(0, 3);
            media = listaPreturi.Sum();
            return media;
        }

        //To do
        //O metoda care returneaza cate elemente sunt sub un pret dat
        //O metoda care returneaza suma elementelor fara cel mai mic element
        //O metoda care returneaza media celor mai mari trei elemente
        //O metoda care returneaza lista primelor cinci elemente

        //Project
        //O aplicatie de stil stackoverflow - forum(useri, posts, comments, votes, etc
    }
}
