using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int aa = 10;
            int bb = 20;
            int cc = aa + bb;
            Console.WriteLine("Start Program..{0}");        
            Console.WriteLine("aa={0}, bb={1}, cc={2}", aa.ToString(), bb.ToString(), cc.ToString());

			string danji_id;
			int cnt;
			Console.WriteLine("Danji_ID=");
			danji_id = Console.ReadLine();

			Console.WriteLine("count=");
			cnt = int.Parse(Console.ReadLine());

			PurgeString(danji_id, cnt);
			
			/*
            //int배열 foreach
            int[] dd = { 10, 20, 30 };
            foreach(int d1 in dd)
            {
                Console.WriteLine("d1={0}", d1.ToString());
            }

            //string배열 foreach
            string[] ee = { "test01", "test02" };
            foreach(string e1 in ee)
            {
                Console.WriteLine("foreach ee={0}", e1);
            }

			AmicableNumber();
			Console.ReadKey();
			*/
		}


        static void AmicableNumber()
        {
            /*2016.06.02
              친화수 : 친화수 (親和數)는 두 수의 쌍이 있어, 어느 한 수의 진약수를 모두 더하면 다른 수가 되는 것을 말한다. 
              220과 284의 쌍이 그 예이다. 220의 진약수는 1, 2, 4, 5, 10, 11, 20, 22, 44, 55, 110로 모두더하면 284.
              
              진약수 : 약수 중에서 자기자신을 제외한 것을 말한다. 예를 들면 6의 약수는 1, 2, 3, 6인데 
                      진약수는 1, 2, 3이다. 

              약수 : 어떤 정수를 나누어 떨어지게 하는, 0이 아닌 정수이다. : 6의 약수는 1, 2, 3, 6
            */
            int num1, num2, sum1 = 0, sum2 = 0, i;
            Console.WriteLine("Enter First Number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            num2 = int.Parse(Console.ReadLine());
            for(i = 1; i < num1; i++)
            {
                if(num1 % i == 0) //나머지가 0인것들의 계속 더한다. 즉 약수의 합을 구한다.
                {
                    //Console.WriteLine("약수={0}", i.ToString());
                    sum1 = sum1 + i;
                }
            }
            for(i = 1; i < num2; i++)
            {
                if(num2 % i == 0)
                {
                    sum2 = sum2 + i;
                }
            }
            if(num1 == sum2 && num2 == sum1)
            {
                Console.WriteLine("They are a Pair of Amicable Numbers");
            }
            else
            {
                Console.WriteLine("They are not Amicable Numbers");
            }
        }



        static void ArmstrongNumber()
        {
            /*2016.06.02
              수의 각자리의 숫자값을 ^3한뒤 더한값이 원래의 값이 되는수를 "암스트롱넘버" 라고 한다.
              EX: 153 = (1*1*1)+(5*5*5)+(3*3*3)    */
            Console.WriteLine("ArmstrongNumber Start..");

            int number, remainder, sum = 0;
            Console.Write("Enter a Number : ");
            number = int.Parse(Console.ReadLine());
            for (int i = number; i > 0; i = i / 10)
            {
                remainder = i % 10;
                sum = sum + remainder * remainder * remainder;
            }
            if (sum == number)
            {
                Console.Write("Entered Number is an Armstrong Number.");
            }
            else
            {
                Console.Write("Entered Number is not an Armstrong Number.");
            }
        }

        
        static void TestNumber()  //2016.06.02
        {
            Console.WriteLine("TestNumber Start..");

            Console.Write("Enter a Number : ");
            int number, remainder;
            number = int.Parse(Console.ReadLine());

            //입력받은 숫자의 자릿수 만큼 반복  (반복할때마다 remainder값을 첫번째자리, 두번째 자리의 값으로)
            for (int i = number; i > 0; i = i / 10) //153을 입력한경우 i값변화 => 153, 15, 1
            {
                remainder = i % 10;  //153을 입력한경우 remainder값변화 => 3, 5, 1
                Console.WriteLine("remainder={0}", remainder);
            }
        }

		#region  retargeting
		public static void PurgeString(string str, int cnt) {
			Console.WriteLine("PurgeString start..");
			string out_text01 = "";
			string out_text02 = "";
			string out_text05 = "";
			string out_text10 = "";

			for (int i = 0; i <= cnt; i++) {
				//string extra_deeplink_url_android = string.Format("zigbang://app/search/map?lat={0}&lng={1}&zoom={2}", add.web_lat.ToString(), add.web_lat.ToString(), add.web_level.ToString());
				out_text01 = out_text01 + string.Format("http://v.zigbang.com/360/{0}/main/br01M{1}.ts\n", str, i.ToString().PadLeft(5, '0'));
				out_text02 = out_text02 + string.Format("http://v.zigbang.com/360/{0}/main/br02M{1}.ts\n", str, i.ToString().PadLeft(5, '0'));
				out_text05 = out_text05 + string.Format("http://v.zigbang.com/360/{0}/main/br05M{1}.ts\n", str, i.ToString().PadLeft(5, '0'));
				out_text10 = out_text10 + string.Format("http://v.zigbang.com/360/{0}/main/br10M{1}.ts\n", str, i.ToString().PadLeft(5, '0'));
			}

			// 파일 처리
			string out_text = out_text01 + out_text02 + out_text05 + out_text10;
			byte[] file = Encoding.UTF8.GetBytes(out_text);
			string filename = string.Format("PurgeString_{0}_{1}.{2}", str, DateTime.Now.ToString("yyyyMMdd"), "txt");
			

            string fullpath = string.Format("{0}/{1}", @"Z:\Downloads\", filename);
            string str2 = Encoding.Default.GetString(file);
            System.IO.File.WriteAllText(fullpath, str2, Encoding.Default);

			Console.WriteLine("PurgeString end filename={0}{1}", fullpath, filename);
			return;

		}
		#endregion
	}
}
