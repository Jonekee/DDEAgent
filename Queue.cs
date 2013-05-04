﻿using System;
using System.Collections;
public class MyQueue {

    public string Queue(string newValue) {
        // Creates and initializes a new Queue.
        Queue myQ = new Queue();

        myQ.Enqueue("Hello");
        myQ.Enqueue("World");
        myQ.Enqueue("!");
 
        // Displays the properties and values of the Queue.
        Console.WriteLine( "myQ" );
        Console.WriteLine( "\tCount:    {0}", myQ.Count );
        Console.Write( "\tValues:" );
        PrintValues( myQ );

        return "null";
    }

    public string AddQueue(string newValue) {
        
        return newValue;
    }
 
    public void PrintValues( IEnumerable myCollection )  {
        foreach ( Object obj in myCollection )
            Console.Write( "    {0}", obj );
        Console.WriteLine();
    }
}
/* 
This code produces the following output.
 
myQ
Count:    3
Values:    Hello    World    !
*/