using Hjælp_Lone.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hjælp_Lone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainController mainController = new MainController();
            mainController.StartController();
        }
    }
}
