using static System.Console;
Clear();

Write("input maximum element Length: ");
int elLength = Convert.ToInt32(ReadLine()!); 
Write("input array Length: ");
int arLength = Convert.ToInt32(ReadLine()!); 
WriteLine();

string [] startArray = CreateRandomStringArray(elLength, arLength);
Write($"input array [{String.Join(", ", startArray)}]");

WriteLine();
Write("Как резать будем ? ");
int cutLength = Convert.ToInt32(ReadLine()!);
WriteLine();

string [] newArray = CutArray(startArray, cutLength);
Write($"result array [{String.Join(", ", newArray)}]");

string [] CutArray(string [] inputArray, int cutParametr)
{
    var j = 0;
    for (int i = 0; i < inputArray.Length; i++)    
    {
        if(inputArray[i].Length <= cutParametr) j++;
    }
    string [] outArray = new string [j];

    j = 0;
    for (int i = 0; i < inputArray.Length; i++)    
    {
        if(inputArray[i].Length <= cutParametr)
        {
            outArray[j] = inputArray[i];
            j++;
        }
    }
    return outArray;
}

string [] CreateRandomStringArray(int elementLength, int arrayLength)
{
    string [] stringArray = new string [arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
//genegate random length of element for forLoop        
       int tmpLength = new Random().Next(1, elementLength + 1);
       string tmpElement = string.Empty;
       for (int j = 0; j < tmpLength; j++)
        {
//generate random number and use as unicode for random simbol            
            int tmpUnicode = new Random().Next(60, 120);
            char tmpCharacter = (char) tmpUnicode;
            string tmpChar = tmpCharacter.ToString();
            tmpElement += tmpChar;
        }
        stringArray[i] = tmpElement;
    }
    return stringArray;
}