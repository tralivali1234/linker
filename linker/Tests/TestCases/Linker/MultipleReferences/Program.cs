﻿namespace TestCases.Linker.MultipleReferences
{
	public class Program
	{
		[Mark]
		public static int Main ()
		{
			Program p = new Program ();
			p.Run ();

			return 0;
		}

		void Run ()
		{
			Foo f = new Foo (new Bar ());
			f.UseBar ();

			Baz b = new Baz ();
			b.Chain (f);
		}
	}
}