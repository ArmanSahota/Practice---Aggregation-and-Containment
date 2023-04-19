using Practice___Aggregation_and_Containment;

Cpu cpu = new Cpu(true, "Ryzen 9 5950X", 16);
MotherBoard mobo = new MotherBoard(32, cpu.IsAmd, 3);
Extra extra = new Extra("850W", "GeForce RTX 3080", "ATX");

Console.WriteLine($"CPU: {cpu}");
Console.WriteLine($"Motherboard: {mobo}");
Console.WriteLine($"Extra: {extra}");
