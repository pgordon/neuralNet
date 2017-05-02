using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour {

    float[] inputs;
    float[] outputs;
    int label;

    Card()
    {
        inputs = new float[196];
        outputs = new float[10];
    }

    void imageLoad()
    {
        //each image is 196 bytes, totalling 1,960,000
    }

    void labelLoad()
    {
        // Labels are a total of 10,000 bytes, each one representing the
        //label for the card in question 
        // We then then go through the 10 template outputs and       
        //highlight the correct answer within them.
    }

    void loadData()
    {
        // Uses Processing's inbuilt function "loadBytes()" to load the
        //images and labels  
        // Four out of every five cards is assigned to the training set,  
        //while every fifth card is assigned to the test set instead.
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
