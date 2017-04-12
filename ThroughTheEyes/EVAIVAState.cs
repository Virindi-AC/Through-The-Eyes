﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace FirstPerson
{
	public class EVAIVAState
	{
		public Quaternion kerballookrotation = new Quaternion();
		public KerbalEVA myeva = null;
		//public Vector3 PackSASTarget_Rot_Up = Vector3.up;
		//public Vector3 PackSASTarget_Rot_Fwd = Vector3.forward;
		public Vector3 rotationpid_integral = Vector3.zero;
		public Vector3 rotationpid_previouserror = Vector3.zero;
		//public bool rotationsas_state = false;

		//Persist this one globally for now
		static float seva_throttle = 1f;
		public float eva_throttle { get { return seva_throttle; } set { seva_throttle = value; } }

		public void Reset(KerbalEVA eva)
		{
			kerballookrotation = new Quaternion ();
			myeva = eva;

			rotationpid_integral = Vector3.zero;
			rotationpid_previouserror = Vector3.zero;
			//rotationsas_state = false;

			//PackSASTarget_Rot_Up = eva.transform.up;
			//PackSASTarget_Rot_Fwd = eva.transform.forward;

			//eva_throttle = 1f;
		}
	}
}
