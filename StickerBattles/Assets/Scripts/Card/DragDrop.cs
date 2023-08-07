using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Photon.Pun;
public class DragDrop : MonoBehaviour
{
    //includes drag and drop system for cards


    //public GameObject DropZone;

    private bool IsDragging = false;



    private GameObject StartParent;

    private Vector2 StartPosition;

    private GameObject DropZone;

    private bool IsOverDropZone;

    PhotonView view;




    private void Start()
    {
        view = GetComponent<PhotonView>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        IsOverDropZone = true;
        DropZone = collision.gameObject;

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        IsOverDropZone = false;
        DropZone = null;

    }







    private void Update()
    {
        if (view.IsMine)
        {
            if (IsDragging) //if 'isdragging == true' can be writtten like this because it is a bool. we can leave it as is or add "== true"
            {
                transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
                transform.SetParent(GameObject.Find("Canvas").transform, true);

            }
        }
        
    }


    public void BeginDrag()
    {
        StartParent = transform.parent.gameObject;
        StartPosition = transform.position;



        IsDragging = true;
        
    }
    public void EndDrag()
    {
        if (IsOverDropZone && DropZone.transform.childCount == 0 && DropZone.tag != "Hand")//if ur over dropzone and said dropzone has no children and isn't a hand
        {
            transform.SetParent(DropZone.transform, false);
            //GetComponent<PhotonTransformViewClassic>().transform.SetParent(DropZone.transform);

        }
        else
        {
            transform.position = StartPosition;
            transform.SetParent(StartParent.transform, false);
        }
        



        IsDragging = false; 
    }



}
