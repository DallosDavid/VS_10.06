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
        public int AlapHp { get => alapHp; set => alapHp = value; }
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
                this.AlapHp = 120;
                this.AlapEro = 25;
                this.AlapDef = 10;
            }
            else if (klassz == 2)
            {
                this.AlapHp = 60;
                this.AlapEro = 45;
                this.AlapDef = 2;
            }
            else if (klassz == 3)
            {
                this.AlapHp = 55;
                this.AlapEro = 60;
                this.AlapDef = 5;
                //az ijász 2 körig nem  sebő dik -> tavolrol lő
            }
        }


    }
}
