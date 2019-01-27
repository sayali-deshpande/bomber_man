using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBlocks : MonoBehaviour
{
    public GameObject WallPrefab;
    public GameObject WormPrefab;
    public GameObject[] WormObjects = new GameObject[0];

    public void SpawnWorm()
    {
        float wormCheckRadius        = 3f;
        int maxSpawnAttemptsPerWorm  = 10;
        int wormsToPlace             = 5;


        for(int i = 0; i< wormsToPlace; i++)
        {
            Vector2 randomPosition = new Vector2(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f));
            //if (isValidPosition(randomPosition))
            //{
                Instantiate(WormPrefab, randomPosition, Quaternion.identity);
            //}
        }
    }

    

    // Start is called before the first frame update
    public void StartGame()
    {
        // Start is called before the first frame update
        var screenHeight = 2f * Camera.main.orthographicSize;
        var screenWidth = screenHeight * Camera.main.aspect;
        var orthoSize = Camera.main.orthographicSize;
        var aspectRatio = (float)Screen.width / (float)Screen.height;
        Debug.Log("Aspect Ratio " + aspectRatio);
        //Output the current screen window width in the console
        Debug.Log("Screen Width : " + Screen.width);

        for (int i = 0; i < screenWidth; i++)
        {
            var obj = Instantiate(WallPrefab);
            obj.isStatic = true;
            obj.transform.position = new Vector3(-aspectRatio * orthoSize + 0.5f + i, -orthoSize + 0.5f, 0);
        }
        for (int i = 0; i < screenWidth; i++)
        {
            var obj = Instantiate(WallPrefab);
            obj.isStatic = true;
            obj.transform.position = new Vector3(-aspectRatio * orthoSize + 0.5f + i, orthoSize - 0.5f, 0);
        }
        for (int i = 0; i < screenHeight; i++)
        {
            var obj = Instantiate(WallPrefab);
            obj.isStatic = true;
            obj.transform.position = new Vector3(-aspectRatio * orthoSize + 0.5f, -orthoSize + 0.5f + i, 0);
        }
        for (int i = 0; i < screenHeight; i++)
        {
            var obj = Instantiate(WallPrefab);
            obj.isStatic = true;
            obj.transform.position = new Vector3(aspectRatio * orthoSize - 0.5f, -orthoSize + 0.5f + i, 0);
        }

        SpawnWorm();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
