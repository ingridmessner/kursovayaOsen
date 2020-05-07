using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
    public float speed; // переменная для скорости передвижения колонны
    void Update() 
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime); // метод перемещения колонны влево * на скорость * на время прошедшее между кадрами
    }
}
