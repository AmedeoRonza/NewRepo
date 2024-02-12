using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Menu
    {
        private string _nomePiatto;
        private decimal _costoPiatto;
        private static List<Menu> _piattoScelto = new List<Menu>();

        public string NomePiatto
        {
            get
            {
                return _nomePiatto;
            }
            set
            {
                _nomePiatto = value;
            }
        }
        public decimal CostoPiatto
        {
            get
            {
                return _costoPiatto;
            }
            set
            {
                _costoPiatto = value;
            }
        }
        public static List<Menu> PiattoScelto
        {
            get
            {
                return _piattoScelto;
            }
            set
            {
                _piattoScelto = value;
            }
        }
        public Menu(string nomepiatto, decimal costo)
        {
            _nomePiatto = nomepiatto;
            _costoPiatto = costo;
        }
        public static void ScriviContoFinale()
        {
            decimal contoFinale = 0;
            decimal servizio = 3;

            Console.WriteLine("======Il tuo conto:======");
            Console.WriteLine("PIATTI SCELTI");
            foreach (Menu m in Menu.PiattoScelto)
            {
                Console.WriteLine($"{m.NomePiatto} - € {m.CostoPiatto}");
                contoFinale += m.CostoPiatto;
            }
            Console.WriteLine($"Servizio: {servizio}");
            Console.WriteLine($"Totale Conto: {(contoFinale + servizio)}");
            Console.WriteLine("Grazie per averci scelto!");
            Console.ReadLine();
        }
    }
}
