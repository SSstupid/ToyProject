using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("번호를 입력하세요. " + Environment.NewLine + "1번 - 전체 Process / 2번 - 개별 Process");
            string result = Console.ReadLine();
            if(result == "1")
            {
                try
                {
                    Process[] AllProc = Process.GetProcesses();
                    int IndexNum = 1;
                    Console.WriteLine("------- 모든 프로세스 정보 -------");
                    Console.WriteLine("현재 실행중인 모든 프로세스 숫자 : {0}", AllProc.Length);
                    foreach(Process current in AllProc)
                    {
                        try
                        {
                            Console.WriteLine("------- {0}번째 프로세스 -------", IndexNum++);
                            ProcessInfo(current);
                            Console.WriteLine();
                        }
                        catch { }
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadLine();
            }
            else if(result == "2") // 사실상 무쓸모 정확한 이름을 넣어야함. 추후 개선 필요
            {
                Console.WriteLine("프로세스의 이름을 입력하십시오: ");
                string result2 = Console.ReadLine();

                foreach(var Process in Process.GetProcessesByName(result2))
                {
                    ProcessInfo(Process);
                }
                Console.Read();
            }
        }

        static void ProcessInfo(Process processinfo)
        {
            Console.WriteLine("Process : {0}", processinfo.ProcessName);
            Console.WriteLine("시작 시간 : {0}", processinfo.StartTime);
            Console.WriteLine("Process ID : {0}", processinfo.Id);
            Console.WriteLine("메모리 : {0}", processinfo.VirtualMemorySize);
            Console.WriteLine("Process Path : {0}", processinfo.MainModule.FileName);
        }
    }
}
