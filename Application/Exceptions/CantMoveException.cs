using System;
using Domain;

namespace Application.Exceptions
{
    public class CantMoveException 
    {

        public static Coordinates CantMove(string Message) {
            Console.WriteLine(Message);
            return null;
        }
        
    }
}