using System;
using System.Collections.Generic;
using System.Text;

namespace exsample21
{
    public class MenuHelper
    {
        private Check check = new Check();
        public void Menu(string artimetik)
        {
            Console.WriteLine("Parantez kontrol sistemine hoşgeldiniz.");
            Console.WriteLine("Lütfen kontrol etmek istdeğiniz parantez metnini girin:");
        }
        public void ReadInput(string input,Stack<Check> check)
        {

        }
        private bool bracketControl(Stack<Check> check)
        {
            return false;
        }
    }
}
