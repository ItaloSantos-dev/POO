using System;

abstract class Simulador
{
    public abstract void Iniciar();
    public abstract void Executar();
    public abstract void Finalizar();
}

class SimuladorJogo : Simulador
{
    public override void Iniciar()
    {
        Console.WriteLine("Jogo iniciado!");
    }

    public override void Executar()
    {
        Console.WriteLine("Executando partida do jogo...");
    }

    public override void Finalizar()
    {
        Console.WriteLine("Jogo finalizado! Pontuação salva.");
    }
}

class SimuladorTreinamento : Simulador
{
    public override void Iniciar()
    {
        Console.WriteLine("Treinamento iniciado!");
    }

    public override void Executar()
    {
        Console.WriteLine("Treinamento em progresso...");
    }

    public override void Finalizar()
    {
        Console.WriteLine("Treinamento finalizado! Resultados avaliados.");
    }
}

class Program
{
    static void Main()
    {
        Simulador jogo = new SimuladorJogo();
        Simulador treino = new SimuladorTreinamento();

        jogo.Iniciar();
        jogo.Executar();
        jogo.Finalizar();

        Console.WriteLine();

        treino.Iniciar();
        treino.Executar();
        treino.Finalizar();
    }
}

