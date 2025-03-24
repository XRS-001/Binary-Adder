class BinaryAdder
{
    static void Main()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Binary Number 1:");
            string readLine1 =  Console.ReadLine();
            if(readLine1 == "")
                exit = true;
            char[] binaryNumber1 = readLine1.ToCharArray();


            Console.WriteLine("Binary Number 2:");
            string readLine2 = Console.ReadLine();
            if(readLine2 == "")
                exit = true;
            char[] binaryNumber2 = readLine2.ToCharArray();


            Array.Reverse(binaryNumber1);
            Array.Reverse(binaryNumber2);
            Console.WriteLine("Result:");
            if(binaryNumber1.Length > binaryNumber2.Length)
                Console.WriteLine(string.Concat(BinaryAddition(binaryNumber1, binaryNumber2)));
            else
                Console.WriteLine(string.Concat(BinaryAddition(binaryNumber2, binaryNumber1)));

            Console.ReadLine(); 
        }
    }
    static char[] BinaryAddition(char[] largerNumber, char[] smallerNumber)
    {
        int carry = 0;
        List<char> result = new List<char>();
        for (int i = 0; i < largerNumber.Length + carry; i++)
        {
            int largerNumValue = 0;
            if(largerNumber.Length > i)
                largerNumValue = int.Parse(largerNumber[i].ToString());

            int smallerNumValue = 0;
            if(smallerNumber.Length > i)
                smallerNumValue = int.Parse(smallerNumber[i].ToString());

            switch (largerNumValue + smallerNumValue + carry)
            {
                case 0:
                    result.Add('0');
                    carry = 0;
                break;
                case 1:
                    result.Add('1');
                    carry = 0;
                break;
                case 2:
                    result.Add('0');
                    carry = 1;
                break;
                case 3:
                    result.Add('1');
                    carry = 1;
                break;
            }
        }
        char[] returnArray = result.ToArray();
        Array.Reverse(returnArray);
        return returnArray;
    }
}