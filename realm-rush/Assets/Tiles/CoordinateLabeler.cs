using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


[ExecuteAlways]
public class CoordinateLabeler : MonoBehaviour
{

    TextMeshPro label;
    Vector2Int coordinates = new Vector2Int();

    // very first step of game ( before start )
    void Awake()
    {
        label = GetComponent<TextMeshPro>();
        DisplayCoordinates();
    }
    // Update is called once per frame
    void Update()
    {
        //Script will only execute in edit mode.
       if(!Application.isPlaying){
           DisplayCoordinates();
           UpdateObjectName();
       }
    }

    void DisplayCoordinates(){
        // Divided by grid that we set it as 10.
        coordinates.x =  Mathf.RoundToInt(transform.parent.position.x / UnityEditor.EditorSnapSettings.move.x);
        coordinates.y =  Mathf.RoundToInt(transform.parent.position.z / UnityEditor.EditorSnapSettings.move.z);
        label.text = coordinates.x + ":" + coordinates.y;
    }

    void UpdateObjectName(){
        transform.parent.name = coordinates.ToString();
    }
}
