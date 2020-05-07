using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Rockett : MonoBehaviour
{
     public Rigidbody2D rigidBody; // создание переменной для обращения к телу ракеты
     public float force; // сила поддталкивания ракеты
     public int points;
     public Text score; // вывод на экран очков
     int scoreCounter = 0; // информация о том, какой сейчас счет.
    void Update() // метод проверки каждого кадра в юнити на нажатие кнопки
    {
        score.text = "Score:" + scoreCounter;
        if (Input.GetKeyDown(KeyCode.Space)) // условие фиксация нажатия пробела
        {
            rigidBody.AddForce(Vector2.up * force, mode: ForceMode2D.Impulse); // направляем птицу вверх
        }
    }
    private void OnCollisionEnter2D(Collision2D other) // метод удаления из игры ракеты при столкновении с колонной
    {
        Debug.Log(message:"Вы проиграли!");
        scoreCounter = 0;
        Application.LoadLevel(Application.loadedLevel);
    }
    private void OnTriggerEnter2D(Collider2D other) //  метод увеличения очков при соприкосновении с триггером между колоннами
    {
        scoreCounter +=1;

        
    }

} 