namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generic sorting
            //var employees = new Employee[]
            //    {
            //    new Employee { Name = "John", Salary = 50000 },
            //    new Employee { Name = "Jane", Salary = 75000 },
            //    new Employee { Name = "Doe", Salary = 60000 }
            //    };

            //var sortingAlgorithm = new SortingAlgorithm<Employee>();
            //sortingAlgorithm.Sort(employees, (x, y) => x.Salary.CompareTo(y.Salary));
            //Generic sorting algorithms provide type safety, a
            //llowing sorting of any data type (like Employee) without needing
            //separate methods for each data type.  
            #endregion

            #region Lambda Expression
            //var numbers = new int[] { 1, 5, 3, 9, 2 };
            //var sortingTwo = new SortingTwo<int>();
            //sortingTwo.Sort(numbers, (x, y) => y.CompareTo(x));
            // Lambda expressions allow concise and readable code,
            // eliminating the need for verbose delegate declarations.
            #endregion

            #region Sort Strings
            //var strings = new string[] { "apple", "banana", "kiwi", "pear" };
            //var sortingTwo = new SortingTwo<string>();
            //sortingTwo.Sort(strings, (x, y) => x.Length.CompareTo(y.Length));
            //  allows flexibility to handle different sorting criteria for various data types.
            #endregion

            #region Func Delegate
            //Func<Employee, Employee, bool> compareByNameLength = (e1, e2) => e1.Name.Length < e2.Name.Length;
            // enhances code readability and flexibility.
            #endregion

            #region Anonymous Function
            //var numbers = new int[] { 1, 5, 3, 9, 2 };
            //Array.Sort(numbers, delegate (int x, int y) { return x.CompareTo(y); });
            #endregion

            #region Multi-Criteria Sorting 
            //Employee[] employees = new Employee[4];
            //var sortingTwo = new SortingTwo<Employee>();
            //sortingTwo.Sort(employees, (x, y) =>
            //{
            //    int salaryComparison = x.Salary.CompareTo(y.Salary);
            //    return salaryComparison == 0 ? x.Name.CompareTo(y.Name) : salaryComparison;
            //});
            //maintaining clarity in complex sorting logic and ensuring the order of multiple comparisons.
            //the benefits are sorting provides more powerful and flexible sorting strategies,
            //reducing the need for additional logic in separate methods.
            #endregion

        }
        public T GetDefault<T>()
        {
            return default(T);
        }
    }
    public class SortingAlgorithm<T> where T : ICloneable
    {
        public void Sort(T[] array)
        {
            T[] clone = (T[])array.Clone();
            Array.Sort(clone);
        }
        public void Sort(T[] array, Func<T, T, int> compare)
        {
            Array.Sort(array, new Comparison<T>((x, y) => compare(x, y)));
        }
        public static void Swap(T[] array, int index1, int index2)
        {
            T temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }
    public class SortingTwo<T>
    {
        public void Sort(T[] array, Func<T, T, int> compare)
        {
            Array.Sort(array, new Comparison<T>((x, y) => compare(x, y)));
        }
    }
    #region Manager Class 
    public class Manager : Employee, IComparable<Manager>
    {
        public int CompareTo(Manager other)
        {
            return this.Salary.CompareTo(other.Salary);
        }
    }
    #endregion

}
