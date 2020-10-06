using System;
using System.Collections.Generic;
using System.IO;

namespace VS_10._06
{

    class harcos
    {
        public string nev;
        public int klassz;
        public int alapHp;
        public int alapEro;
        public int alapDef;
        public int xp;
        public int szint;

        public string Nev { get => nev; set => nev = value; }
        public int Klassz { get => klassz; set => klassz = value; }
        public int AlapHp { get => alapHp; set
            {
                if (this.alapHp == 0)
                {
                    this.xp = 0;
                }
                if (this.alapHp > MaxEletero)
                {
                    this.alapHp = MaxEletero;
                }
            } }
        public int AlapEro { get => alapEro; set => alapEro = value; }
        public int AlapDef { get => alapDef; set => alapDef = value; }
        public int Xp
        {
            get => xp;
            set
            {
                if (this.xp == Szintlepes)
                {
                    this.szint++;
                    this.xp = 0;
                    this.alapHp = MaxEletero;
                }
            }
        }
        public int Szintlepes { get => 10 + szint * 5; }
        public int MaxEletero { get => alapHp + szint * 3; }

        public harcos(string nev, int klassz)
        {
            this.Nev = nev;
            this.Klassz = klassz;
            if (klassz == 1)
            {
                this.AlapHp = 30;
                this.AlapEro = 5;
                this.AlapDef = 10;
            }
            else if (klassz == 2)
            {
                this.AlapHp = 15;
                this.AlapEro = 8;
                this.AlapDef = 2;
            }
            else if (klassz == 3)
            {
                this.AlapHp = 10;
                this.AlapEro = 12;
                this.AlapDef = 5;
                //az ijász 2 körig nem sebződik -> tavolrol lő
            }
        }
        public List<harcos> ellenseg = new List<harcos>();
        public void Ellenfel() 
        {
            StreamReader k = new StreamReader("ellenfel.txt");
            while (!k.EndOfStream)
            {
                string [] sor = k.ReadLine().Split(';');
                ellenseg.Add(new harcos(sor[0],Convert.ToInt32(sor[1])));
                int elStat = Convert.ToInt32(sor[1]);
                if (elStat == 1)
                {
                    this.AlapHp = 30;
                    this.AlapEro = 5;
                    this.AlapDef = 10;
                }
                else if (elStat == 2)
                {
                    this.AlapHp = 15;
                    this.AlapEro = 8;
                    this.AlapDef = 2;
                }
                else if (elStat == 3)
                {
                    this.AlapHp = 10;
                    this.AlapEro = 12;
                    this.AlapDef = 5;
                }
            }
            k.Close();
        }
        public override string ToString()
        {
            return string.Format("{0} - LVL:{1} - EXP:{2}/{3} - HP:{4}/{5} - DMG:{6}", this.nev, this.szint, this.xp, this.Szintlepes, this.AlapHp, this.MaxEletero, this.AlapEro);
        }
    }


    }

