
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MarsRover
{

    static int m;
    static int n;
    static void Main(string[] args)
    {

        m = 5;
        n = 5;
        Position currentPosition = new Position();
        currentPosition.x = 1;
        currentPosition.y = 2;
        currentPosition.dir = "N";

        String command = "LMLMLMLMM";

        foreach (char c in command)
        {
            if (c == 'L')
            {
                if (currentPosition.dir == "N")
                    currentPosition.dir = "W";
                else if (currentPosition.dir == "W")
                    currentPosition.dir = "S";
                else if (currentPosition.dir == "S")
                    currentPosition.dir = "E";
                else if (currentPosition.dir == "E")
                    currentPosition.dir = "N";  

            }

            if (c == 'M')
            {
                if (currentPosition.dir == "N")
                    currentPosition.y++;
                else if (currentPosition.dir == "W")
                    currentPosition.x--;
                else if (currentPosition.dir == "S")
                    currentPosition.y--;
                else if (currentPosition.dir == "E")
                    currentPosition.x++;

            }

        }

        Console.WriteLine(currentPosition.x + " " + currentPosition.y + " " + currentPosition.dir);


    }


    class Position
    {
        public int x;
        public int y;
        public String dir;

    }

}





