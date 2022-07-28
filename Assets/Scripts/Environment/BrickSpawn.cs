using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSpawn : MonoBehaviour
{
    [Header("Brick Prefabs")]
    [Tooltip("Actual Brick to spawn")]
    public Brick actualBrick = null;

    /// <summary>
    /// Description:
    /// Spawns the brick once.
    /// Input:
    /// Vector3 position
    /// </summary>
    /// <param name="position">The position where to spawn the brick</param>
    public void SpawnBrick(Vector3 position)
    {
        Brick brickToSpawn = Instantiate(actualBrick, position, actualBrick.transform.rotation);
    }

}
