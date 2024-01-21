## Итоговая контрольная работа по основному блоку.

## **Условия задачи**
Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе Разработчик. Мы должны убедится, что базовое знакомство с IT прошло успешно.
Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

1. Создать репозиторий на __GitHub__
2. Нарисовать блок-схему алгоритма _(можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)_
3. Снабдить репозиторий оформленным текстовым описанием решения _(файл __README.md__)_
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом _(не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

**Задача:**

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры:**
```
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
```
***

1. Вы находитесь в созданном репозитории `FTW`
2. Блок-схема алгоритма: в файле формата drawio
3. Вы читаете данный фаил `README.md`
4. Программа по заданному условию.


Код программы:
```cs

string[] CreateArray(string[] a) {
    for (int i = 0; i < a.Length; i++) {
        Console.WriteLine("Введите "+i.ToString()+" элемент массива:");
        a[i] = Console.ReadLine().ToString();
    }
    return a;
}
string[] NewMass(string[] a) { 
    int size=GetCountElem(a);
    string[] newMass = new string[size];
    int k = 0;
    for (int i = 0; i < a.Length; i++) {
        if ((a[i].Length >= 1) && (a[i].Length <= 3))
        {
            newMass[k] = a[i];
            k++;
        }
    }
    return newMass;
}
void PrintNewArray(string []newmass) {
    Console.WriteLine("Новый массив:");
    if (newmass.Length == 0)
    {
        Console.WriteLine("[]");
    }
    else {
        for (int i = 0; i < newmass.Length; i++) {
            Console.WriteLine(newmass[i]);
        }
    }
}
int GetCountElem(string[] a) {
    int k= 0;
    for (int i=0;i<a.Length;i++) {
        if ((a[i].Length >= 1)&&(a[i].Length <= 3)){
            k += 1;
        }
    }
    return k;
}
void PrintMass(string[] a) {
    Console.WriteLine("Ваш массив:");
    for (int i = 0; i < a.Length; i++)
    {
        Console.WriteLine(a[i]);
    }
}

Console.WriteLine("Введите количество элементов:");
int k = Int32.Parse(Console.ReadLine());
string []mass = new string[k];
mass=CreateArray(mass);
PrintMass(mass);
string[]newmass = NewMass(mass);
PrintNewArray(newmass);
```
