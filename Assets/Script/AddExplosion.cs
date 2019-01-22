using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddExplosion : MonoBehaviour
{
    public GameObject explosionPrefab;
    private void OnDestroy()
    {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
    }
}
