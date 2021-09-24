using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAbstractInterfacesEg
{
	interface IParentInterface
	{
		void ParentInterfaceMethod();
	}
	interface IMyInterface : IParentInterface
	{
		void MethodToImplement();
	}
	class InterfaceImplementer : IMyInterface
	{
		static void Main()
		{
			InterfaceImplementer iImp = new InterfaceImplementer();
			//or
			IMyInterface ipi = new InterfaceImplementer();

			iImp.MethodToImplement();
			//or
			ipi.MethodToImplement();
			ipi.ParentInterfaceMethod();
			iImp.ParentInterfaceMethod();
			Console.ReadKey();
		}
		public void MethodToImplement()
		{
			Console.WriteLine("MethodToImplement()called.");
		}
		public void ParentInterfaceMethod()
		{
			Console.WriteLine("ParentInterfaceMethod()called.");
		}
	}

}
