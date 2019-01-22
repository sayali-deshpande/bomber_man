using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBlocks : MonoBehaviour
{
    public GameObject WallPrefab;
    
    // Start is called before the first frame update
    void Start()
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
