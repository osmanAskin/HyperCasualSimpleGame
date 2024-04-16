using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Food : Finish
{

    private int _isTrigger = 0;
    private int _ScoreAzalt = 10;

    [SerializeField] float minX = -2.7f;
    [SerializeField] float maxX = 2.7f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            float randomX = Random.Range(minX, maxX);

            Transform objectTransform = GetComponent<Transform>();
            objectTransform.position = new Vector3(randomX, objectTransform.position.y, objectTransform.position.z);

            _Score.text = _ScoreAzalt.ToString();
            
            _isTrigger++;
            _ScoreAzalt--;


            if (_isTrigger == 10) 
            {
                WinnerEffects.Play();
                Button_Next.SetActive(true);
                Destroy(_Score);
                Destroy(_collider);
                Destroy(_sprite);
            }

        }

    }
    













}
