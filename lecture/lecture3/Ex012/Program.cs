/*
Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить большими "К",
а большие "С" заменить малнькими "с".
*/

string text= "-Я думаю, - сказал князь, улыбаясь, - что,"
           + "ежели бы вас послали вместо нашего милого Винценгероде,"
           + "вы бы взяли приступом согласие прусского короля."
           + "Вы так красноречивы. вы дадите мне чаю?";

// string s="qwerty" - пояснение
//             012
//s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result=String.Empty;

    int length=text.Length;
    for (int i=0; i<length; i++)
    {
        if (text[i]==oldValue) result =result+ $"{newValue}";
        else result=result+$"{text[i]}";
    }
    return result;   
}
string newText=Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText=Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText=Replace(newText, 'с', 'С');
Console.WriteLine(newText);