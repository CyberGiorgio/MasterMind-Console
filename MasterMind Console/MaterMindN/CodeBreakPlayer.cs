using masterMind;
using System;
using System.Collections.Generic;
using System.Text;

namespace masterMind
{
    public class CodeBreakPlayer : Player                                    // Player 1 child, Player parent abstract
    {
        private int[] codeBreak = new int[4];                       
        private string name;
        public CodeBreakPlayer()
        {
            codeBreak = null;
            name = null;
        }
        public override void SetName(string name)                           //set player name override abstract
        {
            this.name = name;
        }
        public override string GetName()                                    //get player name override abstract
        {
          return this.name;
        }
        public override void SetCode(int[] codes)                           //set code override abstract
        {
            this.codeBreak = codes;
        }
        public override int[] GetCode()                          //get code override abstract
        {
            return this.codeBreak;
        }
        public override void Print()                                   //print out code override abstract
        {
            Console.WriteLine("The solution you typed is : ");
            for (int i = 0; i < codeBreak.Length; i++)
            {
                Console.Write(codeBreak[i] + " ");
            }
            Console.Write("\n");
        }
    }
}
