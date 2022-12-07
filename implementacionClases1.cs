using System;

class Animal {

    public void eat(){
        Console.WriteLine("Los animales comen!");
    }
}

class Kryptonian : Animal {
    
}

class Supermam : Kryptonian {

    public void takeOff(){
        Console.WriteLine("Pirede poderes");
    }

    public void land(){
        Console.WriteLine("Superman esta en el suelo.");

    }

    public void fly(){
        Console.WriteLine("Superman puede volar");
    }

    public void leapBuilding(){
        Console.WriteLine("Superman puede saltar");
    }

    public void stopBullet(){
        Console.WriteLine("No puede saltar.");
    }

    public void eat(){
        Console.WriteLine("Puede comer");
    }
}

class Bird : Animal {

    public void takeOff()
    {
        Console.WriteLine("El ave no se detiene");
    }

    public void land()
    {
        Console.WriteLine("El ave no esta en el suelo");
    }

    public void buildNest()
    {
        Console.WriteLine("El ave construye su nido.");
    }

    public void layEggs()
    {
        Console.WriteLine("El ave pone huevos.");
    }   

    public void eat()
    {
        Console.WriteLine("El ave come.");
    } 
}

//tester-class

class tester
{
    public static void Main()
    {
        Kryptonian uAnimal = new Supermam();

        uAnimal.eat();

       // Kryptonian superman = new Supermam();
       // superman.fly();

       Supermam supermam = new Supermam();
       supermam.fly();
       supermam.land();
       supermam.leapBuilding();
       supermam.stopBullet();
       supermam.takeOff();

        Bird oAnimal = new Bird();
        oAnimal.buildNest();
        oAnimal.land();
        oAnimal.buildNest();
        oAnimal.layEggs();
        oAnimal.eat();
    }
}