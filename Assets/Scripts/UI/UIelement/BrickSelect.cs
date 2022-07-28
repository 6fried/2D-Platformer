using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrickSelect : MonoBehaviour
{
    [Header("References")]
    [Tooltip("Brick Prefab Reference")]
    public Brick brick = null;
    [Tooltip("BrickSpawn that will add new bricks")]
    public BrickSpawn brickSpawn = null;

    // Start is called before the first frame update
    void Start()
    {
        Image image = GetComponent<Image>();
        image.sprite = brick.GetComponentInChildren<SpriteRenderer>().sprite;
    }

    /// <summary>
    /// Description:
    /// Change the actual brick to spawn
    /// Input:
    /// Brick brick
    /// Return;
    /// void (no return)
    /// </summary>
    /// <param name="brick">The brick to spawn.</param>
    public void SetActualBrick()
    {
        brickSpawn.actualBrick = brick;
    }
}
