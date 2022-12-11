using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    protected Drop_Area Drop_Area;

    protected virtual void Awake()
    {
        Drop_Area = GetComponent<Drop_Area>() ?? gameObject.AddComponent<Drop_Area>();
        Drop_Area.OnDropHandler += OnItemDropped;
    }

    private void OnItemDropped(DragableComponent dragable)
    {
        dragable.transform.position = transform.position;
    }
}
