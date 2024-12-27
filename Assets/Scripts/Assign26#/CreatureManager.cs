using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment26
{
    public class CreatureManager : MonoBehaviour
    {
        void Start()
        {
            List<Creature> creatures = new List<Creature>
            {
                new Kangaroo(),
                new Duck()
            };

            List<IRunnable> runnableCreatures = new List<IRunnable>();
            List<IJumpable> jumpableCreatures = new List<IJumpable>();
            List<ISwimmable> swimmableCreatures = new List<ISwimmable>();

            foreach (Creature creature in creatures)
            {
                // have read about this if statment online 
                //it checks if the specefied creature implements the mentioned interfcae 
                //, if yes it is stored in the variable runnable and then could be passed to add in list
                // instead of manually adding the creatures to the lists
                if (creature is IRunnable runnable)
                {
                    runnableCreatures.Add(runnable);
                }

                if (creature is IJumpable jumpable)
                {
                    jumpableCreatures.Add(jumpable);
                }

                if (creature is ISwimmable swimmable)
                {
                    swimmableCreatures.Add(swimmable);
                }
            }

            foreach (Creature creature in creatures)
            {
                creature.Speak();
            }

            foreach (IRunnable runnable in runnableCreatures)
            {
                runnable.Run();
            }

            foreach (IJumpable jumpable in jumpableCreatures)
            {
                jumpable.Jump();
            }

            foreach (ISwimmable swimmable in swimmableCreatures)
            {
                swimmable.Swim();
            }
        }
    }
}
