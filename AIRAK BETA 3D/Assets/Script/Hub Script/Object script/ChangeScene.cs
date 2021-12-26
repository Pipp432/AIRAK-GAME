using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            Debug.Log("Enter world 2");
            Scene2();
        }
    }



    public void Scene1()
    {
        SceneManager.LoadScene("Hub");
    }
    public void Scene2()
    {
        SceneManager.LoadScene("Level1");
    }
}
