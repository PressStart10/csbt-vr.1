using System;
using System.IO;
using System.Threading;
class Program {
  public static void Main (string[] args) {
		float snake = 1;
		while(true){
			string logon = File.ReadAllText("./user.txt");
			string logonpass = File.ReadAllText("./log.txt");
			if(logon == "[[]]" && logonpass == "[[]]"){
				Console.WriteLine("USERNAME");
				string newUse = Console.ReadLine();
				logon = logon.Replace(logon, newUse);
				File.WriteAllText("user.txt", logon);
				Console.Clear();
				Console.WriteLine("PASSWORD");
				string newLog = Console.ReadLine();
				logonpass = logonpass.Replace(logonpass, newLog);
				File.WriteAllText("log.txt", logonpass);
				Console.Clear();
			}
			else{
				Console.WriteLine("ENTER USERNAME");
				string log = Console.ReadLine();
				Console.Clear();
				if(log == logon){
					Console.WriteLine("ENTER PASSWORD");
					log = Console.ReadLine();
					Console.Clear();
					if(log == logonpass){
						while(true){
						Console.WriteLine("do: \n delete user \n shutdown \n logout \n say \n ");
						string doit = Console.ReadLine();
						if(doit == "delete user"){
								logonpass = logonpass.Replace(logonpass, "[[]]");
								File.WriteAllText("log.txt", logonpass);
								logon = logon.Replace(logon, "[[]]");
								File.WriteAllText("user.txt", logon);
								Console.Clear();
								break;
							}
							if(doit == "shutdown"){
								Environment.Exit (1);
							}
							if(doit == "say"){
								Console.Clear();
								string a = Console.ReadLine();
								Console.Clear();
								Console.WriteLine("printing...");
								Thread.Sleep(1000);
								Console.WriteLine(a);
								Console.ReadKey();
								Console.Clear();
							}
							if(doit == "logout"){
								Console.Clear();
								break;
							}
							else{
								Console.Clear();
							}
						}
					}
				}
			}
		}
  }
}