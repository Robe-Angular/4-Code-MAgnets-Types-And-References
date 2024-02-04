using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Code_MAgnets_Types_And_References
{

    class Class1
    {
        double area;
        int height;
        int length;
        public static void Main(String[] args)
        {
            string results = "";
            //No sé
            Class1[] ta = new Class1[4];
            int x = 0;
            while (x < 4)
            {
                ta[x] = new Class1();
                ta[x].height = (x + 1) * 2;
                ta[x].length = (x + 4);
                ta[x].setArea();
                results += "triangle " + x + ", area";
                results += " = " + ta[x].area + "\n";
                x = x + 1;
            }
            int y = x;
            x = 27;
            Class1 t5 = ta[2];
            ta[2].area = 343;
            results += "y = " + y;
            MessageBox.Show(results +
                ", t5 area = " + t5.area);

        }
        void setArea()
        {
            area = (height * length) / 2;
        }

    }
}
