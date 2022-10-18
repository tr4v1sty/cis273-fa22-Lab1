using System;
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

		static public Polynomial Add(Polynomial Coefficient, Polynomial Power)
		{ return Add(Coefficient, Power);
			{

				Polynomial difference = new Polynomial();

				return difference;
			
			
			}
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

