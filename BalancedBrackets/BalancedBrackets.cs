using System;

namespace BalancedBracketsNS
{
    public class BalancedBrackets
    {
        /**
         * The function BalancedBrackets should return true if and only if
         * the input string has a set of "balanced" brackets.
         *
         * That is, whether it consists entirely of pairs of opening/closing
         * brackets (in that order), none of which mis-nest. We consider a bracket
         * to be square-brackets: [ or ].
         *
         * The string may contain non-bracket characters as well.
         *
         * These strings have balanced brackets:
         *  "[LaunchCode]", "Launch[Code]", "[]LaunchCode", "", "[]"
         *
         * While these do not:
         *   "[LaunchCode", "Launch]Code[", "[", "]["
         *
         * parameter str - to be validated
         * returns true if balanced, false otherwise
        */
        public static bool HasBalancedBrackets(String str)
        {
            int brackets = 0;
            foreach (char ch in str.ToCharArray())
            {
                if (ch == '[')
                {
                    brackets++;
                }
                else if (ch == ']')
                //this line can't account for  empty strings or order of brackets
                //else if (ch == ']' && brackets > 0)
                {
                    brackets--;
                    //
                    //return true;
                }
                //is writing a specific circumstance in cheating the test? ask ta.
                 if (ch.Equals(""))
                {
                    return brackets == 0;
                }
                 if (brackets == -1)
                {
                    //do i want the program to keep going if i get a ], or do i want it to stop right away.
                    //prob stop because means wrong order...
                    return brackets == 0;
                    //break;
                }
            }
             return brackets == 0;
            //return false;
        }
    }
}
