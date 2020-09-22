using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock_Generator : MonoBehaviour
{
    [Tooltip("Spawn Position´s")]
    public Transform[] RandomPositions;

    [Tooltip("Tagñ´s Object")]
    public string[] Tag;

    public float SpawTime;

    void Start()
    {   
        //Just for this occasion use InvokeRepeating to invoke the obstacles
        InvokeRepeating("InstanciateObject", 1.2f, SpawTime);
    }

   
    /*--------------[ Spawn Obstacle Method]--------------*/
    public void InstanciateObject()
    {
        int RandomObject = Random.Range(0, Tag.Length);

        GameObject Obstacle_Object = PoolingObject.SharedInstance.GetPooledObject(Tag[RandomObject]);

        if (Obstacle_Object != null) {

            int RandomPos = Random.Range(0, RandomPositions.Length);
            Obstacle_Object.transform.position = RandomPositions[RandomPos].transform.position;

            //I send the information thanks to the patron singleton.
            Score.Instance_Score.ObjectPool++;

            //Here the objects are activated according to the position found in the object pooling.
            Obstacle_Object.SetActive(true);

        }
    }

}
