using System;

namespace D22
{
	public static class Initializer
	{
		public static void Initialize()
		{
			Console.WriteLine ("Initializing...");
			Console.WriteLine ("Done!");
		}
	}

	public class PlayableCharacter
	{
		public string Name;

		public PlayableCharacter (string name)
		{
			Name = name;
		}
	}
}