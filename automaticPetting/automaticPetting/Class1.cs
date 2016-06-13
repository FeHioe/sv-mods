using StardewModdingAPI;
using StardewValley;
using System;

namespace automaticPetting
{
    public class animalHeartsClass : Mod
    {
        public override void Entry(params object[] objects)
        {
            Log.Info("automaticPetting has loaded");
            StardewModdingAPI.Events.TimeEvents.DayOfMonthChanged += new_day; //Trigger event on each new day
        }

        static void new_day(object sender, EventArgs e)
        {
            Farm farm = Game1.getFarm();
           
            foreach (FarmAnimal animal in farm.getAllFarmAnimals())
            {
                if (!animal.wasPet)
                {
                    animal.wasPet = true;
                }
            }
        }

    }
}
