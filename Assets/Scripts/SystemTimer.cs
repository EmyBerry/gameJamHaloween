using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SystemTimer : MonoBehaviour
{
    [Header("Scriptable Object")]
    [SerializeField] private InfosPlayer _player;
    

    [Space(10)]
    [Header("Temps de jeu")]
    [SerializeField] private TMP_Text _gameTime;
    
    private float _remainingTime;

    void Start()
    {
        _player.gameTime = 180;
        _remainingTime = _player.gameTime;

        _gameTime.text = _remainingTime.ToString();
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
    }

    
    void Update()
    {
        if (_remainingTime > 1) {

            displayTimeLeft(_remainingTime);
            _remainingTime -= Time.deltaTime;
        }
    }

    private void displayTimeLeft(float time) {

        float min = Mathf.FloorToInt(time/60);
        float sec = Mathf.FloorToInt(time % 60);

        _gameTime.text = string.Format("{0:00}:{1:00}",min,sec);
    }
}
