using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerTestApp
{
    class MyList : IEnumerable, IEnumerator
    {
        private int[] array;
        private int position = -1; //배열의 현재 위치값

        //배열화(배열이 아닌 MyList를 배열처럼 만들어주는 프러퍼티)
        public int this[int index] // =MyList[i] = array[i]
        {
            get { return array[index]; }
            set
            {
                if (index >= array.Length)//하나씩 증가
                {
                    System.Array.Resize(ref array, index + 1);
                    Console.WriteLine($"Array resized : {array.Length}");
                }
                array[index] = value;
            }
        }

        public int Length
        {
            get { return array.Length; } // 3
        }

        //IEnumerator
        /*        public object Current => array[position];
        */

        public object Current
        { 
            get { return array[position]; } //현재값 foreah에만 필요
        }

        public MyList()
        {
            array = new int[3]; //0,1,2
        }

        //IEnumerable 메서드
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            position++;
            return (position < array.Length);
        }

        public void Reset()
        {
            position = -1;//초기화
        }
    }
}
