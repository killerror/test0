string[] originArray = {
    "Mary",
    "Joe",
    "Liam",
    "Mia",
    "Henry",
    "Yu",
    "Leo",
    "David",
    "Ed"
};

int finalArraySize = 0;
int finalArrayIndx = 0;

for (int i = 0; i < originArray.Length; i++)
    if (originArray[i].Length <= 3) finalArraySize++;

string[] finalArray = new string[finalArraySize];

for (int i = 0; i < originArray.Length; i++)
    if (originArray[i].Length <= 3)
        finalArray[finalArrayIndx++] = originArray[i];

Console.Write("Исходный массив: ");
for (int i = 0; i < originArray.Length; i++)
    Console.Write(originArray[i] + ((i != originArray.Length-1) ? ", " : ""));
Console.WriteLine();

Console.Write("Результирующий массив: ");
for (int i = 0; i < finalArray.Length; i++)
    Console.Write(finalArray[i] + ((i != finalArray.Length-1) ? ", " : ""));
