using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 800.0f;
    public Text scoreText;
    public Text winText;
    public Text colorText;
    public Material PlayerColor;
    Vector3 vec = new Vector3(3f, 3f, 3f);
    private int count = 0;

    void Awake()
    {
        colorText.text = "Selected Color: " + PickColor.playerColor;
        ChangePlayerColor();

        if (ChangeSpeed.gameSpeed > 0f) {
            SetGameSpeed();
        }
        

        
        if (GiantMode.giant == true)
        {
            GiantBall();
        }
        
        

    }

    private void GiantBall()
    {
          transform.localScale = vec;
    }

    private void SetGameSpeed()
    {
        speed = speed * (ChangeSpeed.gameSpeed * 0.4f);
    }

    public void ChangePlayerColor()
    {
        switch (PickColor.playerColor)
        {
            case 1:
                PlayerColor.color = Color.red;
                break;
            case 2:
                PlayerColor.color = Color.green;
                break;
            case 3:
                PlayerColor.color = Color.blue;
                break;
            default:
                PlayerColor.color = Color.red;
                break;

        }
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);



        
    }

    void EndGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);
            count += 1;
            scoreText.text = "Score: " + count;
        }

        if (count >= 16)
        {
            winText.gameObject.SetActive(true);
            Invoke("EndGame", 2);
        }


    }
}
