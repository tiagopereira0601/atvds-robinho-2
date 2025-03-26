﻿using System;

class Lampada
{
    private bool Ligada;

    public void Ligar()
    {
        Ligada = true;
        Console.WriteLine("A lâmpada foi ligada.");
    }

    public void Desligar()
    {
        Ligada = false;
        Console.WriteLine("A lâmpada foi desligada.");
    }

    public void MostrarEstado()
    {
        if (Ligada)
            Console.WriteLine("A lâmpada está ligada.");
        else
            Console.WriteLine("A lâmpada está desligada.");
    }
}

class Program
{
    static void Main()
    {
        Lampada lampada = new Lampada();

        lampada.MostrarEstado();
        lampada.Ligar();
        lampada.MostrarEstado();
        lampada.Desligar();
        lampada.MostrarEstado();
    }
}
