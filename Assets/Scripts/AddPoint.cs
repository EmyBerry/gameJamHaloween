using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cauldron : MonoBehaviour
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
        if(!(currentPoints < requiredPoints && other.gameObject.tag == "Points")) return;
            currentPoints++;
            pointsDisplay.text = ""+currentPoints;
            Destroy(other.gameObject);
    }
}
