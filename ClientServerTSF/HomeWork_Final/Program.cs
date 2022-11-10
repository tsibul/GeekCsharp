using static System.Console;
Clear();

Write("input maximum element Length: ");
int elLength = Convert.ToInt32(ReadLine()!); 
Write("input array Length: ");
int arLength = Convert.ToInt32(ReadLine()!); 

string [] startArray = CreateRandomStringArray(elLength, arLength);
Write($"input array [{String.Join(", ", startArray)}]");


string [] CreateRandomStringArray(int elementLength, int arrayLength)
{
    string [] stringArray = new string [arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
       int tmpLength = new Random().Next(1, elementLength + 1);
       string tmpElement = string.Empty;
       for (int j = 0; j < tmpLength; j++)
        {
            int tmpUnicode = new Random().Next(25, 75);
            char tmpCharacter = (char) tmpUnicode;
            string tmpChar = tmpCharacter.ToString();
            tmpElement += tmpChar;
        }
        stringArray[i] = tmpElement;
    }
    return stringArray;
}