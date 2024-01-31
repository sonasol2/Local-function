namespace Local_function;

class Program
{
    static void Main(string[] args)
    {
        void Compare(int[] numbers1, int[] numbers2)
        {
            int numbers1Sum = Sum(numbers1);
            int numbers2Sum = Sum(numbers2);

            if (numbers1Sum > numbers2Sum)
                Console.WriteLine("Сумма числе из массива Numbers1 больше");
            else if (numbers1Sum < numbers2Sum)
                Console.WriteLine("Сумма числе из массива Numbers2 больше");
	        else
                Console.WriteLine("Суммы чисел обоих массивов равны");

            int Sum(int[] numbers)
            
	        {
                int result = 0;
                foreach (int number in numbers)
                    result += number;
                return result;
	        }

          
        }
        int[] numbers1 = { 1, 3, 4, 5 };
        int[] numbers2 = { 1, 5, 6 };
        Compare(numbers1, numbers2);

        //  локальные функции это по сути методы внутри методов. Такие функции нельзя использовать вне метода
        // также такие функции могут не иметь доступа к переменным метода если указать ключевое слово static

    
    }
}

