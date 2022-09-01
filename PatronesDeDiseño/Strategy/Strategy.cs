using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronesDeDiseño.ClasesVarias;
using PatronesDeDiseño.Strategy.Fly;
using PatronesDeDiseño.Strategy.QuackFolder;

namespace PatronesDeDiseño.Strategy
{
    public class Strategy
    {
        Duck duck = new MallardDuck();
        public void Menu()
        {
            Please.WriteWithTop(" ----- Strategy ----- ");
            Please.WriteLine("¡Nacio un patito!");
            Please.WriteLine("¿Que quieres hacer con tu nuevo pato?");
            MainMenuOptions();

            int vuelta = 0;
            bool done = false;
            while (!done)
            {
                if (vuelta > 0)
                {
                    Please.WriteWithTop(" ----- Strategy ----- ");
                    Please.WriteLine("¿Ahora que quieres hacer con tu pato?");
                    MainMenuOptions();
                }
                switch (Please.AskToUser())
                {
                    case -1:
                        Please.WriteWithTop("Hey, esperaba un numero");
                        break;
                    case 1:
                        duck.Display();
                        Please.Wait();
                        break;
                    case 2:
                        duck.PerformQuack();
                        Please.Wait();
                        break;
                    case 3:
                        duck.PerformFly();
                        Please.Wait();
                        break;
                    case 4:
                        ChangeQuackBeheavor();
                        break;
                    case 5:
                        ChangeFlyBeheavor();
                        break;
                    case 6:
                        done = true;
                        break;
                    default:
                        Please.WriteWithTop("Mmmmmmm, no, ese numero no esta en la lista");
                        break;
                }
                vuelta++;
            }
        }

        void ChangeFlyBeheavor()
        {
            ChangeFlyBeheavorMenu();
            switch (Please.AskToUser())
            {
                case 1:
                    FlyWithWings flyWithWings = new();
                    duck.SetFlyBehavior(flyWithWings);
                    Please.WriteWithTop("¡¡Ahora tu pato puede volar!!");
                    break;
                case 2:
                    FlyNoWay flyNoWay = new();
                    duck.SetFlyBehavior(flyNoWay);
                    Please.WriteWithTop("Tu pato ya no puede volar :(");
                    break;
                default:
                    break;
            }
            Please.Wait();
        }

        void ChangeFlyBeheavorMenu()
        {
            Please.WriteWithTop("¿Como quieres que tu pato vuele?");
            Please.WriteLine("1. Fly with wings");
            Please.WriteLine("2. Fly no way");
            Please.GiveMePadding();
        }

        void ChangeQuackBeheavor()
        {
            ChangeQuackBeheavorMenu();
            switch (Please.AskToUser())
            {
                case 1:
                    MuteQuack muteQuack= new();
                    duck.SetQuackBehavior(muteQuack);
                    Please.WriteWithTop("Tu pato esta mudo :'(");
                    break;
                case 2:
                    Quack quack = new();
                    duck.SetQuackBehavior(quack);
                    Please.WriteWithTop("¡¡Ahora tu pato hace Quack!!");
                    break;
                case 3:
                    Squeak squeak = new();
                    duck.SetQuackBehavior(squeak);
                    Please.WriteWithTop("¡¡Ahora tu pato hace Squeak!!");
                    break;
                default:
                    break;
            }
            Please.Wait();
        }

        void ChangeQuackBeheavorMenu()
        {
            Please.WriteWithTop("¿Que sonido quieres que haga tu pato?");
            Please.WriteLine("1. Mute");
            Please.WriteLine("2. Quack");
            Please.WriteLine("3. Squeak");
            Please.GiveMePadding();
        }

        void MainMenuOptions()
        {
            Please.WriteLine("1. Display");
            Please.WriteLine("2. Hacer Quack");
            Please.WriteLine("3. Volar");
            Please.WriteLine("4. Cambiar Quack");
            Please.WriteLine("5. Cambiar forma de vuelo");
            Please.WriteLine("6. Salir");
            Please.GiveMePadding();
        }
    }
}
