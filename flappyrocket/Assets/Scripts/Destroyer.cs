using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public GameObject destroypoint; // точка удаления колонн
    
    void Start() 
    {
        destroypoint = GameObject.Find("DestroyPoint"); // присваивание точке объекта удаления колонн
    }

    // Update is called once per frame
    void Update() // метод удаления колонн
    {
        if (transform.position.x < destroypoint.transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}
