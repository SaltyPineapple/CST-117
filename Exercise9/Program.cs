using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//
// Corrected by Mark Pratt, 4/26/2020
//

namespace CST117_IC08_console
{
    class Program
    {
        static void Main(string[] args)
        {
            //make some sets
            Set A = new Set();
            Set B = new Set();

            //put some stuff in the sets
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                A.addElement(r.Next(4));
                B.addElement(r.Next(12));
            }

            //display each set and the union
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            Console.WriteLine("A union B: " + A.union(B));

            //display original sets (should be unchanged)
            Console.WriteLine("After union operation");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);

        }
    }
    class Set
    {
        private List<int> elements;


        public Set()
        {
            elements = new List<int>();
        }

        public bool addElement(int val)
        {
            // ERROR 1
            // returning false before inner code can execute
            // causing no elements to be added to set
            

            /*if (!containsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }*/

            if (!containsElement(val))
            {
                elements.Add(val);
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool containsElement(int val)
        {
            // ERROR 2
            // Method returning false before all elements of set have been checked

            for (int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i])
                    return true;
                /*else
                    return false;*/
            }
            return false;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet()
        {
            elements.Clear();
        }

        public Set union(Set rhs)
        {

            // Error 3
            // Adding elements to set A, this, instead of creating new union set

            Set newSet = new Set();

            // This just copies the initial set into the new set.
            for(int i = 0; i< this.elements.Count; i++)
            {
                newSet.addElement(this.elements[i]);
            }

            for (int i = 0; i < rhs.elements.Count; i++)
            {
                //this.addElement(rhs.elements[i]);
                newSet.addElement(rhs.elements[i]);
            }
            return newSet;

            

        }
    }

}
