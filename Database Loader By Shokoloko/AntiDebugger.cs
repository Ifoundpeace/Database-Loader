using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Security.Principal;
using System.Threading.Tasks;

public class AntiDebugger
{
	public static string[] titles = {

		"ILSpy",
		"0harmony",
		"0Harmony",
		"x32dbg",
		"sharpod",
		"xd",
		"extremedumper",
		"dojandqwklndoqwd",
		"dojandqwklndoqwd-x86",
		"ksdumper",
		"KsDumper",
		"KsDumper v1.1 - By EquiFox",
		"ksdumper v1.1 - by equifox",
		"x64dbg",
		"x32_dbg",
		"x64_dbg",
		"strongod",
		"PhantOm",
		"titanHide",
		"scyllaHide",
		"ilspy",
		"graywolf",
		"simpleassemblyexplorer",
		"MegaDumper",
		"megadumper",
		"X64NetDumper",
		"x64netdumper",
		"process hacker 2",
		"ollydbg",
		"x32dbg",
		"x64dbg",
		"ida -",
		"charles",
		"dnspy",
		"httpanalyzer",
		"httpdebug",
		"fiddler",
		"wireshark",
		"proxifier",
		"mitmproxy",
		"process hacker",
		"process monitor",
		"process hacker 2",
		"system explorer",
		"systemexplorer",
		"systemexplorerservice",
		"WPE PRO",
		"ghidra",
		"x32dbg",
		"x64dbg",
		"ollydbg",
		"ida -",
		"charles",
		"dnspy",
		"httpanalyzer",
		"httpdebug",
		"harmony",
		"http debugger",
		"fiddler",
		"wireshark",
		"dbx",
		"mdbg",
		"gdb",
		"windbg",
		"dbgclr",
		"kdb",
		"httpdebugger",
		"kgdb",
		"mdb",
		"folderchangesview"

	};










	public static void CrashAPP()
	{
		AppDomain currentDomain = AppDomain.CurrentDomain;
		currentDomain.UnhandledException +=
			new UnhandledExceptionEventHandler(OnUnhandledException);

		int cheque = CalculateRandomFraction();

	}

	private static void OnUnhandledException(
		object sender, UnhandledExceptionEventArgs e)
	{
		string exceptionStr = e.ExceptionObject.ToString();
		Debug.WriteLine(exceptionStr);
	}

	private static int CalculateRandomFraction()
	{
		var rand = new Random();
		int num1 = rand.Next();
		int num2 = 0;
		return Fraction(num1, num2);
	}

	private static int Fraction(int num1, int num2)
	{
		return num1 / num2;
	}

	public static void Start()
	{
		sbx = 2;
		ThreadPool.QueueUserWorkItem(runner);
	}

	public static void Stop()
	{
		sbx = 1;
	}

	public static int sbx = 1;
	public static void runner(object state)
	{

		while (sbx == 2)
		{
			Process[] prs = Process.GetProcesses();
			foreach (Process prcs in prs)
			{
				for (int i = 0; i < titles.Length; i++)
				{
					if (prcs.MainWindowTitle.ToLower().Replace("ı", "i").Contains(titles[i]) || prcs.ProcessName.ToLower().Replace(".exe", "") == "charles")
					{
						prcs.Kill();
					}
				}

			}
			Thread.Sleep(1000);
		}
	}
}
