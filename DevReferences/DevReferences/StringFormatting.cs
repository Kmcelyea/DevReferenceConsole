using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevReferences
{
    public class StringFormatting
    {
        public void ShowStrings()
        {
            Console.Clear();
            Console.SetWindowSize(100, 95);
            Console.BufferWidth = 100;
            Console.BufferHeight = 100;
            Console.ForegroundColor = ConsoleColor.Green;
            // Set the window size and title
            Console.Title = "String Formatting";
            Console.Clear();
            Console.WriteLine("There really isn’t any formatting within a string, beyond it’s alignment.");
            Console.WriteLine("Alignment works for any argument being printed in a String.Format call.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Samples");
            Console.WriteLine("-------");
            Console.WriteLine("String.Format(“->{1,10}<-”, “Hello”);");
            Console.WriteLine("Generates : -> Hello<-");
            Console.WriteLine();
            Console.WriteLine("String.Format(“->{1,-10}<-”, “Hello”);");
            Console.WriteLine("Generates : ->Hello <-)");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Numbers");
            Console.WriteLine("-------");
            Console.WriteLine("Specifier     Type           Format      Output (Passed Double 1.42)    Output (Passed Int -12400)");
            Console.WriteLine("c	        Currency        {0:c}       $1.42                           -$12,400");
            Console.WriteLine("d	        Decimal         {0:d}       System.FormatException          12400");
            Console.WriteLine("e	        Scientific      {0:e}	    1.420000e+000	          -1.240000e+004");
            Console.WriteLine("f	        Fixed point     {0:f}	    1.42	                        -12400.00");
            Console.WriteLine("g	        General	        {0:g}	    1.42	                        -12400");
            Console.WriteLine("n	        Number	        {0:n}	    1.42	                        -12,400");
            Console.WriteLine("r	        Round trippable	{0:r}	    1.42	                 System.FormatException");
            Console.WriteLine("x	        Hexadecimal    {0:x4}	    System.FormatException	        cf90");
            Console.WriteLine();
            Console.WriteLine("Dates");
Console.WriteLine("Note that date formatting is especially dependant on the system’s regional settings; the example strings here are from my local locale.");
Console.WriteLine();
Console.WriteLine("Specifier	Type	                    Example (Passed System.DateTime.Now)");
Console.WriteLine("d	    Short date	                    10/12/2002");
Console.WriteLine("D	    Long date	                    December 10, 2002");
Console.WriteLine("t	    Short time	                    10:11 PM");
Console.WriteLine("T	    Long time	                    10:11:29 PM");
Console.WriteLine("f	    Full date & time	            December 10, 2002 10:11 PM");
Console.WriteLine("F	    Full date & time (long)	        December 10, 2002 10:11:29 PM");
Console.WriteLine("g	    Default date & time	            10/12/2002 10:11 PM");
Console.WriteLine("G	    Default date & time (long)	    10/12/2002 10:11:29 PM");
Console.WriteLine("M	    Month day pattern	            December 10");
Console.WriteLine("r	    RFC1123 date string	            Tue, 10 Dec 2002 22:11:29 GMT");
Console.WriteLine("s	    Sortable date string	        2002-12-10T22:11:29");
Console.WriteLine("u	    Universal sortable, local time  2002-12-10 22:13:50Z");
Console.WriteLine("U	    Universal sortable, GMT	        December 11, 2002 3:13:50 AM");
Console.WriteLine("Y	    Year month pattern	            December, 2002");
Console.WriteLine("");
Console.WriteLine("The ‘U’ specifier seems broken; that string certainly isn’t sortable.");
Console.WriteLine("");
Console.WriteLine("Custom date formatting:");
Console.WriteLine("");
Console.WriteLine("Specifier	Type	                        Example	        Example Output");
Console.WriteLine("dd	        Day	                            {0:dd}	        10");
Console.WriteLine("ddd	        Day name	                    {0:ddd}	        Tue");
Console.WriteLine("dddd	     Full day name	                    {0:dddd}	    Tuesday");
Console.WriteLine("f,       ff, …	Second fractions	        {0:fff}	        932");
Console.WriteLine("gg,      …	Era	                            {0:gg}	        A.D.");
Console.WriteLine("hh	        2 digit hour	                {0:hh}	        10");
Console.WriteLine("HH	        2 digit hour, 24hr format	    {0:HH}	        22");
Console.WriteLine("mm	        Minute 00-59	                {0:mm}	        38");
Console.WriteLine("MM	        Month 01-12	                    {0:MM}	        12");
Console.WriteLine("MMM	        Month abbreviation	            {0:MMM}	        Dec");
Console.WriteLine("MMMM	        Full month name	                {0:MMMM}	    December");
Console.WriteLine("ss	        Seconds 00-59	                {0:ss}	        46");
Console.WriteLine("tt	        AM or PM	                    {0:tt}	        PM");
Console.WriteLine("yy	        Year, 2 digits	                {0:yy}	        02");
Console.WriteLine("yyyy	        Year	                        {0:yyyy}	    2002");
Console.WriteLine("zz	        Timezone offset, 2 digits	    {0:zz}	        -05");
Console.WriteLine("zzz	        Full timezone offset	        {0:zzz}	        -05:00");
Console.WriteLine(":	        Separator	                    {0:hh:mm:ss}	10:43:20");
Console.WriteLine("/	        Separator	                    {0:dd/MM/yyyy}	10/12/2002");
Console.WriteLine("");
Console.WriteLine("Enumerations");
Console.WriteLine("Specifier	Type");
Console.WriteLine("g	        Default (Flag names if available, otherwise decimal)");
Console.WriteLine("f	        Flags always");
Console.WriteLine("d	        Integer always");
Console.WriteLine("x	        Eight digit hex.");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("1. Home");
Console.WriteLine("2. ASCII Characters");
Console.WriteLine("3. Exit");
string ValidInput;
do
{

    ValidInput = Console.ReadLine();
    switch (ValidInput)
    {
        case "1"://Strings
            Program main = new Program();
            main.Restart();
            break;
        case "2"://ASCII
            ASCII ascii = new ASCII();
            ascii.ASCIIShow();
            break;
        case "3"://Exit
            Program exit = new Program();
            exit.Exit();
            break;
            
    }
}
while (ValidInput != "0");
            Console.Read();
        }
    }
}
