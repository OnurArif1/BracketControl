using System;
using System.Collections.Generic;
using System.Text;

namespace exsample21
{
    public class Check : IBracketControl
    {
        public bool BracketControl(string artimetik)
        {
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < artimetik.Length; i++)
            {
                if (artimetik[i]=='(')
                {
                    stack.Push("(");
                }
                else if (artimetik[i]==')')
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
            if (stack.Count !=0)
            {
                return false;
            }
            else { return true; }
        }
    }
}
