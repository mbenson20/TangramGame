using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovePiece : MonoBehaviour
{
    private float startPosX;
    private float startPosY;
    private bool isBeingHeld = false;

    public Vector3 rotationPoint;



    void Update()
    {
        if(isBeingHeld)
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, 0);
            if (Input.GetKeyDown(KeyCode.Z))
            {
                transform.RotateAround(rotationPoint, new Vector3(0, 0, 1), 90);
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                transform.RotateAround(rotationPoint, new Vector3(0, 0, 1), -90);
            }
            if(true)
            {

            }
        }
    }


    private void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;
            isBeingHeld = true;
        }

    }

    private void OnMouseUp()
    {
        isBeingHeld = false;

    }

   

    
}
