

string[] array = {"qwer","4tyu","h","wrvkr","hj"};
string[] new_array = new string[array.Length];

void PrintArray(string[] array )
{
    for (int i = 0; i < array.Length; i++)
    {
        {
            Console.Write($"{array[i]} ");
        }
       
    }
}

for (int i = 0; i < array.Length; i++)
{
    if( array[i].Length <= 3  ) 
    {
        new_array[i] = new_array[i] + array[i];
    }
    
}
PrintArray(new_array);