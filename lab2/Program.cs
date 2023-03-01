

class Person
{
    public Person() { }
    public Person(string surname,string name,DateTime birth,char s)
    {
        Surname = surname;
        Name = name;
        Birth = birth;
        S = s;
    }
    public Person(Person a)
    {
        Surname=a.Surname;
        Name=a.Name;
        Birth=a.Birth;  
        S = a.S;    
    }
    ~Person() { }
    public char S
    {
        get { return _s; }
        set
        {
            if (_s == 'M' || _s == 'm' | _s == 'F' | _s == 'f' | _s == 'м'| _s == 'ж'| _s=='М'|_s=='Ж')
                _s = value;
        }
    }
    public void Output()
    {
        Console.WriteLine(Surname + " " + Name + " " + fullage() + " " + S);
    }
    public void Input()
    {
        Console.WriteLine("Введите фамилию: ");
        Surname= Convert.ToString(Console.ReadLine()); 
        Console.WriteLine("Введите имя: ");
        Name= Convert.ToString(Console.ReadLine());
        Console.WriteLine("Введите дату рождения: ");
        Birth = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine("Введите пол: ");
        _s = Convert.ToChar(Console.ReadLine());
    }
    public int fullage()
    {
        DateTime b = DateTime.Now;
        return Convert.ToInt32(b.Subtract(Birth).TotalDays / 365);
    }
    public override string ToString()
    {
        return Surname + " " + Name[0] + ". " + fullage() + " " + S;
    }
    static void Main()
    {
        Console.WriteLine("Сколько человек вы хотите ввести? ");
        int n = Convert.ToInt32(Console.ReadLine());
        Person[] A = new Person[n];
     
        for(int i=0;i<n; i++)
        {
            A[i] = new Person();
            A[i].Input();
        }
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine(Convert.ToString(A[i])+ "\n");
        }
    }



    public string Surname { get; set; }
    public string Name { get; set; }
    public DateTime Birth { get; set; }
    private char _s;
}