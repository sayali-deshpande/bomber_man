using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBomb : MonoBehaviour
{
    public GameObject bombPrefab;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 playerPos = transform.position;
            playerPos.x = Mathf.Round(playerPos.x);
            Instantiate(bombPrefab, playerPos, Quaternion.identity);
        }
    }
}
