using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mammals myMammal = new Mammals();

            //Console.WriteLine(myMammals.HasSkin);
            //myMammal.HasSkin = true;
            //Console.WriteLine(myMammal.HasHair);
            //myMammal.HasHair = true;
            //Console.WriteLine(myMammal.HasWarmBlood);
            //Console.WriteLine(myMammal.HasMamaryGlands);
            //Console.WriteLine(myMammal.HasOrgans);
            //Consloe.WriteLine(myMammal.HasSingleLowerBoneJaw);
            //Console.WriteLine(myMammal.HasDiphyodonty);
            //Console.WriteLine(myMammal.HasKidsNotInEggs);
            //Console.WriteLine(myMammal.HasThreeMiddleEarBones);

            Birds myBird = new Birds();
            Console.WriteLine(myBird.HasFeathers);
            myBird.HasFeathers = true;
            Console.WriteLine(myBird.hasFeathes);
            Console.WriteLine(myBird.hasBeaks);
            Console.WriteLine(myBird.hasEggs);
            Console.WriteLine(myBird.hasWings);
            Console.WriteLine(myBird.hasBackbone);

            MythicalCreature myMythicalCreature = new MythicalCreature();
            Console.WriteLine(myMythicalCreature.hasUniquePowers);
            Console.WriteLine(myMythicalCreature.numMyths);
            Console.WriteLine(myMythicalCreature.hasMultipleAnimals);
            



        }
    }
}
