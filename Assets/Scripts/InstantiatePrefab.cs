using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePrefab : MonoBehaviour
{

    public GameObject myPrefab;

    // Start is called before the first frame update
    void whenClicking()
    {
        Instantiate(myPrefab, new Vector3(539, 134, -26), Quaternion.identity);
    }

    
}
