using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise6_14
{
    internal class Class1
    {
        public static void Main()
        {
            FileStream fs;
            string s;
            while(true) //
            {
                Console.Write("파일 이름을 입력하세요 : ");
                s = Console.ReadLine(); // 파일 이름을 입력 
                try
                {
                    fs = new FileStream(s, FileMode.Open); // s이름의 파일을 오픈함 
                }
                catch (IOException)
                {
                    Console.WriteLine("파일이 존재하지 않습니다.");
                    continue; // 파일을 열 수 없을 경우 예외 처리를 하고 반복문의 처음으로 돌아감 
                }
                break; // 파일이 오픈되었을 경우 반복문을 빠져나옴
            }
            Console.WriteLine(s + " 파일 오픈");
        }
    }
}
