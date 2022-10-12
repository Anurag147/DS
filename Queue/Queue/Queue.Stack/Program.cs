using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'stringConstruction' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int stringConstruction(string s)
    {
        StringBuilder tempStr = new StringBuilder();
        int costOfOperation = 0;
        StringComparison comp = StringComparison.OrdinalIgnoreCase;
        for (int i = 0; i < s.ToCharArray().Length; i++)
        {
            if (tempStr.ToString().Contains(s[i]))
            {
                tempStr.Append(s[i]);
            }
            else
            {
                costOfOperation++;
                tempStr.Append(s[i]);
            }
        }
        return costOfOperation;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        //Console.WriteLine(Result.stringConstruction("rfieogcmpgsdjhitnpinqhllalrmtodmbbeukomrsbolmllrrtoneucdoiuqccflkhntftqpkcmlejqstbpsbmknqmcrqmdmbqnusrgkorntuifdhdaflmptfntmfqheggoprnhptrfarmpuairbjrmsbgcjkttescgrkghtrcfghbfnjmiaujhhgrlroqrapkgnutprsfrkpgccfbflbpcgbqeemdqfhqoqijtcltafqicsshfepaihmqqocfkbcnkqlqockljptndspbsbqekkcookpnojrajltpqgchpakjuktfcbultjhupnqrikjjcncppoqltntgsjtutdmtttujkohdiapnfaarauncmsimplbiclqhrtipiqsonrhueggbeiesgfptldabdibbrglarqhbmfmouiicditqurjrijejoqhbhdniiahnofhhglebaqfoohmfjocrpqdknkfssfpgqcjdgtrgmeosuufncetctbupeuetjntufneadhabgjjrclqbckgqsphpfnlrrioocohmdjscmqfmru"));
        Console.WriteLine(Result.stringConstruction("abcabc"));
        Console.ReadLine();
    }
}
