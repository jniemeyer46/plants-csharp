namespace Plants
{
	using System;
	using System.Diagnostics;

	public class Program
	{
		public static void Main(string[] args)
		{
			if (args.Length < 1)
			{
				Console.WriteLine("Please enter a hostname");
				return;
			}

			var connection = Client.createConnection();

			var ai = new AI(connection);
			if (Client.serverConnect(connection, args[0], "19000") == 0)
			{
				Console.WriteLine("Unable to connect to server");
				return;
			}

			if (Client.serverLogin(connection, ai.username(), ai.password()) == 0)
				return;

			if (args.Length < 2)
				Client.createGame(connection);
			else
				Client.joinGame(connection, Int32.Parse(args[1]), "player");

			while (Client.networkLoop(connection) != 0)
			{
				if (ai.startTurn())
					Client.endTurn(connection);
				else
					Client.getStatus(connection);
			}

			Client.networkLoop(connection); 
			Client.networkLoop(connection); 
			ai.end();
		}
	}

}