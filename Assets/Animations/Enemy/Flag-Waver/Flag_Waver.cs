using UnityEngine;

namespace AnimatorParameter
{
	[System.Serializable]
	public class Flag_Waver
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
		protected readonly static int IsRecoveryedHash = 2109366716; public bool IsRecoveryed{ get{ return animator.GetBool(IsRecoveryedHash); } set{ animator.SetBool(IsRecoveryedHash, value); }}
		protected readonly static int DownHash = -1127399675; public bool Down{ get{ return animator.GetBool(DownHash); } set{ animator.SetBool(DownHash, value); }}
		public static readonly int Base_Layer_Idle = 1432961145;
		public static readonly int Base_Layer_Move = 1718862356;
		public static readonly int Base_Layer_Attack = 1130333774;
		public static readonly int Base_Layer_Agitate = -891939056;
		public static readonly int Base_Layer_Down = -1783470761;
		public static readonly int Base_Layer_Death = -1546996312;
		public static readonly int Base_Layer_Recovery = -535863163;
		public static readonly int Base_Layer_GroundHit = 1720623059;
		public static readonly int Base_Layer_Shoot = 885627960;
		public static readonly int Base_Layer_Init = 1329139992;
		public static readonly int Alpha_Idle = -593007129;
		public static readonly int Alpha_Damage = -1085633226;

	}
}