using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            TV myTV = new TV();
            myTV.currentChannel = 1;
            int answer;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Текущий канал - " + myTV.currentChannel);
                Console.WriteLine("\n1 - Предыдущий канал\n2 - Следующий канал\n3 - Ввести канал");
                if (int.TryParse(Console.ReadLine(), out answer))
                {
                    switch (answer)
                    {
                        case 1:
                            myTV.previousChannel();
                            break;
                        case 2:
                            myTV.nextChannel();
                            break;
                        case 3:
                            myTV.changeChannel();
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }

    class TV
    {
        public int currentChannel;

        public void changeChannel()
        {
            Console.WriteLine("Введите канал");
            if (int.TryParse(Console.ReadLine(), out int channel) && channel > 0)
            {
                currentChannel = channel;
            }
        }
        public void nextChannel()
        {
            currentChannel++;
        }
        public void previousChannel()
        {
            if (currentChannel > 1) currentChannel--;
        }
    }
}
