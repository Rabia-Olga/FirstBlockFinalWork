//Необходимо:
//1. Создать репозиторий на GitHub
//2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
//3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
//4. Написать программу, решающую поставленную задачу
//5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше,
//либо равна 3 символам.


void FindNewArray (string [] array)
{
    string [] res = new string [array.Length];
    int sizeresarray = 0;
    foreach (string e in array) 
    {
        if (e.Length <=3)
        {
            res[sizeresarray] = e;
            sizeresarray ++;
        }
    }
    ShowArray (res);
}

void ShowArray (string [] arrtoshow)
{
    for (int i = 0; i< arrtoshow.Length; i++)
    {
        Console.Write ($"{arrtoshow[i]} ");
    }
    Console.WriteLine ();
}

string [] arraystring = {"Hello", "1", "1+е", "1254!!!", ")1"};
ShowArray(arraystring);
Console.Write ("Искомый массив строк: ");
FindNewArray (arraystring);


