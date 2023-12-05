StreamReader sr = new StreamReader("input.txt");

string line = sr.ReadLine();
char firstdigit = '0';
char lastdigit = '0';

List<string> lista = new List<string>();
List<string> lista2 = new List<string>{"1","2","3","4","5","6","7","8","9","one","two","three","four","five","six","seven","eight", "nine"};
List<int> nums = new List<int>();



while (line != null)
{
    lista.Add(line);
    line = sr.ReadLine();
}

for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine(lista[i]);
    foreach (string item in lista2)
    {
        if (lista[i].Contains(item))
        {
            Console.WriteLine(item);
            break;
        }
    }
    
    /*
    foreach (var character in lista[i])
    {
        switch (character)
        {
            case '1' or '2' or '3' or '4' or '5' or '6' or '7' or '8' or '9':
                lastdigit = character;
                break;
        }
    }
    var charArray = lista[i].ToCharArray();
    Array.Reverse(charArray);
    foreach (var character in charArray)
    {
        switch (character)
        {
            case '0' or '1' or '2' or '3' or '4' or '5' or '6' or '7' or '8' or '9':
                firstdigit = character;
                break;
        }
    }
    
    string fulldigit = Convert.ToString(firstdigit) + Convert.ToString(lastdigit);
    int converteddigit = Convert.ToInt32(fulldigit);
    nums.Add(converteddigit);*/
}

Console.WriteLine(nums.Sum());
