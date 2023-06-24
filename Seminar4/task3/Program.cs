// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120

    int GetObj(string mng)
    {
      Console.WriteLine(mng);
      int value = Convert.ToInt32(Console.ReadLine());
      return value;
    }
int GitOper(int ch)
{
    int res = 1;
    while (ch!= 1)
    {
        res = res * ch;
        сh--;
        
    }
    return res;
}
int qval = GetObj("Input Integer");
  Console.WriteLine(GitOper(qval));

//Не получилось!