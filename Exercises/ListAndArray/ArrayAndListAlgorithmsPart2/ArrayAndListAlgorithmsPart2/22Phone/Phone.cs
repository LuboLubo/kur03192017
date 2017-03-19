namespace _22Phone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Phone
    {
        public static void Main()
        {
            var inputNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var inputName = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (true)
            {
                var command = Console.ReadLine().Split();
                if (command[0].Equals("done"))
                {
                    break;
                }
                if (command[0].Equals("call"))
                {
                    var temp = command[1];
                    Console.WriteLine();
               
                    if (temp[0] <= 57)
                    {
                        for (int i = 0; i < inputNumbers.Length; i++)
                        {
                            if (inputNumbers[i] == temp)
                            {
                                Console.WriteLine($"calling {inputName[i]}...");
                                long sum = 0;
                                var strTemp = inputNumbers[i];
                                for (int sumNum = 0; sumNum < strTemp.Length; sumNum++)
                                {
                                    char num = strTemp[sumNum];
                                    if (num >= '0' || num <= '9')
                                    {
                                        sum += num - '0';
                                    }
                                }
                                if (sum % 2 == 1)
                                {
                                    Console.WriteLine("no answer");
                                    break;
                                }
                                var min = sum % 60;
                                var hour = sum / 60;

                                if (hour < 10)
                                {
                                    Console.WriteLine($"call ended. duration: 0{hour}:{min}");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"call ended. duration: {hour}:{min}");
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < inputName.Length; i++)
                        {
                            if (inputName[i] == temp)
                            {
                                Console.WriteLine($"calling {inputNumbers[i]}...");

                                long sum = 0;
                                var strTemp = inputNumbers[i];
                                for (int sumNum = 0; sumNum < strTemp.Length; sumNum++)
                                {
                                    char num = strTemp[sumNum];
                                    if (num >= '0' || num <= '9')
                                    {
                                        sum += num - '0';
                                    }
                                    
                                }
                                if (sum % 2 == 1)
                                {
                                    Console.WriteLine("no answer");
                                    break;
                                }
                                var min = sum % 60;
                                var hour = sum / 60;


                                if (hour < 10)
                                {
                                    Console.WriteLine($"call ended. duration: 0{hour}:{min}");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"call ended. duration: {hour}:{min}");
                                    break;
                                }
                            }
                        }
                    }
                }
                else if (command[0].Equals("message"))
                {
                    var temp = command[1];
                    Console.WriteLine();
                    if (temp[0] <= 57)
                    {

                    }
                    else
                    {
                        for (int i = 0; i < inputName.Length; i++)
                        {
                            if (inputName[i] == temp)
                            {
                                Console.WriteLine($"sending sms to {inputNumbers[i]}...");

                                var strTemp = inputNumbers[i];
                                var listTemp = new List<string>();
                                for (int k = 0; k < strTemp.Length; k++)
                                {
                                    char num = strTemp[k];
                                    if (num >= 48 && num <= 57)
                                    {
                                        listTemp.Add(num.ToString());
                                    }
                                }
                                Console.WriteLine();
                                double lenght = Math.Abs(listTemp.Count);
                                Console.WriteLine();

                            }
                        }
                    }


                }
            }
        }
    }
}
