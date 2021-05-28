using System;
using System.Collections.Generic;
using System.Text;

namespace masterMind
{
    public class CodeMastCOMPlayer : Player            //CodeMastCOMPlayer child, Player parent abstract
    {
        private int[] codeMast = new int[4];
        private string name;
        public CodeMastCOMPlayer()
        {
            codeMast = null;
            name = null;
        }
        public override void SetName(string name)           //set name codeMaster override player abstract
        {
            this.name = name;
        }
        public override string GetName()                    //get name codeMaster override player abstract
        {
            return this.name;
        }
        public override void SetCode(int[] codes)           //set code override player abstract
        {
            this.codeMast = codes;
        }
        public override int[] GetCode()                     //get codeMast override player abstract
        {
            return this.codeMast;
        }
        public override void Print()                           // double check if the program is working|| override abstract
        {                                                      // print solution, remove to play to not print the secret code
            for (int i = 0; i < codeMast.Length; i++)
            {
                Console.Write(codeMast[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
