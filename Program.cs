
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