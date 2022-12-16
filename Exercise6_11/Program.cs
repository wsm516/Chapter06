using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6_11 
{
    class GenericSwap<T>
    {
        public T x, y; // T 자료형의 변수 선언
        public void swap()
        {
            T temp;
            temp = x; x = y; y = temp; // T 자료형의 temp를 이용해 변수 값을 바꿈 
        }
    }
    public class ExerciseCh06_11
    {
        public static void Main(String[] args)
        {
            GenericSwap<int> i = new GenericSwap<int>(); // int 자료형의 제네릭 객체 생성
            i.x = 1; i.y = 2;
            Console.WriteLine("x: " + i.x + " y: " + i.y);
            i.swap();
            Console.WriteLine("x: " + i.x + " y: " + i.y);
            GenericSwap<double> d = new GenericSwap<double>(); // double 자료형의 제네릭 객체 생성
            d.x = 1.0; d.y = 2.0;
            Console.WriteLine("x: " + d.x + " y: " + d.y);
            d.swap();
            Console.WriteLine("x: " + d.x + " y: " + d.y);
        }
    }
}
 
