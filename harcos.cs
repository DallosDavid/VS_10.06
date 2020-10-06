using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;

namespace VS_10._06
{

    class harcos
    {
        public string nev;
        public int klassz;
        public int szint;
        public int xp;
        public int Hp;
        public int alapHp ;
        public int alapEro;
        public int alapDef;

        public harcos(string nev, int klassz)
        {
            this.Nev = nev;
            this.Klassz = klassz;
            this.xp = 0;
            this.szint = 1;
            if (klassz == 1)
            {
                this.alapHp = 30;
                this.alapEro = 5;
                this.alapDef = 10;
            }
            else if (klassz == 2)
            {
                this.alapHp = 15;
                this.alapEro = 8;
                this.alapDef = 2;
            }
            else if (klassz == 3)
            {
                this.alapHp = 10;
                this.alapEro = 12;
                this.alapDef = 5;
                //az ijász 2 körig nem sebződik -> tavolrol lő
            }
            Hp = MaxEletero;
        }
        public string Nev { get => nev; set => nev = value; }
        public int Klassz { get => klassz; set => klassz = value; }
        public int Szint { get => szint; set => szint = value; }
        public int HP { get => Hp; set
            {
                if (this.Hp == 0)
                {
                    this.xp = 0;
                }
                if (this.Hp > MaxEletero)
                {
                    this.Hp = MaxEletero;
                }
            } 
        }
        public int AlapHP {get => alapHp;}
        public int AlapEro { get => alapEro;  }
        public int AlapDef { get => alapDef;  }
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
        public void Harc(harcos harcosM)
        {
            if (this.Hp > 0)
            {
                if (harcosM.AlapDef - this.AlapEro > 0)
                {
                    harcosM.alapDef -= this.AlapEro;
                }
                else
                {
                    harcosM.Hp -= Math.Abs(harcosM.alapDef -= this.AlapEro);
                }
            }

            if (harcosM.AlapEro > 0)
            {
                if (this.AlapDef - harcosM.AlapEro > 0)
                {
                    this.alapDef -= harcosM.AlapEro;
                }
                else
                {
                    this.alapEro -= Math.Abs(this.alapDef -= harcosM.AlapEro);
                }
            }
            if (this.Hp > 0)
            {
                harcosM.Xp += 5;
            }
            if (harcosM.Hp > 0)
            {
                this.Xp += 5;
            }

            if (this.Hp - harcosM.AlapEro <= 0)
            {
                harcosM.Xp += 10;

            }
            else if (harcosM.AlapEro - this.AlapEro <= 0)
            {
                this.Xp += 10;
            }
        }

            public void Gyogyit()
            {
                Console.WriteLine();
                Console.WriteLine("Gyogyiotál ");
                if (this.Hp == 0)
                {
                    this.Hp = MaxEletero;
                }
                else if ((Hp += 4) > MaxEletero)
                {
                    Console.WriteLine("Plus Hp nem adhatsz magadnak.");
                }
                else
                {
                    Hp += 4;
                }
            }

    

        
      
        public override string ToString()
        {
            return string.Format("{0} - LVL:{1} - EXP:{2}/{3} - HP:{4}/{5} - DMG:{6}", this.nev, this.szint, this.xp, this.Szintlepes, this.Hp, this.MaxEletero, this.AlapEro);
        }
    }


    }

