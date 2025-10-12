
//Countdown Animation
//             for (int i = 5; i > 0; i--)
//             {
//                 Console.Write(i);
//                 Thread.Sleep(1000);
//                 Console.Write("\b \b");
//             }
//             Console.WriteLine("Done");

//Countdown Animation : Period
//             for (int i = 5; i > 0; i--)
//             {
//                 Console.Write(".");
//                 Thread.Sleep(1000);
//             }
//             Console.WriteLine("Done");

//Animation with spinner

//             List<string> animationStrings = new List<string>();
//             animationStrings.Add("|");
//             animationStrings.Add("/");
//             animationStrings.Add("-");
//             animationStrings.Add("\\");
//             animationStrings.Add("|");
//             animationStrings.Add("/");
//             animationStrings.Add("-");
//             animationStrings.Add("\\");
//             animationStrings.Add("|");
            
//            foreach (string s in animationStrings)
//             {
//                 string s = animationStrings[i];
//                 Console.Write(s);
//                 Thread.Sleep(1000);
//                 Console.Write("\b \b");
//              }
//             Console.WriteLine("spinner done");           

//Datetime Animation with spinner
//             
                // `DateTime startTime = DateTime.Now;
//             DateTime endTime = startTime.AddSeconds(10);

//             List<string> animationStrings = new List<string>();
//             animationStrings.Add("|");
//             animationStrings.Add("/");
//             animationStrings.Add("-");
//             animationStrings.Add("\\");
//             animationStrings.Add("|");
//             animationStrings.Add("/");
//             animationStrings.Add("-");
//             animationStrings.Add("\\");
//             animationStrings.Add("|");
            
//             int i = 0;

//             while (DateTime.Now < endTime)
//             {
//                 string s = animationStrings[i];
//                 Console.Write(s);
//                 Thread.Sleep(1000);
//                 Console.Write("\b \b");
//                 i++;

//                 if (i >= animationStrings.Count)
//                 {
//                     i = 0;
//                 }
//             }
//             Console.WriteLine("Seconds done");
//         }

//Duration for program
        // int seconds = 0;
        //     Console.Write("how many seconds: ");
        //     seconds = int.Parse(Console.ReadLine());
        //     DateTime startTime = DateTime.Now;
        //     DateTime futureTime = startTime.AddSeconds(_duration);

        //     Thread.Sleep(seconds*1000);

        //     DateTime currentTime = DateTime.Now;
        //     if (currentTime < futureTime)
        //     {
        //         Console.WriteLine("We have not arrived at our future time yet...");
        //     }   

