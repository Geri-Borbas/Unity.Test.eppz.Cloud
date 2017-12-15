using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[ExecuteInEditMode]
public class CanvasScaleToScreenWidthConstraint : MonoBehaviour
{


	public AnimationCurve canvasScaleToScreenWidth;
	
	
	void Update()
	{
		GetComponent<CanvasScaler>().scaleFactor =
			canvasScaleToScreenWidth.Evaluate(Screen.width);
	}
}
