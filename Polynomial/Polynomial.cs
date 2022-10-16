using System;
namespace Polynomial
{
	public class Polynomial
	{

		private LinkedList<Term> terms;

		public int NumberOfTerms => terms.Count;

		public int Degree => NumberOfTerms == 0 ? 0: terms.First.Value.Power;

		public Polynomial()
		{
			terms = new LinkedList<Term>();

		}
        public void AddTerm(double coeff, int power)
		{

		}
        
        string ToString()
		{
			throw new NotImplementedException();
		}

         static public Polynomial Add(Polynomial Coefficient, Polynomial Power) { return Add(Coefficient, Power); }
		 static public Polynomial Subtract(Polynomial p1, Polynomial p2) { throw new NotImplementedException(); }
		 static public Polynomial Negate(Polynomial p) { throw new NotImplementedException(); }
		 static public Polynomial Multiply(Polynomial p1, Polynomial p2) { throw new NotImplementedException(); }


		//MERASMUS SAYS BONUS RUBBER DUCKS FOR EVERYONE
		Polynomial Divide(Polynomial p1, Polynomial p2) { throw new NotImplementedException(); }

    }
}

