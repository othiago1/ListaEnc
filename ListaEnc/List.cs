using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEnc
{
    class List
    {
        public Element lastOne;
        public Element firstOne;

        public int index;

        public void Add(int i)
        {
            Console.WriteLine("Teste");
            Console.ReadKey();

            Element newElement = new Element();
            Element aux = new Element();


            if (index.Equals(0))
                {
                    newElement.i = i;
                    newElement.next = null;

                    lastOne = newElement;
                    firstOne = newElement;

                    index++;
                }
            else
                {
                    while (aux != null)
                    {
                        aux = aux.next;
                    }

                    newElement.i = i;
                    newElement.next = null; 
                    aux.next = newElement;

                    lastOne = newElement;
                
                    index++;
                }
            
        }

    }
}
