namespace Nr.Rationale_03._29_
{
    //proiect de tip library
    public enum Sign
    {
        Pozitiv,
        Negativ
    }
    public class Rational
    {
        public uint Numitor { get; set; }
        public uint Numarator { get; set; }
        public Sign Semn{get;set;}

        public Rational(int numarator,int numitor)
        {
            if (numitor == 0)
            {
                throw new ArgumentException("Numitorul este 0.");
            }
            if (numarator < 0 && numitor > 0 || numarator > 0 && numitor < 0)
                Semn = Sign.Negativ;
            else
                Semn = Sign.Pozitiv;

            Numarator = (uint)Math.Abs(numarator);
            Numitor = (uint)Math.Abs(numitor);

            //Simplificare();
        }
        public Rational(int numarator):this(numarator, 1)
        {

        }
        public Rational(string numar)
        {
            //TODO implementati passingul stringului care tebuie sa fie de forma numarator/numitor
        }

        private Rational()
        {
            Numarator = 0;
            Numitor = 0;
        }

        public override string ToString()
        {
            string result = $"{Numarator} / {Numitor}";
            if (Semn == Sign.Negativ)
                result = "- " + result;

            return "(" + result + ")";
        }
        public static Rational operator*(Rational r1,Rational r2)
        {
            //supraincarcare de operatori
            Rational result = new Rational();
            result.Numarator = r1.Numarator * r2.Numarator;
            result.Numitor = r1.Numitor * r2.Numitor;
            if(r1.Semn == r2.Semn)
            {
                result.Semn = Sign.Pozitiv;
            }
            else
            {
                result.Semn = Sign.Negativ;
            }
            return result;
        }
        public static Rational operator /(Rational r1, Rational r2)
        {
            Rational result = r1 * r2.Inverse();

            return result;
        }

        private Rational Inverse()
        {
            Rational result = new Rational();
            result.Numarator = this.Numarator;
            result.Numitor = this.Numitor;
            result.Semn = this.Semn;

            return result;
        }

        private void Simplificare()
        {
            uint gcd;
            gcd = Util.Gcd(this.Numitor, this.Numarator);
            this.Numarator /= gcd;
            this.Numitor /= gcd;
        }
    }
}