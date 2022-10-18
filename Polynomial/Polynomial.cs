using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

namespace Polynomial
{
	public class Polynomial
	{

		private LinkedList<Term> terms;

		public int NumberOfTerms => terms.Count;

		public int Degree => NumberOfTerms == 0 ? 0 : terms.First.Value.Power;

		public Polynomial()
		{
			terms = new LinkedList<Term>();

		}
		public void AddTerm(double coeff, int power)
		{
			var currentnode = terms.First;
			while (currentnode != null)
			{
				//check power
				if (power == currentnode.Value.Power)
				{
					currentnode.Value.Coefficient += coeff;
					return;
				}
				if( power > currentnode.Value.Power)
				{
					var newTerm = new Term(power, coeff);
					terms.AddBefore(currentnode, newTerm);
					return;
				}
				

				currentnode = currentnode.Next;
			}
		
				terms.AddLast(new Term(power, coeff));
		}

		public override string ToString()
		{
			string result = "";
			foreach (var term in terms)
			{
				result += term.ToString() + " + ";
			}
			return result;
		}

		static public Polynomial Add(Polynomial p1, Polynomial p2)
		{ 
			Polynomial sum = new Polynomial();

				// add all the terms from p1 to sum
				foreach( var term in p1.terms)
			{
				sum.AddTerm(term.Coefficient, term.Power);
			}


            // add all the terms from p2 to sum
            foreach (var term in p2.terms)
            {
                sum.AddTerm(term.Coefficient, term.Power);
            }

			return sum;
        }




		static public Polynomial Subtract(Polynomial p1, Polynomial p2)
		{
			 Polynomial inverse = new Polynomial();
			return inverse;
		}



		 static public Polynomial Negate(Polynomial p)
		{ 
			throw new NotImplementedException();
		
		}
		 static public Polynomial Multiply(Polynomial p1, Polynomial p2) { throw new NotImplementedException(); }


		//MERASMUS SAYS BONUS RUBBER DUCKS FOR EVERYONE
		static public Polynomial Divide(Polynomial p1, Polynomial p2) { throw new NotImplementedException(); }

    }
}

