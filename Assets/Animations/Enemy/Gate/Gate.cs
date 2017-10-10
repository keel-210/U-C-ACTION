using UnityEngine;

namespace AnimatorParameter
{
	[System.Serializable]
	public class Gate
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
		protected readonly static int LowHealthHash = -2044772471; public bool LowHealth{ get{ return animator.GetBool(LowHealthHash); } set{ animator.SetBool(LowHealthHash, value); }}
		protected readonly static int DeathHash = 646380074; public bool Death{ get{ return animator.GetBool(DeathHash); } set{ animator.SetBool(DeathHash, value); }}
		public static readonly int Base_Layer_HighHealth_Idle = -1576452279;
		public static readonly int Base_Layer_HighHealth_RightAttack = -615393290;
		public static readonly int Base_Layer_HighHealth_LeftAttack = 1300614863;
		public static readonly int Base_Layer_HighHealth_Move = -1860977372;
		public static readonly int Base_Layer_LowHealth_AirIdle = 627636612;
		public static readonly int Base_Layer_LowHealth_AllAttack = 804359008;
		public static readonly int Base_Layer_LowHealth_AirMove = 376601577;
		public static readonly int Base_Layer_LowHealth_Groound2Air = -630655602;
		public static readonly int Base_Layer_LowHealth_Stan = -5598341;
		public static readonly int Base_Layer_Init = 1329139992;
		public static readonly int Base_Layer_Death = -1546996312;
		public static readonly int Alpha_Dummy = 474473175;
		public static readonly int Alpha_Damage = -1085633226;

	}
}