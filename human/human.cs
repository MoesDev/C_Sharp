using System;

namespace human{

    public class Human{

        public string name;
        public int strength = 3, intelligence = 3, dexterity = 3, health =100;

        public Human(string theName){
            name = theName;
        }
        public Human(string theName, int valS, int valI, int valD, int valH){
            name = theName;
            strength = valS;
            intelligence = valI;
            dexterity = valD;
            health = valH;
        }
        public void Attack(Human theAttackedHuman){
            theAttackedHuman.health -= (strength*5);
        }
    }
}
