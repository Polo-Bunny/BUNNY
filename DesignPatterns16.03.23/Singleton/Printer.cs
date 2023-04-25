using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns16._03._23.Singleton
{
    internal class Printer

    {
        //Printer p1 = new Printer();
        private string model;
        private  static Printer objPrinter;

        public string sModel
        {
            get { return model;  }
            set { model = value; }

        }

        public static Printer GetInstance() 
        { 
            if(objPrinter == null)
            {
                objPrinter = new Printer();
            }
            return objPrinter; 
        } 
        private Printer()
        {

        }
    }
}
