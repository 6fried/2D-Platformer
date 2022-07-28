using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AreaCheck : MonoBehaviour
{
    public List<EnemyBase> capturedEnemies = new List<EnemyBase>();

    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(capturedEnemies.Count <= 5 && collision.tag == "Enemy")
        {
            capturedEnemies.Add(collision.GetComponent<EnemyBase>());
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            capturedEnemies.Add(collision.GetComponent<EnemyBase>());
        }
    }

    private void Update()
    {
        if (Keyboard.current.digit1Key.wasPressedThisFrame)
        {
            if (capturedEnemies.Count >= 1)
            {
                GameManager.instance.player.GetComponent<PlayerController>().process = false;
                if (EnemyBase.selected != null)
                    EnemyBase.selected.mode = Mode.Enemy;
                EnemyBase.selected = capturedEnemies[0];
                capturedEnemies[0].mode = Mode.Player;
                Camera.main.GetComponent<CameraController>().target = capturedEnemies[0].transform;
            }
        }
        if (Keyboard.current.digit2Key.wasPressedThisFrame)
        {
            if (capturedEnemies.Count >= 2)
            {
                GameManager.instance.player.GetComponent<PlayerController>().process = false;
                if (EnemyBase.selected != null)
                    EnemyBase.selected.mode = Mode.Enemy;
                EnemyBase.selected = capturedEnemies[1];
                capturedEnemies[1].mode = Mode.Player;
                Camera.main.GetComponent<CameraController>().target = capturedEnemies[1].transform;
            }
        }
        if (Keyboard.current.digit3Key.wasPressedThisFrame)
        {
            if (capturedEnemies.Count >= 3)
            {
                GameManager.instance.player.GetComponent<PlayerController>().process = false;
                if (EnemyBase.selected != null)
                    EnemyBase.selected.mode = Mode.Enemy;
                EnemyBase.selected = capturedEnemies[2];
                capturedEnemies[2].mode = Mode.Player;
                Camera.main.GetComponent<CameraController>().target = capturedEnemies[2].transform;
            }
        }
        if (Keyboard.current.digit4Key.wasPressedThisFrame)
        {
            if (capturedEnemies.Count >= 4)
            {
                GameManager.instance.player.GetComponent<PlayerController>().process = false;
                if (EnemyBase.selected != null)
                    EnemyBase.selected.mode = Mode.Enemy;
                EnemyBase.selected = capturedEnemies[3];
                capturedEnemies[3].mode = Mode.Player;
                Camera.main.GetComponent<CameraController>().target = capturedEnemies[3].transform;
            }
        }
        if (Keyboard.current.digit5Key.wasPressedThisFrame)
        {
            if (capturedEnemies.Count >= 5)
            {
                GameManager.instance.player.GetComponent<PlayerController>().process = false;
                if (EnemyBase.selected != null)
                    EnemyBase.selected.mode = Mode.Enemy;
                EnemyBase.selected = capturedEnemies[4];
                capturedEnemies[4].mode = Mode.Player;
                Camera.main.GetComponent<CameraController>().target = capturedEnemies[4].transform;
            }
        }
        if (Keyboard.current.digit0Key.wasPressedThisFrame)
        {
            GameManager.instance.player.GetComponent<PlayerController>().process = true;
            if (EnemyBase.selected != null)
                EnemyBase.selected.mode = Mode.Enemy;
            EnemyBase.selected = null;
            Camera.main.GetComponent<CameraController>().target = GameManager.instance.player.transform;
        }
    }

}
