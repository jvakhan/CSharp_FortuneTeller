using System;

public class Fortune
{

		Random random = new Random();

		String[] fortunes =
		{

				"Listen to your gut feeling right now...even if you don't know what it's telling you...trust that there is a message you need to hear",

				"What you're seeking for, is seeking you.",

				"Do what you can, with what you have today...",

				"A new beginning is soon to come...",

				"If you've been through tough times...just remember that you now have the wisdom to help others who are experiencing pain in their lives",

				"Don't ever think that love is lost to you...your heart is open and you will find someone who will love you just as you are",

				"Tomorrow will bring you a surprise...it may be scary at first, but it will lead you to greater things in the future.",

				"There are many challenges ahead...but you can rise above them...you just need to tap into the strength of your being...",

				"The next big holiday for you could see some surprising developments...",

				"Sometimes the path to your future seems blocked...just remember that you are not meant to have answers for everything...just remember to trust your instincts and the voice of the universe...",

				"Some opportunities only come around once in a lifetime...jump on it...take the risk..",

				"You don't know what the future holds...that's the beauty of it...trust your ability to face whatever comes your way",

				"Fate loves a risk taker...you are the main character in the story of your life, so own it!",

				"The pain is real...but so is your power and resilience.  You'll make it through...one day at a time.",

				"The stars are aligning for you, to achieve your dreams.",

				"Sometimes you will be tempted to follow the crowd and to do what everyone else is doing...but listen to the voice of your soul and it will tell you to make your own way. ",

				"Life is a wild ride that can be full of joy and pain...just remember that this too shall pass...and the darkness too will turn to light.",

				"The universe can throw new people into your life...some will stay for a long time...some will be a quick but important part of your journey.",

				"Sometimes your dreams may seem like they aren't happening fast enough for you...just know that the universe works in its own way...and your destiny is to reach those dreams in due time.",

				"When you feel like you can no longer see the light at the end of the tunnel...just remember that your power is in your imagination...so think big and don't give up...your light will burn brighter than the light of a thousand suns.",

				"Don't be too trusting of the person who offers to help you with the promotion at work...they may just want something from you...",

				"You will win a random prize for some reason and be a bit confused...but trust that the universe is trying to tell you something...",

				"The road to your future is full of unexpected twists and turns...don't shy away from them...they are the path you were supposed to take...",

				"There may be someone in your life that does not have your best interests in mind...watch out for people trying to take advantage of you...you are better than that.",

				"You will hear a piece of news that will rock your world...if you just stay calm and think logically...you will make it through this crisis"

		};

    public Fortune(String name)
    {
        int number = random.Next(fortunes.Length);

        string fortune = fortunes[number];
        Format(fortune, name);
    }

    public void Format(string message, string name)
    {
		Console.WriteLine(name + ", Your Fortune is..");
		Console.WriteLine(message);
        Console.Write("\n\n");

        // Trust, it will create the crystal ball
        Console.WriteLine("                                  ▄▄█▀▀▀▀▀▀▀▀▄▄                                 \r\n                              ▄▀▀                 ▀█,                              \r\n\r\n                           ▄█-╒\"ⁿ                     ▀▄                             \r\n\r\n                         ╒█ ¿∞^\"                        ▀▌                            \r\n\r\n                         █▌                              █                            \r\n\r\n                         █▌                             █                            \r\n                                                     █▌                            \r\n                              █▄                   █▀                             \r\n                                ███▄           ▄█▀█                              \r\n                              █     ▀██▄▄▄▄▄██▀     █ \r\n                              █                     █                             \r\n\r\n                              \t  ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀\t          ");
		Console.WriteLine("Thank you for using the crystal ball.");
	}
}
