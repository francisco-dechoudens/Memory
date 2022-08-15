using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployCards : MonoBehaviour
{
    public GameObject cardPrefab;

    // Start is called before the first frame update
    void Start()
    {
       
        Instantiate(cardPrefab, new Vector3(0, 0, -1), Quaternion.identity);
        Instantiate(cardPrefab, new Vector3(0, 2, -1), Quaternion.identity);
        Instantiate(cardPrefab, new Vector3(0, 4, -1), Quaternion.identity);
        Instantiate(cardPrefab, new Vector3(2, 4, -1), Quaternion.identity);
    }

    public void spawnCard()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
