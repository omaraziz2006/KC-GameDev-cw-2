using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class where : MonoBehaviour
{

    string heroname = "ragnar"; 
    string villan = "kai";
    int ha = 9;
    int va = 10000;

    // Start is called before the first frame update
    void Start()
    {
        print("there once was a hero named" + heroname);
        print("and as usual a villan who is named" + villan);
        print("the heros age is" + ha + "and the villans age is" + va);
        print("each one of them is centuries old so the age difference between them is" + (va - ha) + "centuries");   








        
    }

   
}
