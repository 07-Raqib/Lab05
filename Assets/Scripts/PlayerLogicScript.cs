using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLogicScript : MonoBehaviour
{
    public ParticleSystem vfx_coin;
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
            GameManager.instance.IncreaseScoreBy(1);
            Destroy(Instantiate(vfx_coin,other.gameObject.transform.position,Quaternion.identity),3f);
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Water"))
        {
            SceneManager.LoadScene("GameLoseScene");
        }
    }
}
