using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using UnityEngine.Events;
public class CircularDrivePlus : CircularDrive {
	#region Public Fields
	public UnityEvent<float> AngleEvent;
	#endregion
	#region Private Fields
	#endregion

	#region MyMethods 
	protected override void UpdateLinearMapping()
	{
		if (limited)
		{
			// Map it to a [0, 1] value
			linearMapping.value = (outAngle - minAngle) / (maxAngle - minAngle);
		}
		else
		{
			// Normalize to [0, 1] based on 360 degree windings
			float flTmp = outAngle / 360.0f;
			linearMapping.value = flTmp - Mathf.Floor(flTmp);
			AngleEvent?.Invoke(outAngle % 360f);
		}

		UpdateDebugText();
	}
	#endregion
}
