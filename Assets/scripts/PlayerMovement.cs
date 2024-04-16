using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public ParticleSystem DestroyEffect;
    public GameObject Button_Again;
    public SpriteRenderer _sprite;
    public BoxCollider2D _collider;

    void Update()
    {
        ClampPositionX();
        ClampPositionY();
        TouchMovement();

    }

    public void ClampPositionY() 
    {
        float yPosition = transform.position.y;
        transform.position = new Vector3(transform.position.x, yPosition, transform.position.z);
    }
    public void ClampPositionX() 
    {
        float xPosition = transform.position.x;

        float minX = -2.3f;
        float maxX = 2.3f;

        transform.position = new Vector3(Mathf.Clamp(xPosition, minX, maxX), transform.position.y);
    }
    

    public void TouchMovement() 
    {
        if (Input.touchCount == 1)//ekrana kac parmak dokundugunu gosterir
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0f;

            // Oyuncunun Y konumunu sabit tut
            touchPosition.y = transform.position.y;

            transform.position = touchPosition;
        }
    }


    
         void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Trap")
            {
                Destroy(_sprite);
                Destroy(_collider);
                
                Button_Again.SetActive(true);
                DestroyEffect.Play();
            //OnParticleEffect();
            //OnDestroy();

        }

        }
    

    
    //public void OnDestroy()
    //{
        
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    //}
   
}
