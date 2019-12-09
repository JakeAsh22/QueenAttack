using System;

    class Coord 
    {
        static void Main()
        {
            Console.WriteLine("Please enter the X coordinate for your chess piece (1-8).");
            int userPieceX = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Y coordinates for your chess piece (1-8).");
            int userPieceY = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter X coordinates for the Queen (1-8).");
            int userQueenX = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Y coordinates for the Queen (1-8).");
            int userQueenY = int.Parse(Console.ReadLine());
            
            Check(userPieceX, userPieceY, userQueenX,  userQueenY);
        }

        static void Check(int userPieceX, int userPieceY, int userQueenX, int userQueenY)
        {
            if ((userPieceX == userQueenX || userPieceY == userQueenY) || (Math.Abs((userPieceX-userQueenX)/(userPieceY-userQueenY))==1))
            {
                Console.WriteLine("True");
            } else {
                  Console.WriteLine("False");
            }
        }
    }