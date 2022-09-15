string answerOne;

string answerTwo;

string answerThree;

string answerFour;

Console.WriteLine("Hello and welcme to the unfair game");

Console.WriteLine("You find yourself in a alley. do you go forward or stay? [forward/stay]");

answerOne = Console.ReadLine();
if (answerOne == "forward")
{
    Console.WriteLine("you go forward and find yourself infront of ica. Do you enter or do you continue on? [enter/continue]");

    answerTwo = Console.ReadLine();
    if (answerTwo == "continue")
    {
     Console.WriteLine("You continue on your weird journey instead of grabbing some instant noodles. As you continue on, a man apporaches you and offers you jello? Do you accept or decline? [accept/decline]");

        answerThree = Console.ReadLine();
        if (answerThree == "decline")
        {
            Console.WriteLine("You decline his gift and go to the Tunnelbana and take the Gröna linjen to home. At your doorstep there is a policeman wating for you. He draws his gun and asks you to identify yourself. Do you show him your id card or do you run towards him? [show/run]");

            answerFour = Console.ReadLine();
            if (answerFour == "show")
            {
                Console.WriteLine("You show him your id card and he shoots you on the spot. turns out, it's hard being Osama Bin Laden after 9/11");
            }

            else
            {
                Console.WriteLine("You ran at him fast and he shot you. You died!");
            }
        }
        
        else 
        {
            Console.WriteLine("you accept his jello! You eat it and you died. Anthrax is bad for you");
        }


    }

    else 
    {
        Console.WriteLine("You entered ica and died! turns out there was an IED at the door and you walked in on it");
    }
}
else
{
    Console.WriteLine("You waited in the alley and some guy stabbed you to death lol!");
}


Console.ReadLine();
