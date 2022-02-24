using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private int Score;
    public int speed;
    public int maxCollectible;
    public GameObject pauseWindow, winPanel;
    public GameObject score;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        score.GetComponent<Text>().text = "Score : " + Score;
    }
   
    void Update()
    {
        if (pauseWindow.activeSelf) //jika pauseWindow aktif maka game akan berhenti
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
        score.GetComponent<Text>().text = "Score : " + Score;

        if (Score == maxCollectible)
        {
            winPanel.SetActive(true);
        }
    }

    void FixedUpdate()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalMove, 0, verticalMove);

            rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("collectible"))
        {
            //other.gameObject.SetActive(false);
            Score += 1;
            Destroy(other.gameObject);
        }
    }

}
