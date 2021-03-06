using UnityEngine;

namespace AnimatorParameter
{
	[System.Serializable]
	public class FlagWaver
	{
		public Animator animator;

		protected readonly static int HealthHash = -915003867; public int Health{ get{ return animator.GetInteger(HealthHash); } set{ animator.SetInteger(HealthHash, value); }}
		protected readonly static int PosDifXHash = -66176133; public float PosDifX{ get{ return animator.GetFloat(PosDifXHash); } set{ animator.SetFloat(PosDifXHash, value); }}
		protected readonly static int PosDifYHash = -1962341395; public float PosDifY{ get{ return animator.GetFloat(PosDifYHash); } set{ animator.SetFloat(PosDifYHash, value); }}
		protected readonly static int AbsDifXHash = -2126921761; public float AbsDifX{ get{ return animator.GetFloat(AbsDifXHash); } set{ animator.SetFloat(AbsDifXHash, value); }}
		protected readonly static int AbsDifYHash = -163672247; public float AbsDifY{ get{ return animator.GetFloat(AbsDifYHash); } set{ animator.SetFloat(AbsDifYHash, value); }}
		protected readonly static int InStateTimerHash = 448632149; public float InStateTimer{ get{ return animator.GetFloat(InStateTimerHash); } set{ animator.SetFloat(InStateTimerHash, value); }}
		protected readonly static int OnGroundHash = 1602690925; public bool OnGround{ get{ return animator.GetBool(OnGroundHash); } set{ animator.SetBool(OnGroundHash, value); }}
		protected readonly static int LowHealthHash = -2044772471; public bool LowHealth{ get{ return animator.GetBool(LowHealthHash); } set{ animator.SetBool(LowHealthHash, value); }}
		protected readonly static int HitHash = 1654612129; public bool Hit{ get{ return animator.GetBool(HitHash); } set{ animator.SetBool(HitHash, value); }}
		protected readonly static int DeathHash = 646380074; public bool Death{ get{ return animator.GetBool(DeathHash); } set{ animator.SetBool(DeathHash, value); }}
		public static readonly int Base_Layer_HighHealth_Move = -1860977372;
		public static readonly int Base_Layer_HighHealth_Attack = 1554197360;
		public static readonly int Base_Layer_HighHealth_Move_0 = -1229145739;
		public static readonly int Base_Layer_HighHealth_Shoot = 317181163;
		public static readonly int Base_Layer_HighHealth_Move_1 = -1044674077;
		public static readonly int Base_Layer_HighHealth_Agitate = 195622422;
		public static readonly int Base_Layer_HighHealth_GroundHit = -405197883;
		public static readonly int Base_Layer_HighHealth_Move_2 = 1488115801;
		public static readonly int Base_Layer_LowHealth_Attack = 1377913890;
		public static readonly int Base_Layer_LowHealth_Move = -850484648;
		public static readonly int Base_Layer_LowHealth_StrongAttack = -1712870162;
		public static readonly int Base_Layer_LowHealth_GroundHit = -1578381703;
		public static readonly int Base_Layer_LowHealth_Agitate = -1899805527;
		public static readonly int Base_Layer_LowHealth_Move_1 = -818286927;
		public static readonly int Base_Layer_LowHealth_Move_2 = 1446035211;
		public static readonly int Base_Layer_Init = 1329139992;
		public static readonly int Base_Layer_Death = -1546996312;
		public static readonly int Color_Dummy = -1189355974;
		public static readonly int Color_Damage = 1632915407;
		public static readonly int Scale_HighHealth = -662178201;
		public static readonly int Scale_LowHealth = 1454843698;

	}
}