using System;
using System.Collections.Generic;

class Riddles {
    static void Main() {

        List<string> questions = new List<string> {"This thing all things devour: birds, beasts, trees, flowers; gnaws iron, bites steel; grinds hard stones to meal; slays kings, ruins towns; and beats high mountains down.", "In spring I am gay in handsome array; in summer more clothing I wear; when colder it grows, I fling off my clothes; and in winter quite naked appear.", "I’m alive, but without breath; I’m as cold in life as in death; I’m never thirsty, though I always drink.", "As small as your thumb, I am light in the air. You may hear me before you see me, but trust that I’m here.", "Never resting, never still; moving silently from hill to hill; it does not walk, run or trot; all is cool where it is not."};

        List<string> answers = new List<string> {"time", "tree", "fish", "hummingbird", "sun"};

        Console.WriteLine("Riddles of the Sphinx. Answer the questions.");

        int count = 0;

        for (int i = 0; i < 5; i++) {
            Random rnd = new Random();
            int randomInt = rnd.Next(questions.Count+1)-1;
            Console.WriteLine(questions[randomInt]);
            string answer = Console.ReadLine();
            if (answer == answers[randomInt]) {
                count ++;
            } else {
                count --;
                if (count < 0) {
                    break;
                }
            }
            questions.Remove(questions[randomInt]);
            answers.Remove(answers[randomInt]);
        }

        if (count > 0) {
            Console.WriteLine("The Sphinx is defeated!");
        } else {
            Console.WriteLine("The Sphinx has eaten you!");
        }


    }
}