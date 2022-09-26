using static System.Console;
Clear();

Write ("input No : ");
int length = Convert.ToInt32(ReadLine()!);
int[] arr = GetTrinaryArray(length);
PrintArray(arr);
WriteLine("");
Write ("input digit to find : ");
int digit = Convert.ToInt32(ReadLine());
WriteLine($"Number of digits {digit}:");
PrintArray(IndexDigits(arr, digit));


//Methods

int[] GetBinaryArray(int len){
    int [] result = new int [len];
    for(int i = 0; i < len; i++){
        result[i] = new Random().Next(0,2);
    }

    return result;
}

void PrintArray (int[] inarray){
    Write("[");
    for(int i = 0; i < inarray.Length - 1; i++){
        Write($"{inarray[i]}, ");        
    }
    Write($"{inarray[inarray.Length - 1]}]");
}

int CountDigits (int[] inarray, int number){
    int result = 0;
    for(int i = 0; i < inarray.Length; i++){
        if( inarray[i] == number){
            result += 1;
        }
    }
    return result;
}

int CountZeros (int[] inarray){
    int result = 0;
    for(int i = 0; i < inarray.Length; i++){
        if( inarray[i] == 0){
            result += 1;
        }
    }
    return result;
}


int[] GetTrinaryArray(int len){
    int [] result = new int [len];
    for(int i = 0; i < len; i++){
        result[i] = new Random().Next(0,3);
    }

    return result;
}


int[] IndexDigits (int[] inarray, int number){
    int[] result = new int[inarray.Length];
    int j = 0;
    for(int i = 0; i < inarray.Length; i++){        
        if( inarray[i] == number){
            result[j] = i;
            j++;
        }
    }
    return result;
}
