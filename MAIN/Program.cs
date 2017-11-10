using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text; 
using System.Xml; 
using System.Xml.Linq;
using System.Collections;
using GetData;

namespace PresentData
{
    class Program
    {
   

            static void Main(string[] args)
            {

            var parser = new Parser(new Data(),new Liczenie());
            parser.Liczenie();
            Console.ReadKey();
         
            
        }

        
    }
}
