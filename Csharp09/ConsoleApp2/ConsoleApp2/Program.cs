using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Reversing Array
            //int[] intArray = { 1, 2, 3, 4, 5 };
            //int[] reversedIntArray = ReverseArray(intArray);
            //Console.WriteLine("Reversed Integer Array: " + string.Join(", ", reversedIntArray));

            //string[] stringArray = { "apple", "banana", "cherry" };
            //string[] reversedStringArray = ReverseArray(stringArray);
            //Console.WriteLine("Reversed String Array: " + string.Join(", ", reversedStringArray));

            //Person[] personArray = {
            //    new Person("Alice", 30),
            //    new Person("Bob", 25),
            //    new Person("Charlie", 35)
            //};
            //Person[] reversedPersonArray = ReverseArray(personArray);
            //Console.WriteLine("Reversed Person Array:");
            //foreach (var person in reversedPersonArray)
            //{
            //    Console.WriteLine(person);
            //}
            #endregion

            #region Stack 
            //Stack<int> intStack = new Stack<int>();
            //intStack.Push(10);
            //intStack.Push(20);
            //intStack.Push(30);
            //Console.WriteLine("Top of the stack (Peek): " + intStack.Peek()); 
            //Console.WriteLine("Popped item: " + intStack.Pop()); 
            //Console.WriteLine("Popped item: " + intStack.Pop()); 
            //Console.WriteLine("Is the stack empty? " + intStack.IsEmpty());
            #endregion



        }
        public static T[] ReverseArray<T>(T[] inputArray)
        {
            T[] reversedArray = new T[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                reversedArray[i] = inputArray[inputArray.Length - 1 - i];
            }

            return reversedArray;
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name}, {Age} years old";
        }
    }
    public class Stack<T>
    {
        private List<T> _stackList;

        public Stack()
        {
            _stackList = new List<T>();
        }

        public void Push(T item)
        {
            _stackList.Add(item);
        }
        public T Pop()
        {
            if (_stackList.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            T topItem = _stackList[_stackList.Count - 1];
            _stackList.RemoveAt(_stackList.Count - 1);
            return topItem;
        }
        public T Peek()
        {
            if (_stackList.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            return _stackList[_stackList.Count - 1];
        }
        public bool IsEmpty()
        {
            return _stackList.Count == 0;
        }

        public int Count
        {
            get { return _stackList.Count; }
        }
    }

}

