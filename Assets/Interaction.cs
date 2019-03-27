using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Input;

public class Interaction : MonoBehaviour

{
    private GestureRecognizer recognizer;

    private void Awake()
    {
        recognizer = new GestureRecognizer();
        recognizer.Tapped += (args) =>
        {
            Debug.Log("Tap");
            var headPosition = Camera.main.transform.position;
            var gazeDirection = Camera.main.transform.forward;

            RaycastHit hitInfo;
            if (Physics.Raycast(headPosition, gazeDirection, out hitInfo))
            {
                Debug.Log("Hit");
                GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
                go.transform.position = hitInfo.point;
                go.transform.rotation =
                    Quaternion.FromToRotation(go.transform.up, hitInfo.normal) * go.transform.rotation;
            }
            else
            {
                Debug.Log("No hit");
                GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
                go.transform.position = headPosition + (10 * gazeDirection);
                go.transform.rotation = Camera.main.transform.rotation;
            }
        };
        recognizer.StartCapturingGestures();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
