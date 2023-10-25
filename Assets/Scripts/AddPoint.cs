using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cauldron : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI pointsDisplay;
    [SerializeField] private InfosPlayer playerPoints;
    private float currentPoints;
    private float requiredPoints;

    void Start()
    {
        playerPoints.points = 0;
        currentPoints = playerPoints.points;

        playerPoints.requiredPoints = 10;
        requiredPoints = playerPoints.requiredPoints;
    }

    void Update()
    {
        DisplayPoints();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!(currentPoints < requiredPoints && other.gameObject.tag == "Points")) return;
            playerPoints.points++;
            //pointsDisplay.text = ""+currentPoints;
            Destroy(other.gameObject);
    }

    private void DisplayPoints() {
        pointsDisplay.text = playerPoints.points.ToString();
    }
}
