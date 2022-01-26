using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 3, 4, 2, 5, 5, 9, 8, 1, 1, 2, 7, 6 };

            var newArray = CheckerPair.NoPairArray(arr);

            foreach (var num in newArray)
            {
                Console.WriteLine(num);
            }
        }
    }
    public class CheckerPair
    {
        /// <summary>
        /// Метод возвращает массив элементов, не имеющих пары в переданном массиве
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static IEnumerable<int> NoPairArray(int[] array)
        {

            foreach (var num in array)
            {
                if (!IsCheckPair(num, array))
                {
                    yield return num;
                }
            }
        }
        private static bool IsCheckPair(int num, int[] array)
        {
            int count = 0;

            foreach (var n in array)
            {
                if (num == n) count++;
            }

            return count > 1 ? true : false;
        }
    }
}

//Ответ на второй вопрос:

/*

CREATE FUNCTION GetSalaryChief (@ChiefId INT) RETURNS INT
AS BEGIN
	DECLARE @SalaryChief INT;
	SELECT @SalaryChief = salary FROM Employee
	WHERE Id = @ChiefId;
	RETURN @SalaryChief;
END;
GO

SELECT * FROM Employee
WHERE salary > dbo.GetSalaryChief(Chief_id)
GO

 */
