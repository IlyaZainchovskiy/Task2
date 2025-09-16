namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintEdition edition = new PrintEdition();

            edition.SetValues("Внутрішній", "Наказ", 2);

            edition.ShowType();
        }
    }

    class PrintEdition
    {
        private string type;
        private string name;
        private int pages;
        public string Type
        {
            get => type;
            set => type = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Pages
        {
            get => pages;
            set => pages = value;
        }

        public PrintEdition()
        {
        }

        public void SetValues(string t, string n, int p)
        {
            Type = t;
            Name = n;
            Pages = p;

            Console.WriteLine($"Тип: {Type}, Назва: {Name}, Кількість сторінок: {Pages}");
        }
        public void ShowType()
        {
            Console.WriteLine($"Тип видання: {Type}");
        }
    }
}
