using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_RS_TCN
{
    public class ChatBot
    {
        public string Name { get; set; }
 
        List<string> answers = new List<string>();
        List<ChatBot> bots = new List<ChatBot>();

        public ChatBot(string name) { 
            Name = name;

        }
        public ChatBot() { }


        public void menu()
        {
            Console.WriteLine("Hei, velkommen til chatBot, nå kan du lage deg en chatbot eller snakke med en som finnes, Tast 1 for å lage, 2 for å snakke med en");
            string option = Console.ReadLine();
            checkTask(option);

        }
        void checkTask(string option)
        {
            switch (option)
            {
                case "1":
                    createBot();
                    menu();

                    break;

                case "2":
               
                    TalkToBot();

                    break;
            }
        }
        public void createBot()
        {
            Console.WriteLine(" skriv inn ønsket navn på Boten din");
            string chatBotName = Console.ReadLine();
            ChatBot chatBot = new ChatBot(chatBotName);
            bots.Add(chatBot);
            Console.WriteLine($"Du har laget en bot som heter: {chatBot.Name}");
         
         
            AddAnswer();
           
        

         
        }

        void AddAnswer()
        {
            Console.WriteLine("skriv inn ett svar som chatbot kan svare:");
            string answer = Console.ReadLine();
            answers.Add(answer);
            Console.WriteLine("Vil du legge til flere svar? Y/N");
            string a =Console.ReadLine();
            checkIfMoreAnswer(a);

        }

        void checkIfMoreAnswer(string moreAnswerOrNot)
        {
            if (moreAnswerOrNot == "Y")
            {
                AddAnswer();
            }
            else if (moreAnswerOrNot == "N")
            {
                {
                    menu();
                }
            }
        }



        public void TalkToBot()
        {
            Console.WriteLine($"Du snakker nå med {bots[0].Name}, hva vil du spørre om ");
            Console.ReadLine();

            Random random = new Random();

            int randomNr = random.Next(0, answers.Count);

            Console.WriteLine(answers[randomNr]);
            Console.WriteLine("vil du fortsette å snakke med meg? N/Y");
            string a =Console.ReadLine();

            if(a == "Y")
            {
                TalkToBot();
            }
            else
            {
                menu();
            }



        }
    }
}
