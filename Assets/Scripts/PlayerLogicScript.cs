using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLogicScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            GameManager.instance.IncreaseScoreBy(10);
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Water"))
        {
            SceneManager.LoadScene("GameLoseScene");
        }
    }
}
