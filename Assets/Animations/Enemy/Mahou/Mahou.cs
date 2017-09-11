using UnityEngine;

namespace AnimatorParameter
{
	[System.Serializable]
	public class Mahou
	{
		public Animator animator;

		protected readonly static int HealthHash = -915003867; public int Health{ get{ return animator.GetInteger(HealthHash); } set{ animator.SetInteger(HealthHash, value); }}
		protected readonly static int PosDifXHash = -66176133; public float PosDifX{ get{ return animator.GetFloat(PosDifXHash); } set{ animator.SetFloat(PosDifXHash, value); }}
		protected readonly static int PosDifYHash = -1962341395; public float PosDifY{ get{ return animator.GetFloat(PosDifYHash); } set{ animator.SetFloat(PosDifYHash, value); }}
		protected readonly static int AbsDifXHash = -2126921761; public float AbsDifX{ get{ return animator.GetFloat(AbsDifXHash); } set{ animator.SetFloat(AbsDifXHash, value); }}
		protected readonly static int AbsDifYHash = -163672247; public float AbsDifY{ get{ return animator.GetFloat(AbsDifYHash); } set{ animator.SetFloat(AbsDifYHash, value); }}
		protected readonly static int InStateTimerHash = 448632149; public float InStateTimer{ get{ return animator.GetFloat(InStateTimerHash); } set{ animator.SetFloat(InStateTimerHash, value); }}
		protected readonly static int HitHash = 1654612129; public bool Hit{ get{ return animator.GetBool(HitHash); } set{ animator.SetBool(HitHash, value); }}
		protected readonly static int OnGroundHash = 1602690925; public bool OnGround{ get{ return animator.GetBool(OnGroundHash); } set{ animator.SetBool(OnGroundHash, value); }}
		public static readonly int Base_Layer_Hit = -1005802792;
		public static readonly int Base_Layer_Death = -1546996312;
		public static readonly int Base_Layer_Attack = 1130333774;
		public static readonly int Base_Layer_Destroy = 1545706595;
		public static readonly int Base_Layer_Idle = 1432961145;
		public static readonly int Base_Layer_Move = 1718862356;
		public static readonly int Alpha_Destroy = -145048504;
		public static readonly int Alpha_Damage = -1085633226;
		public static readonly int Alpha_Idle = -593007129;
		public static readonly int Alpha_Init = -956875642;

	}
}