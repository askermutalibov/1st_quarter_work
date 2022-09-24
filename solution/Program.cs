/* Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше или равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

string[] originArray = { "software testing is subdivided by", "compatibility testing", "verification", "security testing", "ui/ux testing", "automated testing", "performance testing" };
string[] editedArray = new string[4];

void CreateNewStringArray(string[] filledArray, string[] emptyArray)
{
    filledArray[0] = "software testing is subdivided by";
    filledArray[1] = "compatibility testing";
    filledArray[2] = "verification";
    filledArray[3] = "security testing";
    filledArray[4] = "ui/ux testing";
    filledArray[5] = "automated testing";
    filledArray[6] = "performance testing";
    Random limitOfStringElementsInFinalArray = new Random();
    Random chooseRandomElementInFilledArray = new Random();
    Console.Write($"\nthis array looks like: [");
    for (int i = 0; i < 3; i++)
    {
        emptyArray[limitOfStringElementsInFinalArray.Next(0, 4)] = filledArray[chooseRandomElementInFilledArray.Next(0, 3)];
        if (!string.IsNullOrEmpty(emptyArray[i])) Console.Write($" ''{emptyArray[i]}'' ");
    }
    Console.Write("]");
    Console.WriteLine($"\n");
}

CreateNewStringArray(originArray, editedArray);