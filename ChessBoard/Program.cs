namespace ChessBoard
{ // Kristin BUV26
    internal class Program
    {   
        static void Main(string[] args)
        {

            // Activate UTF-8 for the console to be able to show ◻︎◼︎
           Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Below I ask the user to tell how many rows and columns the person wants.
            Console.WriteLine("Ange en siffra: ");
            int columns = int.Parse(Console.ReadLine());
                    
            // White loop for the chessboard
            for (int w = 0; w < columns; w++)
            {
                // Black loop for the chessboard
                for (int b = 0; b < columns; b++)
                {
                    //Asking the program to see if a number is dividable by 2, if true write ◻︎ if false write ◼︎.
                    if ((b + w) % 2 == 0) 
                    {
                        Console.Write("◻︎ ");
                    }
                    else
                    {
                        Console.Write("◼︎ ");
                    }
                    
                }
                //Adding a new row between each written loop. This creates the board.
                Console.WriteLine();
            }
            Console.WriteLine();

            
        }
    }
}
