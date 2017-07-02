using UnityEngine;

namespace AnimatorParameter
{
	[System.Serializable]
	public class Trex
	{
		public Animator animator;

		protected readonly static int ForwardHash = 673977882; public float Forward{ get{ return animator.GetFloat(ForwardHash); } set{ animator.SetFloat(ForwardHash, value); }}
		public static readonly int Base_Layer_Idle = 1432961145;
		public static readonly int Base_Layer_Walk = 81563449;

	}
}