using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AddPoint : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI pointsDisplay;
    [SerializeField] private Points playerPoints;
    private int currentPoints;
    private int requiredPoints;

    private void Start()
    {
        currentPoints = playerPoints.currentPoints;
        requiredPoints = playerPoints.requiredPoints;
    }

    private void OnCollisionEnter(Collision other)
    {
        if(!(requiredPoints < currentPoints && other.gameObject.tag == "Points")) {
            currentPoints++;
            pointsDisplay.text = ""+currentPoints;
            //TODO : Delete GameObject
            
        }
    }
}
