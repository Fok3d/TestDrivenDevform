using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDev
{
    public enum Oblicej
    {
        VelkyNos,
        Uslopesk,
        MakeUp
    }

    public enum Vlasy
    {
        Drdol,
        Culik,
        Pleska
    }

    public enum BarvaVlasu
    {
        Kastanova,
        Blond,
        Cervena
    }

    public class HerniPostava
    {
        private string jmeno;
        private int level = 1;
        private int poziceX = 0;
        private int poziceY = 0;
        public string Jmeno
        {
            get { return jmeno; }
            set { jmeno = value; }
        }
        public int PoziceX
        {
            get { return poziceX; }
        }

        public int PoziceY
        {
            get { return poziceY; }
        }

        public HerniPostava(string jmeno)
        {
            Jmeno = jmeno;
        }

        public void ZmenaPozice(int mouseX, int mouseY)
        {
            poziceX = mouseX;
            poziceY = mouseY;
        }

        public override string ToString()
        {
            return $"Jméno: {jmeno}, Level: {level}, Pozice X: {poziceX}, Pozice Y: {poziceY}";
        }
    }
    public class Hrac : HerniPostava
    {
        public string specializace;
        public Oblicej oblicej;
        public Vlasy vlasy;
        public BarvaVlasu barvaVlasu ;
        public int level = 1;

        public string Specializace { get { return specializace; } set { specializace = value; } }
        public Hrac(string jmeno, string specializace) : base(jmeno)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
