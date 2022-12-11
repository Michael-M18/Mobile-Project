using System;
using System.Collections.Generic;
using UnityEngine;

public class Drop_Area : MonoBehaviour
{
	public List<DropCondition> DropConditions = new List<DropCondition>();
	public event Action<DragableComponent> OnDropHandler;

	public bool Accepts(DragableComponent draggable)
	{
		return DropConditions.TrueForAll(cond => cond.Check(draggable));
	}

	public void Drop(DragableComponent draggable)
	{
		OnDropHandler?.Invoke(draggable);
	}
}