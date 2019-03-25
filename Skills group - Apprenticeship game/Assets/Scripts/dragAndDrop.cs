using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragAndDrop : MonoBehaviour
{
    private bool draggingItem = false;
    private GameObject draggedObject;
    private Vector2 touchOffset;

    void Update()
    {
        if (HasInput)
        {
            DragOrPickUp();
        }
        else
        {
            if (draggingItem)
                DropItem();
        }
    }

    Vector2 CurrentTouchPosition
    {
        get
        {
            //takes position of the mouse based on where it is in the cameras view
            Vector2 inputPos;
            inputPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            return inputPos;
        }
    }

    private void DragOrPickUp()
    {
        var inputPosition = CurrentTouchPosition;

        if (draggingItem)
        {
            //move object position using the input and the offset
            draggedObject.transform.position = inputPosition + touchOffset;
        }
        else
        {
            RaycastHit2D[] touches = Physics2D.RaycastAll(inputPosition, inputPosition, 0.5f);
            if (touches.Length > 0)
            {
                var hit = touches[0];
                if (hit.transform != null)
                {
                    draggingItem = true;
                    draggedObject = hit.transform.gameObject;
                    touchOffset = (Vector2)hit.transform.position - inputPosition;
                    draggedObject.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
                }
            }
        }
    }

    private bool HasInput
    {
        get
        {
            // returns true if either the mouse button is down or at least one touch is felt on the screen
            return Input.GetMouseButton(0);
        }
    }

    void DropItem()
    {
        //stops the object from being dragged and resets the scale
        draggingItem = false;
        draggedObject.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
    }
}
