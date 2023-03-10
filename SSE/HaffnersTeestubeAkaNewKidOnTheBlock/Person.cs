using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SSE
    {
    internal class Person
        {
        //Member: Mitglied einer klasse, kann jedes beliebege element sein
        //fields
        public string name;
        public DateTime gebDat;
        public Adress adr;

        //Zugriffsmodifikatoren: public => öffentliche r Zugriff von überall
        //private => Zugriff nur innerhalb der EIGENEN Klasse
        // internal => Innerhalb des gleichen namesspace und des assemblys
        //protected => Zugriff nur innerhalb der eigenen klasse & aller ageleiteter Klassen

        //Kontsruktoren
        /// <summary>
        /// /Das ist ein leerer Konktruktor. Den kann man füllen wie druben
        /// </summary>
        public Person() { }
        /// <summary>
        /// Das ist ein richtiger Konstruktor. Er verlangt parameter
        /// </summary>
        /// <param name="name"></param>
        /// <param name="gebDat"></param>
        /// <param name="adr"></param>
        public Person(string name,DateTime gebDat,Adress adr)
            {
            this.name = name;
            this.gebDat = gebDat;
            this.adr = adr;
            }
        }
    }
