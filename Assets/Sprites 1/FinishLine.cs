using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float delay = 2f;
    [SerializeField] ParticleSystem particalEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            particalEffect.Play();
            Invoke("ReloadScene", delay);
        }
        
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
