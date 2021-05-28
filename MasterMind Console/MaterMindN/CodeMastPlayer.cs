using masterMind;
using System;
using System.Collections.Generic;
using System.Text;

namespace masterMind
{
    public class CodeMastPlayer : Player                        //CodeMastPlayer child, Player parent abstract
    {
        private string name;
        private int[] codeMast = new int[4];
        public CodeMastPlayer()
        {
            name = null;
            codeMast = null ;
        }
        public override void SetName(string name)               // set name codeMaster override abstract
        {
            this.name = name;
        }
        public override string GetName()                        //get name codeMaster  override abstract
        {
            return name;
        }
        public override void SetCode(int[] codeMast)           //set secret code override abstract
        {
            this.codeMast = codeMast;
        }
        public override int[] GetCode()                      // get secrect code override abstract
        {
            return this.codeMast;
        }
        public override void Print()                          // double check if the program is working
        {                                                  // remove to play, this functions will print the secret code
            for (int i = 0; i < codeMast.Length; i++)
            {
                Console.Write(codeMast[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
