public class Clock
{
    private int mins {get; set;}
    private int hrs {get; set;}
    public Clock(){}
    public void startClock() {
        int h;
        int m;
        bool validHrs = false;
        bool validMins = false;

        while (!validHrs) {
            Console.Write("Enter hours between 1 and 12: ");
            string? input = Console.ReadLine();            
            if (int.TryParse(input, out h)) {
                if (h > 0 && h <= 12) {
                    validHrs = true;
                    hrs = h;
                }
                else Console.WriteLine("Invalid input: please enter hours between 1 and 12.");              
            } else Console.WriteLine("Invalid input: please enter a valid integer.");          
        }

        while (!validMins) {
            Console.Write("Enter minutes between 0 and 59: ");
            string? input = Console.ReadLine();            
            if (int.TryParse(input, out m)) {
                if (m >= 0 && m <= 59) {
                    validMins = true;
                    mins = m;
                }
                else Console.WriteLine("Invalid input: please enter minutes between 0 and 59.");              
            } else Console.WriteLine("Invalid input: please enter a valid integer.");          
        }
        drawClock();
        getTime();
    }
    private void drawClock() {
        for(int i = 1; i <= 9; i++) {
            switch(i) {
                case 1:
                    Console.WriteLine(" !^^^^^^^^^^^^^^^^^!");
                    Console.WriteLine(" !       12        !");
                    break;
                case 2:
                    string[] str2 = {" !     ", "\\", "  ", "|", "  ", "/", "     !"};
                    drawParts(str2, i);
                    break;
                case 3:
                    string[] str3 = {" !      ", "\\", " ", "|", " ", "/", "      !"};
                    drawParts(str3, i);
                    break;
                case 4:
                    string[] str4 = {" !       ", "\\", "|", "/", "       !"};
                    drawParts(str4, i);
                    break;
                case 5:
                    string[] str5 = {" ! 9 ", "-----", "O", "-----", " 3 !"};
                    drawParts(str5, i);
                    break;
                case 6:
                    string[] str6 = {" !       ", "/", "|", "\\", "       !"};
                    drawParts(str6, i);
                    break;
                case 7:
                    string[] str7 = {" !      ", "/", " ", "|", " ", "\\", "      !"};
                    drawParts(str7, i);
                    break;
                case 8:
                    string[] str8 = {" !     ", "/", "  ", "|", "  ", "\\", "     !"};
                    drawParts(str8, i);
                    break;
                case 9:
                    Console.WriteLine(" !        6        !");
                    Console.WriteLine(" !_________________!");
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }
    }
    private void drawParts(string[] str, int i) {
        for(int j = 0; j < str.Length; j++) {
            string s = str[j];
            switch (s) {
                case "|":
                    if(i < 5 && (hrs == 12 || mins == 0) ) Console.Write(s);
                    else if(i > 5 && (hrs == 6 || mins == 30)) Console.Write(s);
                    else Console.Write(" ");
                    break;
                case "/":
                    if(i < 5 && ((hrs > 0 && hrs < 3) || (mins > 0 && mins < 15)) ) Console.Write(s);
                    else if(i > 5 && ((hrs > 6 && hrs < 9) || (mins > 30 && mins < 45))) Console.Write(s);
                    else Console.Write(" ");
                    break;
                case "\\":
                    if(i < 5 && ((hrs > 9 && hrs < 12) || (mins > 45 && mins < 60))) Console.Write(s);
                    else if(i > 5 && ((hrs > 3 && hrs < 6) || (mins > 15 && mins < 30))) Console.Write(s);
                    else Console.Write(" ");
                    break;
                case "-----":
                    if (j == 1 && (hrs == 9 || mins == 45)) Console.Write(s);
                    else if(j == 3 && (hrs == 3 || mins == 15)) Console.Write(s);
                    else Console.Write("     ");
                    break;
                default:
                    Console.Write(s);
                    break;
            }
        }
        Console.WriteLine();
    }
    private void getTime() {
        double angle1 = Math.Abs(30*hrs - 5.5*mins);
        double angle2 = 360 - angle1;
        double lesserAngle = angle1 < angle2 ? angle1 : angle2;
        string formattedTime = hrs.ToString("00") + ":" + mins.ToString("00");
        Console.WriteLine($"Time: {formattedTime}");
        Console.WriteLine($"Lesser Angle: {lesserAngle}°");
    }
}

/*
Clock Template:
 !^^^^^^^^^^^^^^^^^!
 !       12        !
 !     \  |  /     !
 !      \ | /      !
 !       \|/       !
 ! 9 -----O----- 3 !
 !       /|\       !
 !      / | \      !
 !     /  |  \     !
 !        6        !
 !_________________!
*/