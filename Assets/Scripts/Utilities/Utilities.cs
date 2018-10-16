/* Petto: An AI Driven Virtual Pet Mobile Game
 * 
 * Developed & Designed By: VITAN, Justine Paul S.
 *                          PEREZ, Jance Gionn M.
 *                          TALAMAYAN, John Albert P.
 * 
 * Last Updated: October 16, 2018
 */

/* ============================== */
#region Imports
using UnityEngine;
using System;
#endregion
/* ============================== */

/* ====================
 * PlayerPrefs Documentation
 * 
 * VAL -> USE -> POSSIBLE VALUES
 * UserRegistered -> Checks if user is already registered -> [Y]
 * DogBreed -> The breed of the dog -> [P, G, B]
 * DogGender -> The gender of the dog -> [M, F]
 * DogName -> The name of the dog -> [{Any}]
 * DogHealthiness -> The healthiness of the dog -> [Range(1, 10)]
 * DogHappiness -> The hapiness of the dog -> [Range(1, 10)]
 * DogSatiation -> The satiation of the dog -> [Range(1, 10)]
 * DogStress -> The stress of the dog -> [Range(1, 10)]
 * DogEnergy -> The energy of the dog -> [Range(1, 10)]
 * LastMainGameExitTime -> Date and time where the player last exited the "Main Game" scene -> [MM/dd/yy hh:mm:ss]
 * ====================
 */

public class Utilities{
    
    public static bool userHasRegistered(){
        return PlayerPrefs.HasKey("UserRegistered");
    }

    public static string getDogBreed()
    {
        return PlayerPrefs.GetString("DogBreed");
    }

    public static string getDogGender()
    {
        return PlayerPrefs.GetString("DogGender");
    }

    public static string getDogName()
    {
        return PlayerPrefs.GetString("DogName");
    }

    public static float getDogHealthiness()
    {
        return PlayerPrefs.GetFloat("DogHealthiness");
    }

    public static float getDogHappiness()
    {
        return PlayerPrefs.GetFloat("DogHappiness");
    }

    public static float getDogSatiation()
    {
        return PlayerPrefs.GetFloat("DogSatiation");
    }

    public static float getDogStress()
    {
        return PlayerPrefs.GetFloat("DogStress");
    }

    public static float getDogEnergy()
    {
        return PlayerPrefs.GetFloat("DogEnergy");
    }

    public static void updateLastMainGameExitTime()
    {
        PlayerPrefs.SetString("LastMainGameExitTime", DateTime.Now.ToString());
    }

    public static string getLastMainGameExitTime()
    {
        return PlayerPrefs.GetString("LastMainGameExitTime");
    }

    public static double getDifferenceBetweenLastMainGameExitTime(DateTime dateTime)
    {
        return dateTime.Subtract(DateTime.Parse(getLastMainGameExitTime())).TotalMinutes;
    }

    public static void updateConditionMetersWhenStartingMainGame(DateTime dateTime, float healthinessDeductionValuePerMinute, float happinessDeductionValuePerMinute, float satiationDeductionValuePerMinute, float stressDeductionValuePerMinute, float energyDeductionValuePerMinute)
    {
        // Note: Debug this area first before adding other condition meters.
        PlayerPrefs.SetFloat("DogHealthiness", PlayerPrefs.GetFloat("DogHealthiness") - (healthinessDeductionValuePerMinute * Convert.ToSingle(getDifferenceBetweenLastMainGameExitTime(dateTime))));
    }

    public static void initializeConditionMetersWhenStartingGame(){
        PlayerPrefs.SetFloat("DogHealthiness", 10);
        PlayerPrefs.SetFloat("DogHappiness", 10);
        PlayerPrefs.SetFloat("DogSatiation", 10);
        PlayerPrefs.SetFloat("DogStress", 10);
        PlayerPrefs.SetFloat("DogEnergy", 10);
    }
    
    public static void deletePreferences(){
        PlayerPrefs.DeleteAll();
    }

    public static void initializeStartup()
    {
        initializeArrayListDogBreed();
    }

    private static void initializeArrayListDogBreed()
    {
        DogList.arrayListDogBreed.Add(new Dog("Poodle"));
        DogList.arrayListDogBreed.Add(new Dog("German Shepherd"));
        DogList.arrayListDogBreed.Add(new Dog("Bulldog"));
    }

}
