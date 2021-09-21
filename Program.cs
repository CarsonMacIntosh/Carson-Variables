using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsonVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variables Test");
            Console.WriteLine("Press any key to advance text");
            Console.ReadKey(true);

            //stats start

            string mood;
            mood = "Great";

            int score;
            score = 0;

            float health;
            health = 100.0f;

            float shield;
            shield = 100.0f;

            int lives;
            lives = 3;

            int scoreMultiplier;
            scoreMultiplier = 1;

            //stats end

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Mood: " + mood);
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Shield: " + shield);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Score Multiplier: x" + scoreMultiplier);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("You've entered the dungeon");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");
            Console.ReadKey(true);


            score = score + 100;
            shield = shield - 0.46f;

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Mood: " + mood);
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Shield: " + shield);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Score Multiplier: x" + scoreMultiplier);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("You fight a slime, you gain 100");
            Console.WriteLine("points, but your shield was");
            Console.WriteLine("damaged by 0.46 points.");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");
            Console.ReadKey(true);


            score = score + 500;
            scoreMultiplier = scoreMultiplier + 1;
            mood = "Greedy";

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Mood: " + mood);
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Shield: " + shield);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Score Multiplier: x" + scoreMultiplier);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("You find a bag of money, you");
            Console.WriteLine("get 500 points and a Score");
            Console.WriteLine("Multiplier of x2!");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");
            Console.ReadKey(true);


            score = score + (300 * scoreMultiplier);
            health = health - 25.4f;
            shield = shield - 11.6f;

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Mood: " + mood);
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Shield: " + shield);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Score Multiplier: x" + scoreMultiplier);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("You encounter 3 slimes! You take");
            Console.WriteLine("them out one by one with your");
            Console.WriteLine("new found pride and get 600");
            Console.WriteLine("points! That's 300 x 2 thanks to");
            Console.WriteLine("your score multiplier! Though you");
            Console.WriteLine("took 25.4 points of health and");
            Console.WriteLine("11.6 points of shield damage.");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");
            Console.ReadKey(true);


            lives = lives + 1;
            health = 100.0f;


            Console.WriteLine("--------------------------------");
            Console.WriteLine("Mood: " + mood);
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Shield: " + shield);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Score Multiplier: x" + scoreMultiplier);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("You found a copyright friendly");
            Console.WriteLine("mushroom! It gave you an extra");
            Console.WriteLine("life! It also healed you to");
            Console.WriteLine("full health!");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");
            Console.ReadKey(true);


            mood = "Dead";
            health = health - 100.0f;
            shield = shield - 87.94f;
            lives = lives - 1;

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Mood: " + mood);
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Shield: " + shield);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Score Multiplier: x" + scoreMultiplier);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("You encounter a big scary");
            Console.WriteLine("monster! You being so egotistical");
            Console.WriteLine("after getting that money bag made");
            Console.WriteLine("you challenge this monster thinking");
            Console.WriteLine("you'd actually beat it. Boy how you");
            Console.WriteLine("were wrong! The monster ended up");
            Console.WriteLine("making you lose 100 points of");
            Console.WriteLine("health and 87.94 points of your");
            Console.WriteLine("shield's health! Which were both");
            Console.WriteLine("coincidentally the exact numbers");
            Console.WriteLine("needed to bring your health and");
            Console.WriteLine("shield down to exactly 0!");
            Console.WriteLine("(you're dead btw lol)");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");
            Console.ReadKey(true);


            mood = "Alive and Traumatized";
            score = 0;
            health = 100.0f;
            shield = 100.0f;
            scoreMultiplier = 1;

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Mood: " + mood);
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Shield: " + shield);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Score Multiplier: x" + scoreMultiplier);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("You respawn at the enterance of");
            Console.WriteLine("the dungeon. You decide to get");
            Console.WriteLine("the hell outta there!");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");
            Console.ReadKey(true);

            Console.WriteLine("The End");
            Console.WriteLine("");
            Console.WriteLine("Made by Carson MacIntosh");
            Console.ReadKey(true);

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("2");
            Console.ReadKey(true);
        }
    }
}
