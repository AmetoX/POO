using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Transaction_19_04
{
    internal class Transaction: IComparable<Transaction>
    {
        private string nume;
        private Date data;
        private double suma;
        public static SumaOrder SUMA_ORDER = new SumaOrder();

        public Transaction(string nume, Date data, double suma)
        {
            this.nume = nume;
            this.data = data;
            this.suma = suma;
        }
        public Transaction(string transaction)
        {
            string[] tokens = transaction.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            nume = tokens[0];
            data = new Date(tokens[1]);
            suma = double.Parse(tokens[2], CultureInfo.InvariantCulture);
        }

        public string Nume => nume;
        public Date date => data;
        public double Suma => suma;
        +-*
        public override string ToString()
        {
            return string.Format("{0,-20} {1,10} {2,10:F2}", nume, data, suma);
        }
        public class SumaOrder : IComparer<Transaction>
        {
            public int Compare(Transaction x, Transaction y)
            {
                return x.suma.CompareTo(y.suma);
            }
        }
        public int CompareTo(Transaction other)
        {
            if (this.suma < other.suma)
                return -1;
            else if (this.suma > other.suma)
                return 1;
            else
                return 0;
        }
    }
}
