using System;

namespace q50
{
    interface ITelaTouch { void Tocar(); }

    class Dispositivo
    {
        public virtual void Ligar() => Console.WriteLine("Dispositivo ligando...");
    }

    class Smartphone : Dispositivo, ITelaTouch
    {
        public override void Ligar() => Console.WriteLine("Smartphone ligado!");
        public void Tocar() => Console.WriteLine("Smartphone respondendo ao toque.");
    }

    class Tablet : Dispositivo, ITelaTouch
    {
        public override void Ligar() => Console.WriteLine("Tablet ligado!");
        public void Tocar() => Console.WriteLine("Tablet respondendo ao toque.");
    }

    class Program
    {
        static void Main()
        {
            ITelaTouch s = new Smartphone();
            ITelaTouch t = new Tablet();

            s.Tocar();
            t.Tocar();

            Dispositivo d1 = new Smartphone();
            Dispositivo d2 = new Tablet();

            d1.Ligar();
            d2.Ligar();
        }
    }
}
