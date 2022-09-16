string[] line = new string[] { "hello","2","world","=-)" };


int numberWordsWithThreeOrLessCharacters(string[] line){
    int count = 0;
      for (int i = 0; i < line.Length; i++)
    {
        if (line[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

int lengthFormatingArray =  numberWordsWithThreeOrLessCharacters(line);

string[] ArrayFormation(string[] line, int LengthArrayWord)
{
    string[] formationLine = new string[LengthArrayWord];
    int temp = 0;
    for (int i = 0; i < line.Length; i++)
    {
        if (line[i].Length <= 3)
        {
            formationLine[temp] = line[i];
            temp++;
        }
    }
    return formationLine;
}

string[] resultFormatingArray = ArrayFormation(line, lengthFormatingArray);

void printArray(string[] resultFormArr)
{
    foreach (string word in resultFormArr)
    {
        Console.Write($"[{word}] ");
    }
}

printArray(resultFormatingArray);