using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnGenerator : MonoBehaviour
{
    public GameObject column; // переменная для обращения к колонне;
    public Transform generatorpoint; // точка, проходя через которую генерируются колонны;
    public float distanceBetween; // расстояние между колоннами при генерации
   
  

    void Update() // генерация колонн
    {
        if (transform.position.x < generatorpoint.position.x)
        {
          transform.position = new Vector3(transform.position.x + distanceBetween, Random.Range(-20,30), transform.position.z);
          Instantiate(column, transform.position, transform.rotation);
         }
    }
}
