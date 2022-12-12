using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public GameObject gameObject;
    public float time = 2;


    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeSelf)
        {
            StartCoroutine(waitScene(time));
        }
    }
    IEnumerator waitScene(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
